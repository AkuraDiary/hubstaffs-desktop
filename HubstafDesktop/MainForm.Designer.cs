namespace HubstafDesktop
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.mainLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblnavUsername = new System.Windows.Forms.Label();
            this.guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.navDashboard = new System.Windows.Forms.TabPage();
            this.navTask = new System.Windows.Forms.TabPage();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.whiteTopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.navigationImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.whiteTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 20;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1023, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 44);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mainLogo
            // 
            this.mainLogo.Image = ((System.Drawing.Image)(resources.GetObject("mainLogo.Image")));
            this.mainLogo.ImageRotate = 0F;
            this.mainLogo.Location = new System.Drawing.Point(-2, 0);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(177, 56);
            this.mainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainLogo.TabIndex = 0;
            this.mainLogo.TabStop = false;
            // 
            // lblnavUsername
            // 
            this.lblnavUsername.AutoSize = true;
            this.lblnavUsername.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.lblnavUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.lblnavUsername.Location = new System.Drawing.Point(66, 9);
            this.lblnavUsername.Name = "lblnavUsername";
            this.lblnavUsername.Size = new System.Drawing.Size(89, 25);
            this.lblnavUsername.TabIndex = 23;
            this.lblnavUsername.Text = "Mr Andrew";
            // 
            // guna2PictureBox7
            // 
            this.guna2PictureBox7.BorderRadius = 20;
            this.guna2PictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox7.Image")));
            this.guna2PictureBox7.ImageRotate = 0F;
            this.guna2PictureBox7.Location = new System.Drawing.Point(20, 4);
            this.guna2PictureBox7.Name = "guna2PictureBox7";
            this.guna2PictureBox7.Size = new System.Drawing.Size(40, 40);
            this.guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox7.TabIndex = 24;
            this.guna2PictureBox7.TabStop = false;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mainTabControl.Controls.Add(this.navDashboard);
            this.mainTabControl.Controls.Add(this.navTask);
            this.mainTabControl.ImageList = this.navigationImageList;
            this.mainTabControl.ItemSize = new System.Drawing.Size(180, 40);
            this.mainTabControl.Location = new System.Drawing.Point(-2, 50);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1301, 708);
            this.mainTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.mainTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.mainTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.mainTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.mainTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.mainTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.mainTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.mainTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.mainTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.mainTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.mainTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.mainTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.mainTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.mainTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.mainTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.mainTabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.mainTabControl.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mainTabControl.TabIndex = 30;
            this.mainTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            // 
            // navDashboard
            // 
            this.navDashboard.Location = new System.Drawing.Point(184, 4);
            this.navDashboard.Name = "navDashboard";
            this.navDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.navDashboard.Size = new System.Drawing.Size(1113, 700);
            this.navDashboard.TabIndex = 0;
            this.navDashboard.Text = "Dashboard";
            this.navDashboard.UseVisualStyleBackColor = true;
            // 
            // navTask
            // 
            this.navTask.Location = new System.Drawing.Point(184, 4);
            this.navTask.Name = "navTask";
            this.navTask.Padding = new System.Windows.Forms.Padding(3);
            this.navTask.Size = new System.Drawing.Size(1113, 700);
            this.navTask.TabIndex = 1;
            this.navTask.Text = "Task";
            this.navTask.UseVisualStyleBackColor = true;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Controls.Add(this.whiteTopPanel);
            this.guna2CustomGradientPanel1.Controls.Add(this.mainLogo);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1294, 56);
            this.guna2CustomGradientPanel1.TabIndex = 31;
            // 
            // whiteTopPanel
            // 
            this.whiteTopPanel.BackColor = System.Drawing.Color.White;
            this.whiteTopPanel.Controls.Add(this.lblnavUsername);
            this.whiteTopPanel.Controls.Add(this.btnExit);
            this.whiteTopPanel.Controls.Add(this.guna2PictureBox7);
            this.whiteTopPanel.Location = new System.Drawing.Point(181, 0);
            this.whiteTopPanel.Name = "whiteTopPanel";
            this.whiteTopPanel.Size = new System.Drawing.Size(1118, 56);
            this.whiteTopPanel.TabIndex = 2;
            // 
            // navigationImageList
            // 
            this.navigationImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navigationImageList.ImageStream")));
            this.navigationImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.navigationImageList.Images.SetKeyName(0, "edit.png");
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1294, 756);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a";
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.whiteTopPanel.ResumeLayout(false);
            this.whiteTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox7;
        private System.Windows.Forms.Label lblnavUsername;
        private Guna.UI2.WinForms.Guna2PictureBox mainLogo;
        private Guna.UI2.WinForms.Guna2TabControl mainTabControl;
        private System.Windows.Forms.TabPage navDashboard;
        private System.Windows.Forms.TabPage navTask;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel whiteTopPanel;
        private System.Windows.Forms.ImageList navigationImageList;
    }
}

