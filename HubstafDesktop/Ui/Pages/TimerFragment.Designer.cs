
using System.Windows.Forms;

namespace HubstafDesktop.Ui.Pages
{
    partial class TimerFragment : UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerFragment));
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.timerPanelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTimerCountDown = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTaskName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblCurrentProjectName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnFormMode = new Guna.UI2.WinForms.Guna2Button();
            this.fuck = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPause = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnFinishNow = new Guna.UI2.WinForms.Guna2Button();
            this.btnStartTimer = new Guna.UI2.WinForms.Guna2CircleButton();
            this.timerPanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // timerPanelContainer
            // 
            this.timerPanelContainer.BackColor = System.Drawing.Color.Transparent;
            this.timerPanelContainer.BorderRadius = 10;
            this.timerPanelContainer.Controls.Add(this.lblTimerCountDown);
            this.timerPanelContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.timerPanelContainer.Location = new System.Drawing.Point(51, 42);
            this.timerPanelContainer.Name = "timerPanelContainer";
            this.timerPanelContainer.Size = new System.Drawing.Size(210, 39);
            this.timerPanelContainer.TabIndex = 2;
            // 
            // lblTimerCountDown
            // 
            this.lblTimerCountDown.AutoSize = false;
            this.lblTimerCountDown.BackColor = System.Drawing.Color.Transparent;
            this.lblTimerCountDown.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerCountDown.ForeColor = System.Drawing.Color.White;
            this.lblTimerCountDown.Location = new System.Drawing.Point(3, 0);
            this.lblTimerCountDown.Name = "lblTimerCountDown";
            this.lblTimerCountDown.Size = new System.Drawing.Size(207, 39);
            this.lblTimerCountDown.TabIndex = 6;
            this.lblTimerCountDown.Text = "00:00:00";
            this.lblTimerCountDown.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = false;
            this.lblTaskName.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskName.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblTaskName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTaskName.Location = new System.Drawing.Point(-8, 113);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(326, 33);
            this.lblTaskName.TabIndex = 4;
            this.lblTaskName.Text = null;
            this.lblTaskName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "play-128.png");
            // 
            // lblCurrentProjectName
            // 
            this.lblCurrentProjectName.AutoSize = false;
            this.lblCurrentProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentProjectName.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.lblCurrentProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurrentProjectName.Location = new System.Drawing.Point(-8, 87);
            this.lblCurrentProjectName.Name = "lblCurrentProjectName";
            this.lblCurrentProjectName.Size = new System.Drawing.Size(326, 36);
            this.lblCurrentProjectName.TabIndex = 7;
            this.lblCurrentProjectName.Text = null;
            this.lblCurrentProjectName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFormMode
            // 
            this.btnFormMode.BorderColor = System.Drawing.Color.Bisque;
            this.btnFormMode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFormMode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFormMode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFormMode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFormMode.FillColor = System.Drawing.Color.Empty;
            this.btnFormMode.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnFormMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFormMode.Location = new System.Drawing.Point(288, 246);
            this.btnFormMode.Name = "btnFormMode";
            this.btnFormMode.Size = new System.Drawing.Size(30, 25);
            this.btnFormMode.TabIndex = 47;
            this.btnFormMode.Text = "=";
            this.btnFormMode.Click += new System.EventHandler(this.btnFormMode_Click);
            // 
            // fuck
            // 
            this.fuck.BackColor = System.Drawing.Color.DimGray;
            this.fuck.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fuck.Location = new System.Drawing.Point(51, 179);
            this.fuck.Name = "fuck";
            this.fuck.Size = new System.Drawing.Size(210, 2);
            this.fuck.TabIndex = 48;
            // 
            // btnPause
            // 
            this.btnPause.BorderThickness = 1;
            this.btnPause.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPause.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPause.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPause.FillColor = System.Drawing.Color.Transparent;
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPause.ForeColor = System.Drawing.Color.Black;
            this.btnPause.Location = new System.Drawing.Point(126, 152);
            this.btnPause.Name = "btnPause";
            this.btnPause.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPause.Size = new System.Drawing.Size(60, 60);
            this.btnPause.TabIndex = 49;
            this.btnPause.Text = "||";
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnFinishNow
            // 
            this.btnFinishNow.BorderRadius = 5;
            this.btnFinishNow.BorderThickness = 1;
            this.btnFinishNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinishNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinishNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinishNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinishNow.FillColor = System.Drawing.Color.Transparent;
            this.btnFinishNow.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishNow.ForeColor = System.Drawing.Color.Black;
            this.btnFinishNow.Location = new System.Drawing.Point(6, 236);
            this.btnFinishNow.Name = "btnFinishNow";
            this.btnFinishNow.Size = new System.Drawing.Size(93, 27);
            this.btnFinishNow.TabIndex = 50;
            this.btnFinishNow.Text = "Finish Now";
            this.btnFinishNow.Visible = false;
            this.btnFinishNow.Click += new System.EventHandler(this.btnFinishNow_Click);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStartTimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartTimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartTimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartTimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartTimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnStartTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStartTimer.ForeColor = System.Drawing.Color.White;
            this.btnStartTimer.Image = ((System.Drawing.Image)(resources.GetObject("btnStartTimer.Image")));
            this.btnStartTimer.Location = new System.Drawing.Point(126, 152);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnStartTimer.Size = new System.Drawing.Size(60, 60);
            this.btnStartTimer.TabIndex = 6;
            this.btnStartTimer.Click += new System.EventHandler(this.startTimerButton_Click);
            // 
            // TimerFragment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnFinishNow);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnFormMode);
            this.Controls.Add(this.lblCurrentProjectName);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.fuck);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.timerPanelContainer);
            this.Name = "TimerFragment";
            this.Size = new System.Drawing.Size(332, 274);
            this.timerPanelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer countdownTimer;
        private Guna.UI2.WinForms.Guna2Panel timerPanelContainer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTaskName;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2CircleButton btnStartTimer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCurrentProjectName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimerCountDown;
        private Guna.UI2.WinForms.Guna2Button btnFormMode;
        private Guna.UI2.WinForms.Guna2Panel fuck;
        private Guna.UI2.WinForms.Guna2CircleButton btnPause;
        private Guna.UI2.WinForms.Guna2Button btnFinishNow;
    }
}
