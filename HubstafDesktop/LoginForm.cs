using HubstafDesktop.Data;
using HubstafDesktop.Data.Remote;
using HubstafDesktop.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HubstafDesktop
{
    public partial class LoginForm : Form
    {

        
        public LoginForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (validateLoginForm())
            {

                //todo do login here
                btnLogin.Enabled =  false;
                //MessageBox.Show("Loging In Please Wait");
                await Task.Run(() => Repository.doLoginUser(edtUsername.Text, edtPassword.Text));

                btnLogin.Enabled = true;


                if (Repository.loggedInUser != null)
                {
                    Debug.WriteLine("user login response : " + Repository.loggedInUser.Name);
                    MessageBox.Show(" Login Success! ");
                    moveToHomePage();
                }

            }
        }

    

        #region form validation and data region
 
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

        public void moveToHomePage()
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
