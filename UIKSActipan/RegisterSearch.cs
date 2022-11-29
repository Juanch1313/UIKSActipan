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
    public partial class RegisterSearch : Form
    {
        public RegisterSearch()
        {
            InitializeComponent();
        }

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Patient> patients = new List<Patient>();
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                patients = commands.getPatients();
                dgvPatients.DataSource = patients;
            }
            else
            {
                patients = commands.getPatient(txtSearch.Text);
                dgvPatients.DataSource = patients;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 1)
            {
                string date = DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Year.ToString();

                int columna = dgvPatients.CurrentRow.Index;
                string patientFolder = dgvPatients.Rows[columna].Cells[1].Value.ToString() + " " + dgvPatients.Rows[columna].Cells[2].Value.ToString();
                patientFolder = patientFolder.Replace(" ", "-");
                string folderDate = patientFolder + "-" + date;
                date = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                if (Convert.ToBoolean(dgvPatients.Rows[columna].Cells[10].Value))
                {

                    Files.AddRootDirectory();
                    Files.AddSubRootDirectory(patientFolder);
                    if (!Files.AddSubRegistersDirectory(folderDate))
                    {
                        if (commands.InsertRegister(date, Convert.ToInt32(dgvPatients.Rows[columna].Cells[0].Value)) == 1)
                        {
                            Files.CheckRegisters();
                            Files.copyFiles(true);
                            Files.OpenFiles();
                        }
                        else
                        {
                            MessageBox.Show("Error al ingresar datos a la tabla archivo en la base de datos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya se ha realizado un registro del paciente hoy");
                    }
                    txtSearch.Clear();
                    txtSearch.Focus();
                    dgvPatients.DataSource = null;
                }
                else
                {
                    MessageBox.Show("El paciente seleccionado esta inactivo");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona una sola fila");
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 1)
            {
                string date = DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Year.ToString();

                int columna = dgvPatients.CurrentRow.Index;
                string patientFolder = dgvPatients.Rows[columna].Cells[1].Value.ToString() + " " + dgvPatients.Rows[columna].Cells[2].Value.ToString();
                patientFolder = patientFolder.Replace(" ", "-");
                string folderDate = patientFolder + "-" + date;
                date = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                if (Convert.ToBoolean(dgvPatients.Rows[columna].Cells[10].Value))
                {
                    if (commands.InsertRegister(date, Convert.ToInt32(dgvPatients.Rows[columna].Cells[0].Value)) == 1)
                    {
                        Files.AddRootDirectory();
                        Files.AddSubRootDirectory(patientFolder);
                        if (!Files.AddSubRegistersDirectory(folderDate))
                        {
                            Files.CheckRegisters();
                            Files.copyFiles(false);
                            Files.OpenFiles();
                        }
                        else
                        {
                            MessageBox.Show("Ya se ha realizado un registro del paciente hoy");
                        }
                        txtSearch.Clear();
                        txtSearch.Focus();
                        dgvPatients.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar datos a la tabla archivo en la base de datos");
                    }
                }
                else
                {
                    MessageBox.Show("El paciente seleccionado esta inactivo");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona almenos una sola fila");
            }
        }
    }
}
