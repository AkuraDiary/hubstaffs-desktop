
namespace HubstafDesktop.Ui.Layout
{
    partial class TimerFragment
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
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStartTimer = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblTimerCountDown = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timerPanelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCurrentProjectName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTaskName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timerPanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartTimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartTimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartTimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStartTimer.ForeColor = System.Drawing.Color.White;
            this.btnStartTimer.Location = new System.Drawing.Point(111, 186);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnStartTimer.Size = new System.Drawing.Size(65, 65);
            this.btnStartTimer.TabIndex = 0;
            this.btnStartTimer.Text = "Start Timer";
            this.btnStartTimer.Click += new System.EventHandler(this.startTimerButton_Click);
            // 
            // lblTimerCountDown
            // 
            this.lblTimerCountDown.AutoSize = false;
            this.lblTimerCountDown.BackColor = System.Drawing.Color.Transparent;
            this.lblTimerCountDown.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerCountDown.ForeColor = System.Drawing.Color.White;
            this.lblTimerCountDown.Location = new System.Drawing.Point(3, 3);
            this.lblTimerCountDown.Name = "lblTimerCountDown";
            this.lblTimerCountDown.Size = new System.Drawing.Size(148, 40);
            this.lblTimerCountDown.TabIndex = 1;
            this.lblTimerCountDown.Text = "00:00:00";
            this.lblTimerCountDown.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerPanelContainer
            // 
            this.timerPanelContainer.BackColor = System.Drawing.Color.Transparent;
            this.timerPanelContainer.BorderRadius = 10;
            this.timerPanelContainer.Controls.Add(this.lblTimerCountDown);
            this.timerPanelContainer.FillColor = System.Drawing.Color.Black;
            this.timerPanelContainer.Location = new System.Drawing.Point(59, 14);
            this.timerPanelContainer.Name = "timerPanelContainer";
            this.timerPanelContainer.Size = new System.Drawing.Size(154, 46);
            this.timerPanelContainer.TabIndex = 2;
            // 
            // lblCurrentProjectName
            // 
            this.lblCurrentProjectName.AutoSize = false;
            this.lblCurrentProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentProjectName.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentProjectName.ForeColor = System.Drawing.Color.DimGray;
            this.lblCurrentProjectName.Location = new System.Drawing.Point(0, 86);
            this.lblCurrentProjectName.Name = "lblCurrentProjectName";
            this.lblCurrentProjectName.Size = new System.Drawing.Size(284, 36);
            this.lblCurrentProjectName.TabIndex = 3;
            this.lblCurrentProjectName.Text = "Mobile Bug Fixing";
            this.lblCurrentProjectName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = false;
            this.lblTaskName.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskName.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.ForeColor = System.Drawing.Color.Black;
            this.lblTaskName.Location = new System.Drawing.Point(0, 128);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(284, 44);
            this.lblTaskName.TabIndex = 4;
            this.lblTaskName.Text = "Fix Bug In Home Page";
            this.lblTaskName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerFragment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.lblCurrentProjectName);
            this.Controls.Add(this.timerPanelContainer);
            this.Controls.Add(this.btnStartTimer);
            this.Name = "TimerFragment";
            this.Size = new System.Drawing.Size(284, 277);
            this.Load += new System.EventHandler(this.TimerFragment_Load);
            this.timerPanelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer countdownTimer;
        private Guna.UI2.WinForms.Guna2CircleButton btnStartTimer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimerCountDown;
        private Guna.UI2.WinForms.Guna2Panel timerPanelContainer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCurrentProjectName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTaskName;
    }
}
