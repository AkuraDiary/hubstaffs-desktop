﻿using System;
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
            //TODO DO Login Here
        }

        private void edtPassword_TextChanged(object sender, EventArgs e)
        {
          //  this.password = edtPassword.Text;
        }

        private void edtUsername_TextChanged(object sender, EventArgs e)
        {
         //   this.password = edtUsername.Text;
        }

        void moveToHomePage()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        //private bool validateLoginForm()
        //{
        //    //if (string.IsNullOrEmpty(edtUsername.Text))
        //    //{
        //    //    return false;
        //    //}else if (string.IsNullOrEmpty(edtUsername.Text))
        //    //{
        //    //    return false;
        //    //}
        //    //else
        //    //{
        //    //    return true;
        //    //}
        //}
    }
}
