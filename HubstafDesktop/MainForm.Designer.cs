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
            this.taskFragment = new HubstafDesktop.Ui.Pages.TaskFragment();
            this.guna2Panel23 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTaskName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnMinimze = new Guna.UI2.WinForms.Guna2Button();
            this.lblCurrentProjectName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSelectedTaskName = new System.Windows.Forms.Label();
            this.taskDescriptionPanelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSelectedTaskStatus = new System.Windows.Forms.Label();
            this.lblSelectedTaskDesc = new System.Windows.Forms.Label();
            this.mainTimerFragmentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.mainTimer = new HubstafDesktop.Ui.Pages.TimerFragment();
            this.projectListFragmentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnFormMode = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalTimeSpent = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCurrentUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLastUpdated = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.projectTaskDetailFragmentCOntainer.SuspendLayout();
            this.taskDescriptionPanelContainer.SuspendLayout();
            this.mainTimerFragmentContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
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
            // taskFragment
            // 
            this.taskFragment.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.taskFragment, "taskFragment");
            this.taskFragment.Name = "taskFragment";
            this.taskFragment.ShowDone = false;
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
            this.taskDescriptionPanelContainer.Controls.Add(this.lblSelectedTaskStatus);
            this.taskDescriptionPanelContainer.Controls.Add(this.lblSelectedTaskDesc);
            this.taskDescriptionPanelContainer.Controls.Add(this.lblSelectedTaskName);
            resources.ApplyResources(this.taskDescriptionPanelContainer, "taskDescriptionPanelContainer");
            this.taskDescriptionPanelContainer.Name = "taskDescriptionPanelContainer";
            // 
            // lblSelectedTaskStatus
            // 
            resources.ApplyResources(this.lblSelectedTaskStatus, "lblSelectedTaskStatus");
            this.lblSelectedTaskStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSelectedTaskStatus.Name = "lblSelectedTaskStatus";
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
            // lblCurrentUser
            // 
            resources.ApplyResources(this.lblCurrentUser, "lblCurrentUser");
            this.lblCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurrentUser.Name = "lblCurrentUser";
            // 
            // lblLastUpdated
            // 
            resources.ApplyResources(this.lblLastUpdated, "lblLastUpdated");
            this.lblLastUpdated.BackColor = System.Drawing.Color.Transparent;
            this.lblLastUpdated.ForeColor = System.Drawing.Color.Black;
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogo.BackgroundImage = global::HubstafDesktop.Properties.Resources.Group_1;
            this.picBoxLogo.FillColor = System.Drawing.Color.Transparent;
            this.picBoxLogo.Image = global::HubstafDesktop.Properties.Resources.logo_login;
            this.picBoxLogo.ImageRotate = 0F;
            resources.ApplyResources(this.picBoxLogo, "picBoxLogo");
            this.picBoxLogo.InitialImage = global::HubstafDesktop.Properties.Resources.Group_1;
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderColor = System.Drawing.Color.Bisque;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefresh.Image = global::HubstafDesktop.Properties.Resources.icons8_refresh_500px;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.lblLastUpdated);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.lblTotalTimeSpent);
            this.Controls.Add(this.guna2HtmlLabel1);
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
            this.mainTimerFragmentContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
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
        private System.Windows.Forms.Label lblSelectedTaskDesc;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel23;
        private Guna.UI2.WinForms.Guna2Button btnFormMode;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalTimeSpent;
        private System.Windows.Forms.Label lblSelectedTaskStatus;
        private Ui.Pages.TimerFragment mainTimer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCurrentUser;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLastUpdated;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxLogo;
    }
}

