
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
            this.lblCurrentProjectName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTaskName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.timerPanelContainer.FillColor = System.Drawing.Color.Black;
            this.timerPanelContainer.Location = new System.Drawing.Point(80, 29);
            this.timerPanelContainer.Name = "timerPanelContainer";
            this.timerPanelContainer.Size = new System.Drawing.Size(143, 39);
            this.timerPanelContainer.TabIndex = 2;
            // 
            // lblTimerCountDown
            // 
            this.lblTimerCountDown.AutoSize = false;
            this.lblTimerCountDown.BackColor = System.Drawing.Color.Transparent;
            this.lblTimerCountDown.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lblTimerCountDown.ForeColor = System.Drawing.Color.White;
            this.lblTimerCountDown.Location = new System.Drawing.Point(-3, -1);
            this.lblTimerCountDown.Name = "lblTimerCountDown";
            this.lblTimerCountDown.Size = new System.Drawing.Size(148, 40);
            this.lblTimerCountDown.TabIndex = 3;
            this.lblTimerCountDown.Text = "00:00:00";
            this.lblTimerCountDown.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentProjectName
            // 
            this.lblCurrentProjectName.AutoSize = false;
            this.lblCurrentProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentProjectName.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.lblCurrentProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurrentProjectName.Location = new System.Drawing.Point(12, 101);
            this.lblCurrentProjectName.Name = "lblCurrentProjectName";
            this.lblCurrentProjectName.Size = new System.Drawing.Size(284, 36);
            this.lblCurrentProjectName.TabIndex = 3;
            this.lblCurrentProjectName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = false;
            this.lblTaskName.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskName.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblTaskName.ForeColor = System.Drawing.Color.Black;
            this.lblTaskName.Location = new System.Drawing.Point(12, 130);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(284, 33);
            this.lblTaskName.TabIndex = 4;
            this.lblTaskName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "play-128.png");
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStartTimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartTimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartTimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartTimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStartTimer.ForeColor = System.Drawing.Color.White;
            this.btnStartTimer.Image = ((System.Drawing.Image)(resources.GetObject("btnStartTimer.Image")));
            this.btnStartTimer.Location = new System.Drawing.Point(120, 169);
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
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.lblCurrentProjectName);
            this.Controls.Add(this.timerPanelContainer);
            this.Name = "TimerFragment";
            this.Size = new System.Drawing.Size(308, 279);
            this.Load += new System.EventHandler(this.TimerFragment_Load);
            this.timerPanelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer countdownTimer;
        private Guna.UI2.WinForms.Guna2Panel timerPanelContainer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCurrentProjectName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTaskName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimerCountDown;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2CircleButton btnStartTimer;
    }
}
