namespace HubstafDesktop.Ui.Layout
{
    partial class TaskListDetailItemLayout
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
            this.taskPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblTaskDesc = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.taskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskPanel
            // 
            this.taskPanel.BackColor = System.Drawing.Color.White;
            this.taskPanel.Controls.Add(this.lblDateCreated);
            this.taskPanel.Controls.Add(this.lblTaskDesc);
            this.taskPanel.Controls.Add(this.lblTaskName);
            this.taskPanel.Location = new System.Drawing.Point(2, -2);
            this.taskPanel.Name = "taskPanel";
            this.taskPanel.Size = new System.Drawing.Size(894, 45);
            this.taskPanel.TabIndex = 14;
            this.taskPanel.Click += new System.EventHandler(this.TaskItemLayout_Click);
            this.taskPanel.MouseEnter += new System.EventHandler(this.TaskItemLayout_MouseEnter);
            this.taskPanel.MouseLeave += new System.EventHandler(this.TaskItemLayout_MouseLeave);
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblDateCreated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDateCreated.Location = new System.Drawing.Point(745, 2);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(130, 45);
            this.lblDateCreated.TabIndex = 5;
            this.lblDateCreated.Text = "12 January 2022";
            this.lblDateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDateCreated.Click += new System.EventHandler(this.TaskItemLayout_Click);
            this.lblDateCreated.MouseEnter += new System.EventHandler(this.TaskItemLayout_MouseEnter);
            this.lblDateCreated.MouseLeave += new System.EventHandler(this.TaskItemLayout_MouseLeave);
            // 
            // lblTaskDesc
            // 
            this.lblTaskDesc.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblTaskDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTaskDesc.Location = new System.Drawing.Point(335, 2);
            this.lblTaskDesc.Name = "lblTaskDesc";
            this.lblTaskDesc.Size = new System.Drawing.Size(287, 45);
            this.lblTaskDesc.TabIndex = 4;
            this.lblTaskDesc.Text = "Get owers in home more study and relax";
            this.lblTaskDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTaskDesc.Click += new System.EventHandler(this.TaskItemLayout_Click);
            this.lblTaskDesc.MouseEnter += new System.EventHandler(this.TaskItemLayout_MouseEnter);
            this.lblTaskDesc.MouseLeave += new System.EventHandler(this.TaskItemLayout_MouseLeave);
            // 
            // lblTaskName
            // 
            this.lblTaskName.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblTaskName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTaskName.Location = new System.Drawing.Point(33, 2);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(210, 45);
            this.lblTaskName.TabIndex = 3;
            this.lblTaskName.Text = "Custome Interview";
            this.lblTaskName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTaskName.Click += new System.EventHandler(this.TaskItemLayout_Click);
            this.lblTaskName.MouseEnter += new System.EventHandler(this.TaskItemLayout_MouseEnter);
            this.lblTaskName.MouseLeave += new System.EventHandler(this.TaskItemLayout_MouseLeave);
            // 
            // TaskListDetailItemLayout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.taskPanel);
            this.Name = "TaskListDetailItemLayout";
            this.Size = new System.Drawing.Size(898, 41);
            this.taskPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel taskPanel;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblTaskDesc;
        private System.Windows.Forms.Label lblTaskName;
    }
}
