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
    public partial class SeeRegisters : Form
    {
        public SeeRegisters()
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
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SeeRegisters_Load(object sender, EventArgs e)
        {
            List<RegistersData> registers = new List<RegistersData>();
            List<string> employNames = commands.getNameEmploys();
            List<string> patientNames = commands.getPatientNames();
            List<littleUser> littles = commands.getDateRegisters();
            for(int i = littles.Count - 1; i >= 0; i--)
            {
                RegistersData register = new RegistersData();
                register.id = i + 1;
                register.NombreEmpleado = employNames[littles[i].id_User - 1];
                register.NombrePaciente = patientNames[littles[i].id_Patient - 1];
                register.Fecha = littles[i].date;
                registers.Add(register);
            }
            dgvRegisters.DataSource = registers;
        }

        private void btnActualize_Click(object sender, EventArgs e)
        {
            List<RegistersData> registers = new List<RegistersData>();
            List<string> employNames = commands.getNameEmploys();
            List<string> patientNames = commands.getPatientNames();
            List<littleUser> littles = commands.getDateRegisters();

            for (int i = littles.Count - 1; i >= 0; i--)
            {
                RegistersData register = new RegistersData();
                register.id = i + 1;
                register.NombreEmpleado = employNames[littles[i].id_User - 1];
                register.NombrePaciente = patientNames[littles[i].id_Patient - 1];
                register.Fecha = littles[i].date;
                registers.Add(register);
            }
            dgvRegisters.DataSource = registers;
        }
    }
}
