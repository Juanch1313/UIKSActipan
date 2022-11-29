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
    public partial class ModifyE : Form
    {
        public ModifyE()
        {
            InitializeComponent();
            HidePass.Visible = false;
        }
        private static User user = new User();

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
            WindowState = FormWindowState.Minimized;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSelect.Visible = true;
            //Condicional para saber si se buscara un usuario especifico o se buscaran todos
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                dgvEmploys.DataSource = commands.getEmploys(); ;
            }
            else
            {
                dgvEmploys.DataSource = commands.getEmploy(txtSearch.Text);
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            btnModify.Visible = true;
            //Aqui al usuario que se haya seleccionado se pondran sus datos en los campos Text para su edicion
            if (dgvEmploys.SelectedRows.Count == 1)
            {
                int column = dgvEmploys.CurrentRow.Index;
                txtName.Text = dgvEmploys.Rows[column].Cells[1].Value.ToString();
                txtLastNames.Text = dgvEmploys.Rows[column].Cells[2].Value.ToString();
                txtUser.Text = dgvEmploys.Rows[column].Cells[3].Value.ToString();
                txtPosition.Text = dgvEmploys.Rows[column].Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe tener solo una columna seleccionada");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int column = dgvEmploys.CurrentRow.Index;
            user.id = Convert.ToInt32(dgvEmploys.Rows[column].Cells[0].Value.ToString());
            user = commands.getUser(user.id);
            btnModify.Visible = false;
            btnSelect.Visible = false;
            //Si no se desea modificar la contraseña editara todo lo demas de el usuario seleccionado
            if(String.IsNullOrEmpty(txtPass.Text))
            {
                user.firstName = txtName.Text;
                user.lastNames = txtLastNames.Text;
                user.user = txtUser.Text;
                user.position = txtPosition.Text;
                if (commands.updateEmploy(user, user.id) == 1)
                {
                    MessageBox.Show("Modificacion exitosa!!");
                    cleanAll();
                }
                else
                {
                    MessageBox.Show("Algo paso al modificar el empleado!");
                }
            }
            else
            {
                //Se comprueba que la contraseña cumpla con ciertas condiciones si se cumple se modificaran los datos incluida la contraseña
                if(commands.CheckPassword(txtPass.Text, txtPass.Text))
                {
                    user.firstName = txtName.Text;
                    user.lastNames = txtLastNames.Text;
                    user.user = txtUser.Text;
                    user.password = commands.GetMD5(txtPass.Text);
                    user.position = txtPosition.Text;
                    if (commands.updateEmploy(user, user.id) == 1)
                    {
                        MessageBox.Show("Modificacion exitosa!!");
                        cleanAll();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no se modifico");
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña no cumple con las condiciones");
                    txtPass.Clear();
                    txtPass.Focus();
                }
            }
        }

        private void cleanAll()
        {
            txtName.Clear();
            txtLastNames.Clear();
            txtPass.Clear();
            txtPosition.Clear();
            txtPass.Clear();
            txtSearch.Clear();
            dgvEmploys.DataSource = null;
            txtSearch.Focus();
        }

        private void HidePass_Click(object sender, EventArgs e)
        {
            /*Cambia el atributo PasswordChar a '*'(asterisco)*/
            txtPass.PasswordChar = '*';
            SeePass.Visible = true;
            HidePass.Visible = false;
        }

        private void SeePass_Click(object sender, EventArgs e)
        {
            /*Cambia el atributo PasswordChar a caracter "nulo"*/
            txtPass.PasswordChar = '\0';
            SeePass.Visible = false;
            HidePass.Visible = true;
        }
    }
}
