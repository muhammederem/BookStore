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
using BLL;

namespace BookStore
{
   
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tckn = tbLoginTCKN.Text;
            string password = tbLoginPassword.Text;

            if (tckn == "")
            {

                MessageBox.Show("Please enter TCKN.");
                tbLoginTCKN.Focus();
                return;
            }

            if (password == string.Empty)
            {
                MessageBox.Show("Please enter Password.");
                tbLoginPassword.Focus();
                return;
            }
             


            

            Kullanıcı s = new Kullanıcı();
            int result = s.Login(tckn, password);

            if (result == 1)
            {
                KullanıcıArayüz giris = new KullanıcıArayüz();
                this.Hide();
                MessageBox.Show("Başarılı giriş.");
                giris.Show();
                
                
                
            }
            else
            {
                MessageBox.Show("Başarısız giriş.");
            }
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TbLoginTCKN_Enter(object sender, EventArgs e)
        {
            if (tbLoginTCKN.Text == "TCKN")
            {
                tbLoginTCKN.Text = "";
                tbLoginTCKN.ForeColor = Color.White;

            }
        }

        private void TbLoginPassword_Enter(object sender, EventArgs e)
        {
            if (tbLoginPassword.Text == "Password")
            {
                tbLoginPassword.Text = "";
                tbLoginPassword.ForeColor = Color.White;
                tbLoginPassword.UseSystemPasswordChar = true;

            }
        }

        private void TbLoginTCKN_Leave(object sender, EventArgs e)
        {
            if (tbLoginTCKN.Text == "")
            {
                tbLoginTCKN.Text = "TCKN";
            }
        }

        private void TbLoginPassword_Leave(object sender, EventArgs e)
        {
            if (tbLoginPassword.Text == "")
            {
                tbLoginPassword.UseSystemPasswordChar = false;
                tbLoginPassword.Text = "Password";
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void PanelUpper_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


    }
}
    
