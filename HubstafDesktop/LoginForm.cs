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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validateLoginForm())
            {
                //todo do login here
                moveToHomePage();
            }
        }

        private void edtPassword_TextChanged(object sender, EventArgs e)
        {
          this.password = edtPassword.Text;
        }

        private void edtUsername_TextChanged(object sender, EventArgs e)
        {
         this.password = edtUsername.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

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
    }
}
