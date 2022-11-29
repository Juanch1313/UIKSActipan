using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIKSActipan.Functions;
using UIKSActipan.mySQL;

namespace UIKSActipan
{
    public partial class ModifyP : Form
    {
        public ModifyP()
        {
            InitializeComponent();
        }

        private string _name = "", _lastName = "";

        //Mover ventana
        /*Se usan recursos del sistema para poder realizar el movimiento de la ventana*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        //Fin mover ventanta

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cleanAll();
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSelect.Visible = true;
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                dgvPatients.DataSource = commands.getPatients();
            }
            else
            {
                dgvPatients.DataSource = commands.getPatient(txtSearch.Text);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            btnModify.Visible = true;
            //Confirmamos que solo se haya hecho una seleccion y posterir colocamos lso datos del paciente en los campos Text
            if(dgvPatients.SelectedRows.Count == 1)
            {
                int column = dgvPatients.CurrentRow.Index;
                _name = txtName.Text = dgvPatients.Rows[column].Cells[1].Value.ToString();
                _lastName = txtLastNames.Text = dgvPatients.Rows[column].Cells[2].Value.ToString();
                cbGenero.Text = dgvPatients.Rows[column].Cells[3].Value.ToString();
                txtCell.Text = dgvPatients.Rows[column].Cells[4].Value.ToString();
                txtAdress.Text = dgvPatients.Rows[column].Cells[5].Value.ToString();
                dtp_birthday.Text = dgvPatients.Rows[column].Cells[6].Value.ToString();
                cbEstadoCivil.Text = dgvPatients.Rows[column].Cells[7].Value.ToString();
                cbEscolaridad.Text = dgvPatients.Rows[column].Cells[8].Value.ToString();
                txtOcupation.Text  = dgvPatients.Rows[column].Cells[9].Value.ToString();
                cbEstado.Text = (dgvPatients.Rows[column].Cells[10].Value.ToString() == "False" ? "Inactivo" : "Activo");
            }
            else
            {
                MessageBox.Show("Solo debe tener una fila seleccionada");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            btnModify.Visible = false;
            btnSelect.Visible = false;
            //Se crea un objeto paciente y se le colocaran los datos editados posterior se hara la llamada a la modificacion
            Patient patient = new Patient();
            patient.id = commands.getPetientID(_name, _lastName);
            patient.nombre = txtName.Text;
            patient.apellidos = txtLastNames.Text;
            patient.genero = Convert.ToChar(cbGenero.SelectedItem.ToString());
            patient.telefono = txtCell.Text;
            patient.domicilio = txtAdress.Text;
            patient.nacimiento = dtp_birthday.Text;
            patient.estadoCivil = cbEstadoCivil.SelectedItem.ToString();
            patient.escolaridad = cbEscolaridad.SelectedItem.ToString();
            patient.ocupacion = txtOcupation.Text;
            patient.estado = (cbEstado.SelectedIndex == 0 ? false : true);

            if(commands.updatePatient(patient, patient.id) == 1)
            {
                MessageBox.Show("Paciente modificado con exito!!!");
                cleanAll();
            }
            else
            {
                MessageBox.Show("Algo paso al modificar el paciente!");
            }
        }

        private void cleanAll()
        {
            txtName.Clear();
            txtLastNames.Clear();
            txtSearch.Clear();
            txtCell.Clear();
            txtAdress.Clear();
            txtOcupation.Clear();
            cbEscolaridad.SelectedIndex = -1;   cbEscolaridad.Text = "--Elige--";
            cbEstado.SelectedIndex = -1;        cbEstado.Text = "--Elige--";
            cbEstadoCivil.SelectedIndex = -1;   cbEstadoCivil.Text = "--Elige--";
            cbGenero.SelectedIndex = -1;        cbGenero.Text = "--Elige--";
            dgvPatients.DataSource = null;
        }
    }
}
