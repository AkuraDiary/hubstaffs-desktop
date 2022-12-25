
namespace HubstafDesktop.Ui.Layout
{
    partial class ProjectItemLayout
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
            this.pnl_txt = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProjectName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.projectTaskListContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_txt.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_txt
            // 
            this.pnl_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.pnl_txt.Controls.Add(this.lblProjectName);
            this.pnl_txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_txt.Location = new System.Drawing.Point(0, 0);
            this.pnl_txt.Name = "pnl_txt";
            this.pnl_txt.Size = new System.Drawing.Size(305, 49);
            this.pnl_txt.TabIndex = 1;
            this.pnl_txt.Click += new System.EventHandler(this.ProjectItemLayout_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = false;
            this.lblProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectName.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            this.lblProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProjectName.Location = new System.Drawing.Point(4, 3);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(239, 39);
            this.lblProjectName.TabIndex = 8;
            this.lblProjectName.Text = "Task Item Time";
            this.lblProjectName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProjectName.Click += new System.EventHandler(this.ProjectItemLayout_Click);
            // 
            // projectTaskListContainer
            // 
            this.projectTaskListContainer.AutoScroll = true;
            this.projectTaskListContainer.BackColor = System.Drawing.Color.White;
            this.projectTaskListContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.projectTaskListContainer.Location = new System.Drawing.Point(0, 49);
            this.projectTaskListContainer.Name = "projectTaskListContainer";
            this.projectTaskListContainer.Size = new System.Drawing.Size(305, 159);
            this.projectTaskListContainer.TabIndex = 2;
            this.projectTaskListContainer.WrapContents = false;
            // 
            // ProjectItemLayout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.projectTaskListContainer);
            this.Controls.Add(this.pnl_txt);
            this.Name = "ProjectItemLayout";
            this.Size = new System.Drawing.Size(305, 210);
            this.Load += new System.EventHandler(this.ProjectItemLayout_Load);
            this.Click += new System.EventHandler(this.ProjectItemLayout_Click);
            this.pnl_txt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnl_txt;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProjectName;
        private System.Windows.Forms.FlowLayoutPanel projectTaskListContainer;
    }
}
