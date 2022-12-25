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
            this.projectTaskDetailFragmentCOntainer = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel23 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTaskName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnMinimze = new Guna.UI2.WinForms.Guna2Button();
            this.lblCurrentProjectName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSelectedTaskName = new System.Windows.Forms.Label();
            this.taskDescriptionPanelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSelectedTaskDesc = new System.Windows.Forms.Label();
            this.mainTimerFragmentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.projectListFragmentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnFormMode = new Guna.UI2.WinForms.Guna2Button();
            this.mainTimer = new HubstafDesktop.Ui.Pages.TimerFragment();
            this.taskFragment = new HubstafDesktop.Ui.Pages.TaskFragment();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalTimeSpent = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            // projectTaskDetailFragmentCOntainer
            // 
            this.projectTaskDetailFragmentCOntainer.BackColor = System.Drawing.Color.White;
            this.projectTaskDetailFragmentCOntainer.Controls.Add(this.taskFragment);
            this.projectTaskDetailFragmentCOntainer.Controls.Add(this.guna2Panel23);
            resources.ApplyResources(this.projectTaskDetailFragmentCOntainer, "projectTaskDetailFragmentCOntainer");
            this.projectTaskDetailFragmentCOntainer.Name = "projectTaskDetailFragmentCOntainer";
            // 
            // guna2Panel23
            // 
            this.guna2Panel23.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.guna2Panel23, "guna2Panel23");
            this.guna2Panel23.Name = "guna2Panel23";
            // 
            // lblTaskName
            // 
            resources.ApplyResources(this.lblTaskName, "lblTaskName");
            this.lblTaskName.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskName.ForeColor = System.Drawing.Color.Black;
            this.lblTaskName.Name = "lblTaskName";
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
            // lblCurrentProjectName
            // 
            resources.ApplyResources(this.lblCurrentProjectName, "lblCurrentProjectName");
            this.lblCurrentProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurrentProjectName.Name = "lblCurrentProjectName";
            // 
            // lblSelectedTaskName
            // 
            resources.ApplyResources(this.lblSelectedTaskName, "lblSelectedTaskName");
            this.lblSelectedTaskName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSelectedTaskName.Name = "lblSelectedTaskName";
            // 
            // taskDescriptionPanelContainer
            // 
            this.taskDescriptionPanelContainer.BackColor = System.Drawing.Color.White;
            this.taskDescriptionPanelContainer.Controls.Add(this.lblSelectedTaskDesc);
            this.taskDescriptionPanelContainer.Controls.Add(this.lblSelectedTaskName);
            resources.ApplyResources(this.taskDescriptionPanelContainer, "taskDescriptionPanelContainer");
            this.taskDescriptionPanelContainer.Name = "taskDescriptionPanelContainer";
            // 
            // lblSelectedTaskDesc
            // 
            resources.ApplyResources(this.lblSelectedTaskDesc, "lblSelectedTaskDesc");
            this.lblSelectedTaskDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSelectedTaskDesc.Name = "lblSelectedTaskDesc";
            // 
            // mainTimerFragmentContainer
            // 
            this.mainTimerFragmentContainer.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.mainTimerFragmentContainer, "mainTimerFragmentContainer");
            this.mainTimerFragmentContainer.Name = "mainTimerFragmentContainer";
            // 
            // projectListFragmentContainer
            // 
            resources.ApplyResources(this.projectListFragmentContainer, "projectListFragmentContainer");
            this.projectListFragmentContainer.BackColor = System.Drawing.Color.White;
            this.projectListFragmentContainer.Name = "projectListFragmentContainer";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.guna2Panel1, "guna2Panel1");
            this.guna2Panel1.Name = "guna2Panel1";
            // 
            // btnFormMode
            // 
            this.btnFormMode.BorderColor = System.Drawing.Color.Bisque;
            this.btnFormMode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFormMode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFormMode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFormMode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFormMode.FillColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnFormMode, "btnFormMode");
            this.btnFormMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFormMode.Name = "btnFormMode";
            this.btnFormMode.Click += new System.EventHandler(this.btnFormMode_Click);
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
            // taskFragment
            // 
            this.taskFragment.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.taskFragment, "taskFragment");
            this.taskFragment.Name = "taskFragment";
            this.taskFragment.Load += new System.EventHandler(this.taskFragment_Load);
            // 
            // guna2HtmlLabel1
            // 
            resources.ApplyResources(this.guna2HtmlLabel1, "guna2HtmlLabel1");
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            // 
            // lblTotalTimeSpent
            // 
            resources.ApplyResources(this.lblTotalTimeSpent, "lblTotalTimeSpent");
            this.lblTotalTimeSpent.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTimeSpent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalTimeSpent.Name = "lblTotalTimeSpent";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lblTotalTimeSpent);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.mainTimer);
            this.Controls.Add(this.btnFormMode);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.projectListFragmentContainer);
            this.Controls.Add(this.btnMinimze);
            this.Controls.Add(this.taskDescriptionPanelContainer);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.lblCurrentProjectName);
            this.Controls.Add(this.projectTaskDetailFragmentCOntainer);
            this.Controls.Add(this.mainTimerFragmentContainer);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.projectTaskDetailFragmentCOntainer.ResumeLayout(false);
            this.taskDescriptionPanelContainer.ResumeLayout(false);
            this.taskDescriptionPanelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList navigationImageList;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.FlowLayoutPanel projectTaskDetailFragmentCOntainer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTaskName;
        private Ui.Pages.TaskFragment taskFragment;
        private Guna.UI2.WinForms.Guna2Button btnMinimze;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCurrentProjectName;
        private Guna.UI2.WinForms.Guna2Panel taskDescriptionPanelContainer;
        private System.Windows.Forms.Label lblSelectedTaskName;
        private System.Windows.Forms.FlowLayoutPanel mainTimerFragmentContainer;
        private System.Windows.Forms.FlowLayoutPanel projectListFragmentContainer;
        private Ui.Pages.TimerFragment mainTimer;
        private System.Windows.Forms.Label lblSelectedTaskDesc;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel23;
        private Guna.UI2.WinForms.Guna2Button btnFormMode;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalTimeSpent;
    }
}

