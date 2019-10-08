using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace BookStore
{
    public partial class KullanıcıArayüz : Form
    {
        public KullanıcıArayüz()
        {
            
            InitializeComponent();
            mainPage1.Hide();
            kullanıcıUserC1.Hide();
            dergiUserC1.Hide();
            ımportUC1.Hide();

        }

        private void KullanıcıArayüz_Load(object sender, EventArgs e)
        {

        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btn_Main.Height;
            panelLeft.Top = btn_Main.Top;
            girisUC1.Show();
            girisUC1.BringToFront();

            //Hide other usercontorls
            mainPage1.Hide();
            kullanıcıUserC1.Hide();
            dergiUserC1.Hide();
            ımportUC1.Hide();

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnBook.Height;
            panelLeft.Top = btnBook.Top;
            mainPage1.Show();
            mainPage1.BringToFront();


            //Hide Other UserControls
            kullanıcıUserC1.Hide();
            dergiUserC1.Hide();
            girisUC1.Hide();
            ımportUC1.Hide();

        }

        private void btnKullanıcı_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnKullanıcı.Height;
            panelLeft.Top = btnKullanıcı.Top;
            kullanıcıUserC1.Show();
            kullanıcıUserC1.BringToFront();

            // Hide Other User Controls
            mainPage1.Hide();
            dergiUserC1.Hide();
            girisUC1.Hide();
            ımportUC1.Hide();

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnSell.Height;
            panelLeft.Top = btnSell.Top;

            dergiUserC1.Show();
            dergiUserC1.BringToFront();
            //Hide Other User Controls
            mainPage1.Hide();
            kullanıcıUserC1.Hide();
            girisUC1.Hide();
            ımportUC1.Hide();


        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnAbout.Height;
            panelLeft.Top = btnAbout.Top;
            ımportUC1.Show();
            ımportUC1.BringToFront();

            //////Hide Other User Controls
            mainPage1.Hide();
            kullanıcıUserC1.Hide();
            dergiUserC1.Hide();
            girisUC1.Hide();



        }
    }
}
