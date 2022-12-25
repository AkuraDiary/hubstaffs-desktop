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
            this.mainTimerFragmentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.mainTimer = new HubstafDesktop.Ui.Pages.TimerFragment();
            this.projectListFragmentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.projectTaskDetailFragmentCOntainer = new System.Windows.Forms.FlowLayoutPanel();
            this.taskFragment = new HubstafDesktop.Ui.Pages.TaskFragment();
            this.lblCurrentProjectName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTaskName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.taskDescriptionPanelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSelectedTaskDesc = new System.Windows.Forms.Label();
            this.lblSelectedTaskName = new System.Windows.Forms.Label();
            this.btnMinimze = new Guna.UI2.WinForms.Guna2Button();
            this.mainTimerFragmentContainer.SuspendLayout();
            this.projectTaskDetailFragmentCOntainer.SuspendLayout();
            this.taskDescriptionPanelContainer.SuspendLayout();
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
            this.btnExit.BorderRadius = 4;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.Crimson;
            this.btnExit.Name = "btnExit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mainTimerFragmentContainer
            // 
            this.mainTimerFragmentContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainTimerFragmentContainer.Controls.Add(this.mainTimer);
            resources.ApplyResources(this.mainTimerFragmentContainer, "mainTimerFragmentContainer");
            this.mainTimerFragmentContainer.Name = "mainTimerFragmentContainer";
            // 
            // mainTimer
            // 
            this.mainTimer.BackColor = System.Drawing.Color.White;
            this.mainTimer.ChoosedTask = null;
            resources.ApplyResources(this.mainTimer, "mainTimer");
            this.mainTimer.Name = "mainTimer";
            this.mainTimer.ProjectName = "";
            this.mainTimer.TimerCountdownValue = 0;
            // 
            // projectListFragmentContainer
            // 
            resources.ApplyResources(this.projectListFragmentContainer, "projectListFragmentContainer");
            this.projectListFragmentContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.projectListFragmentContainer.Name = "projectListFragmentContainer";
            // 
            // projectTaskDetailFragmentCOntainer
            // 
            this.projectTaskDetailFragmentCOntainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.projectTaskDetailFragmentCOntainer.Controls.Add(this.taskFragment);
            resources.ApplyResources(this.projectTaskDetailFragmentCOntainer, "projectTaskDetailFragmentCOntainer");
            this.projectTaskDetailFragmentCOntainer.Name = "projectTaskDetailFragmentCOntainer";
            // 
            // taskFragment
            // 
            resources.ApplyResources(this.taskFragment, "taskFragment");
            this.taskFragment.Name = "taskFragment";
            // 
            // lblCurrentProjectName
            // 
            resources.ApplyResources(this.lblCurrentProjectName, "lblCurrentProjectName");
            this.lblCurrentProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurrentProjectName.Name = "lblCurrentProjectName";
            // 
            // lblTaskName
            // 
            resources.ApplyResources(this.lblTaskName, "lblTaskName");
            this.lblTaskName.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskName.ForeColor = System.Drawing.Color.Black;
            this.lblTaskName.Name = "lblTaskName";
            // 
            // taskDescriptionPanelContainer
            // 
            this.taskDescriptionPanelContainer.Controls.Add(this.lblSelectedTaskDesc);
            this.taskDescriptionPanelContainer.Controls.Add(this.lblSelectedTaskName);
            resources.ApplyResources(this.taskDescriptionPanelContainer, "taskDescriptionPanelContainer");
            this.taskDescriptionPanelContainer.Name = "taskDescriptionPanelContainer";
            // 
            // lblSelectedTaskDesc
            // 
            resources.ApplyResources(this.lblSelectedTaskDesc, "lblSelectedTaskDesc");
            this.lblSelectedTaskDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelectedTaskDesc.Name = "lblSelectedTaskDesc";
            // 
            // lblSelectedTaskName
            // 
            resources.ApplyResources(this.lblSelectedTaskName, "lblSelectedTaskName");
            this.lblSelectedTaskName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelectedTaskName.Name = "lblSelectedTaskName";
            // 
            // btnMinimze
            // 
            this.btnMinimze.BorderRadius = 4;
            this.btnMinimze.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimze.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimze.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimze.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimze.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnMinimze, "btnMinimze");
            this.btnMinimze.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(91)))), ((int)(((byte)(191)))));
            this.btnMinimze.Name = "btnMinimze";
            this.btnMinimze.Click += new System.EventHandler(this.btnMinimze_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnMinimze);
            this.Controls.Add(this.taskDescriptionPanelContainer);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.lblCurrentProjectName);
            this.Controls.Add(this.projectTaskDetailFragmentCOntainer);
            this.Controls.Add(this.projectListFragmentContainer);
            this.Controls.Add(this.mainTimerFragmentContainer);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.mainTimerFragmentContainer.ResumeLayout(false);
            this.projectTaskDetailFragmentCOntainer.ResumeLayout(false);
            this.taskDescriptionPanelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList navigationImageList;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        
        private System.Windows.Forms.FlowLayoutPanel mainTimerFragmentContainer;
        private System.Windows.Forms.FlowLayoutPanel projectListFragmentContainer;
        private System.Windows.Forms.FlowLayoutPanel projectTaskDetailFragmentCOntainer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCurrentProjectName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTaskName;
        private Ui.Pages.TimerFragment mainTimer;
        private Guna.UI2.WinForms.Guna2Panel taskDescriptionPanelContainer;
        private Ui.Pages.TaskFragment taskFragment;
        private System.Windows.Forms.Label lblSelectedTaskName;
        private System.Windows.Forms.Label lblSelectedTaskDesc;
        private Guna.UI2.WinForms.Guna2Button btnMinimze;
    }
}

