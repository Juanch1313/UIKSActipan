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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            HidePass.Visible = false;
            txtName.Focus();
        }

        //Mover ventana
        /*Se usan recursos del sistema para poder realizar el movimiento de la ventana*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        //Fin mover ventanta

        /*Funcion que se se manda a llamar con los parametros debidos para mover la ventana*/
        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*Activa el evento click de el boton que cerrara el programa*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            cleanAll();
            this.Close();
        }

        /*Activa el evento click de el boton que minimizara la ventana*/
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*Funciones que permiten mostrar y ocultar las casillas de contraseña*/
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*Cambia el atributo PasswordChar a caracter "nulo"*/
            txtPass.PasswordChar = '\0';
            SeePass.Visible = false;
            HidePass.Visible = true;
        }

        private void HidePass_Click(object sender, EventArgs e)
        {
            /*Cambia el atributo PasswordChar a '*'(asterisco)*/
            txtPass.PasswordChar = '*';
            SeePass.Visible = true;
            HidePass.Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {   /*Verifica si alguna de las casillas del formulario estan vacias*/
            /*De estarlo mandara error*/
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtLastNames.Text) || 
                String.IsNullOrEmpty(txtUser.Text) || String.IsNullOrEmpty(txtPass.Text) ||
                String.IsNullOrEmpty(txtConPass.Text))
            {
                lbError.Text = "Por favor asegurese de llenar todas las casillas";
            }
            else
            {
                //Se comprueba que la contraseña cumpla con ciertas condiciones
                if(commands.CheckPassword(txtPass.Text, txtConPass.Text))
                {
                    //Se crea un nuevo usuario y se checa que se pueda añadir a la base de datos
                    User user = new User(1, txtName.Text, txtLastNames.Text, txtUser.Text, txtPass.Text, txtPosition.Text);
                    if (commands.InsertEmploy(user) == 1)
                    {
                        MessageBox.Show("Empleado registrado!!!");
                        cleanAll();
                    }
                }
                else
                {
                    txtPass.Clear(); txtConPass.Clear();
                    txtPass.Focus();
                }
            }
        }

        private void cleanAll()
        {
            txtName.Clear();
            txtLastNames.Clear();
            txtUser.Clear();
            txtPosition.Clear();
            txtPass.Clear();
            txtConPass.Clear();
        }
    }
}
