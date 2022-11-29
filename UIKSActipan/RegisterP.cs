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
    public partial class RegisterP : Form
    {
        public RegisterP()
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            cleanAll();
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Se confirma que el usuario no haya dejado algun campo vacio
            if(String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtApellidos.Text) ||
               String.IsNullOrEmpty(txtDomicilio.Text) || String.IsNullOrEmpty(txtOcupacion.Text) ||
               String.IsNullOrEmpty(txtTelefono.Text))
            {
                if(cbGenero.SelectedIndex == -1 || cbEstadoCivil.SelectedIndex == -1
                   || cbEscolaridad.SelectedIndex == -1 || cbEstado.SelectedIndex == -1)
                {
                    MessageBox.Show("Asegurese de rellenar todos los campos textutales y seleccionables");

                }
                else
                {
                    MessageBox.Show("Asegurese de rellenar todos los campos textutales");
                }
            }
            else
            {
                if(cbGenero.SelectedIndex == -1 || cbEstadoCivil.SelectedIndex == -1
                   || cbEscolaridad.SelectedIndex == -1 || cbEstado.SelectedIndex == -1)
                {
                    MessageBox.Show("Asegurese de rellenar todos los campos textutales y seleccionables");

                }
                else
                {
                    //Obtenemos el ultimo ID de paciente para poder añadir el siguiente con el nuevo ID que sera ID + 1
                    commands.getLastPatientId();
                    Patient patient = new Patient(commands.get_lastPatientID()+1, txtName.Text, txtApellidos.Text, Convert.ToChar(cbGenero.SelectedItem), txtTelefono.Text,
                        txtDomicilio.Text, dtp_birthday.Text, cbEstadoCivil.SelectedItem.ToString(), cbEscolaridad.Text, txtOcupacion.Text, Convert.ToBoolean(cbEstado.SelectedIndex));

                    if (commands.InsertPatient(patient) == 1) { MessageBox.Show("Paciente Registrado!!"); cleanAll(); dtp_birthday.Value = DateTime.Now; };
                }
                
            }
        }

        private void cleanAll()
        {
            txtName.Clear();
            txtApellidos.Clear();
            txtDomicilio.Clear();
            txtOcupacion.Clear();
            txtTelefono.Clear();

            cbEscolaridad.SelectedItem = -1;
            cbEscolaridad.Text = "-Elige-";

            cbEstado.SelectedItem = -1;
            cbEstado.Text = "-Elige-";

            cbEstadoCivil.SelectedItem = -1;
            cbEstadoCivil.Text = "-Elige-";

            cbGenero.SelectedItem = -1;
            cbGenero.Text = "-Elige-";
        }
    }
}
