using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HubstafDesktop
{
    public partial class LoginForm : Form
    {

        private string username, password;
        public LoginForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validateLoginForm())
            {
                //todo do login here
                moveToHomePage();
            }
        }

        #region form validation and data region
        private void edtPassword_TextChanged(object sender, EventArgs e)
        {
          this.password = edtPassword.Text;
        }

        private void edtUsername_TextChanged(object sender, EventArgs e)
        {
         this.password = edtUsername.Text;
        }
        private bool validateLoginForm()
        {
            if (string.IsNullOrEmpty(edtUsername.Text))
            {
                MessageBox.Show("Username Can't be empty");
                return false;
            }
            else if (string.IsNullOrEmpty(edtPassword.Text))
            {
                MessageBox.Show("Password Can't be empty");
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        void moveToHomePage()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        


        #region formSetting

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion
    }
}
