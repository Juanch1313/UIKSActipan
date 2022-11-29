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
using System.Diagnostics;
using UIKSActipan.Functions;
using UIKSActipan.mySQL;

namespace UIKSActipan
{
    public partial class SearchP : Form
    {
        public SearchP()
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                dgvPatients.DataSource = commands.getPatients();
            }
            else
            {
                dgvPatients.DataSource = commands.getPatient(txtSearch.Text);
            }
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            if(dgvPatients.SelectedRows.Count == 1)
            {
                int column = dgvPatients.CurrentRow.Index;
                string _name = dgvPatients.Rows[column].Cells[1].Value.ToString();
                string _lastName = dgvPatients.Rows[column].Cells[2].Value.ToString();
                string folder = Files.getPath();
                _name = ((_name.Replace(" ", "-")) + "-" + (_lastName.Replace(" ", "-")));
                Process.Start("explorer.exe", folder+_name);
            }
        }
    }
}
