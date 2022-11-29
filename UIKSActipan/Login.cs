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
using System.Threading;

namespace UIKSActipan
{
    public partial class Login : Form
    {
        private Index index = new Index();
        private IndexW indexw = new IndexW();
        private User _actualEmploy = new User();
        public Login()
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

        /*Funcion que se se manda a llamar con los parametros debidos para mover la ventana*/
        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*Activa el evento click de el boton que cerrara el programa*/
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*Activa el evento click de el boton que minimizara la ventana*/
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*Boton que hara consulta en la base de datos para chiquear que el
         usuario y la contraseña sean los correctos*/
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtUser.Text) || String.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Falta por llegar una o mas casillas del formulario.");
                ClearText();
            }
            else
            {
                _actualEmploy = commands.getLoggin(txtUser.Text);
                string password = commands.GetMD5(txtPass.Text);
                
                //Condicional para comprobar que tipo de index se abrira
                if (_actualEmploy.user == txtUser.Text && password == _actualEmploy.password && (_actualEmploy.position == "ADMIN" || _actualEmploy.position == "CONSEJERO"))
                {
                    this.Hide();
                    index.ShowDialog();
                    this.Show();
                    ClearText();

                }
                else if(_actualEmploy.user == txtUser.Text && password == _actualEmploy.password)
                {
                    this.Hide();
                    indexw.ShowDialog();
                    this.Show();
                    ClearText();
                }
                else
                {
                    ClearText();
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
                
            }
        }

        /*Funcion para limpiar las casillas de texto dentro de la ventana LOGIN*/
        public void ClearText()
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
        }

    }
}
