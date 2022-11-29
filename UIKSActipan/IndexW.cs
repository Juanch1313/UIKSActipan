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
using UIKSActipan.mySQL;
using UIKSActipan.Functions;

namespace UIKSActipan
{
    public partial class IndexW : Form
    {
        private string[] frases =
{
            "No basta levantar al débil, hay que sostenerlo después. / William Shakespeare.",
            "Ayudar a otro es un privilegio, agradece la oportunidad de poder hacerlo. / Chamalú.",
            "Aquellos que tienen el privilegio de saber tienen la obligación de actuar. / Albert Einstein.",
            "¿Cuál es la esencia de la vida? Servir a otros y hacer el bien. / Aristoteles.",
            "Nosotros tenemos que ser el cambio que queremos ver en el mundo. / Gandhi.",
            "Si ayudo a una sola persona a tener esperanza, no habré vivido en vano. / Martin Luther King.",
            "Pues hemos nacido para colaborar, al igual que los pies, las manos, los párpados, " +
                "\n las hileras de dientes, superiores e inferiores. Obrar, pues, como adversarios los unos " +
                "\n de los otros es contrario a la naturaleza. / Marco Aurelio."
        };
        private SearchE searchE = new SearchE();
        private SearchP searchP = new SearchP();
        private RegisterP registerP = new RegisterP();
        private SeeRegisters seeRegisters = new SeeRegisters();
        private User user = commands.getUser();
        public IndexW()
        {
            InitializeComponent();
            lbMensaje.Text = frases[randomNumber()];
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
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchE_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchE.ShowDialog();
            this.Show();
        }

        private void btnRegisterP_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerP.ShowDialog();
            this.Show();
        }

        private void btnSearchP_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchP.ShowDialog();
            this.Show();
        }

        private int randomNumber()
        {

            Random random = new Random();
            return random.Next(0, frases.Length);
        }

        private void IndexW_Load(object sender, EventArgs e)
        {
            lbBienvenido.Text = "Bienvenido " + user.firstName;
        }

        private void btnregisters_Click(object sender, EventArgs e)
        {
            this.Hide();
            seeRegisters.ShowDialog();
            this.Show();
        }
    }
}
