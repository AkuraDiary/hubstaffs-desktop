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
            this.navigationImageList = new System.Windows.Forms.ImageList(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCurrentProjectName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTaskName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // navigationImageList
            // 
            this.navigationImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navigationImageList.ImageStream")));
            this.navigationImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.navigationImageList.Images.SetKeyName(0, "edit.png");
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 2;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1239, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 29);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(308, 279);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(5, 285);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(308, 470);
            this.flowLayoutPanel3.TabIndex = 35;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(319, 92);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(970, 466);
            this.flowLayoutPanel4.TabIndex = 37;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(319, 564);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(970, 191);
            this.flowLayoutPanel5.TabIndex = 38;
            // 
            // lblCurrentProjectName
            // 
            this.lblCurrentProjectName.AutoSize = false;
            this.lblCurrentProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentProjectName.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold);
            this.lblCurrentProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurrentProjectName.Location = new System.Drawing.Point(323, 10);
            this.lblCurrentProjectName.Name = "lblCurrentProjectName";
            this.lblCurrentProjectName.Size = new System.Drawing.Size(45, 21);
            this.lblCurrentProjectName.TabIndex = 39;
            this.lblCurrentProjectName.Text = "Tasks";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = false;
            this.lblTaskName.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskName.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblTaskName.ForeColor = System.Drawing.Color.Black;
            this.lblTaskName.Location = new System.Drawing.Point(323, 30);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(96, 26);
            this.lblTaskName.TabIndex = 40;
            this.lblTaskName.Text = "Website Design";
            this.lblTaskName.Click += new System.EventHandler(this.lblTaskName_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1294, 756);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.lblCurrentProjectName);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList navigationImageList;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Ui.Layout.TimerFragment mainTimer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCurrentProjectName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTaskName;
    }
}

