
namespace HubstafDesktop.Ui.Pages
{
    partial class TaskFragment
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
            this.detailedTaskListContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblTaskDesc = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.guna2Panel23 = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // detailedTaskListContainer
            // 
            this.detailedTaskListContainer.AutoScroll = true;
            this.detailedTaskListContainer.BackColor = System.Drawing.Color.White;
            this.detailedTaskListContainer.Location = new System.Drawing.Point(3, 64);
            this.detailedTaskListContainer.Name = "detailedTaskListContainer";
            this.detailedTaskListContainer.Size = new System.Drawing.Size(936, 429);
            this.detailedTaskListContainer.TabIndex = 0;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblDateCreated.ForeColor = System.Drawing.Color.Silver;
            this.lblDateCreated.Location = new System.Drawing.Point(740, 16);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(144, 45);
            this.lblDateCreated.TabIndex = 8;
            this.lblDateCreated.Text = "DATE CREATED";
            this.lblDateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaskDesc
            // 
            this.lblTaskDesc.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblTaskDesc.ForeColor = System.Drawing.Color.Silver;
            this.lblTaskDesc.Location = new System.Drawing.Point(242, 16);
            this.lblTaskDesc.Name = "lblTaskDesc";
            this.lblTaskDesc.Size = new System.Drawing.Size(287, 45);
            this.lblTaskDesc.TabIndex = 7;
            this.lblTaskDesc.Text = "DESCRIPTION";
            this.lblTaskDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaskName
            // 
            this.lblTaskName.BackColor = System.Drawing.Color.White;
            this.lblTaskName.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblTaskName.ForeColor = System.Drawing.Color.Silver;
            this.lblTaskName.Location = new System.Drawing.Point(42, 16);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(207, 45);
            this.lblTaskName.TabIndex = 6;
            this.lblTaskName.Text = "TASK";
            this.lblTaskName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTaskName.Click += new System.EventHandler(this.lblTaskName_Click);
            // 
            // guna2Panel23
            // 
            this.guna2Panel23.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel23.Location = new System.Drawing.Point(-2, 60);
            this.guna2Panel23.Name = "guna2Panel23";
            this.guna2Panel23.Size = new System.Drawing.Size(1135, 1);
            this.guna2Panel23.TabIndex = 25;
            // 
            // TaskFragment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel23);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.lblTaskDesc);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.detailedTaskListContainer);
            this.Name = "TaskFragment";
            this.Size = new System.Drawing.Size(939, 496);
            this.Load += new System.EventHandler(this.TaskFragment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel detailedTaskListContainer;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblTaskDesc;
        private System.Windows.Forms.Label lblTaskName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel23;
    }
}
