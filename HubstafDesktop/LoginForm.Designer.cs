
namespace HubstafDesktop
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.edtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.formLoginPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.edtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.formLoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtUsername
            // 
            this.edtUsername.BackColor = System.Drawing.Color.Transparent;
            this.edtUsername.BorderRadius = 10;
            this.edtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtUsername.DefaultText = "";
            this.edtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.edtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.edtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.edtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.edtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.edtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.edtUsername.Location = new System.Drawing.Point(128, 220);
            this.edtUsername.Name = "edtUsername";
            this.edtUsername.PasswordChar = '\0';
            this.edtUsername.PlaceholderText = "";
            this.edtUsername.SelectedText = "";
            this.edtUsername.Size = new System.Drawing.Size(200, 36);
            this.edtUsername.TabIndex = 0;
            this.edtUsername.TextChanged += new System.EventHandler(this.edtUsername_TextChanged);
            // 
            // formLoginPanel
            // 
            this.formLoginPanel.BackColor = System.Drawing.Color.White;
            this.formLoginPanel.Controls.Add(this.btnLogin);
            this.formLoginPanel.Controls.Add(this.edtPassword);
            this.formLoginPanel.Controls.Add(this.edtUsername);
            this.formLoginPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.formLoginPanel.Location = new System.Drawing.Point(388, 0);
            this.formLoginPanel.Name = "formLoginPanel";
            this.formLoginPanel.Size = new System.Drawing.Size(412, 450);
            this.formLoginPanel.TabIndex = 1;
            // 
            // edtPassword
            // 
            this.edtPassword.BackColor = System.Drawing.Color.Transparent;
            this.edtPassword.BorderRadius = 10;
            this.edtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPassword.DefaultText = "";
            this.edtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.edtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.edtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.edtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.edtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.edtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.edtPassword.Location = new System.Drawing.Point(128, 276);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.PasswordChar = '\0';
            this.edtPassword.PlaceholderText = "";
            this.edtPassword.SelectedText = "";
            this.edtPassword.Size = new System.Drawing.Size(200, 36);
            this.edtPassword.TabIndex = 2;
            this.edtPassword.TextChanged += new System.EventHandler(this.edtPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(128, 361);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 45);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formLoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.formLoginPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox edtUsername;
        private Guna.UI2.WinForms.Guna2Panel formLoginPanel;
        private Guna.UI2.WinForms.Guna2TextBox edtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
    }
}