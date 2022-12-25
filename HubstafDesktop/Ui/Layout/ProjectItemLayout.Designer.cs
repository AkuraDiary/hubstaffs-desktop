
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
            this.projectTaskListContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_txt = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProjectName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnl_txt.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectTaskListContainer
            // 
            this.projectTaskListContainer.AutoScroll = true;
            this.projectTaskListContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.projectTaskListContainer.Location = new System.Drawing.Point(-1, 57);
            this.projectTaskListContainer.Name = "projectTaskListContainer";
            this.projectTaskListContainer.Size = new System.Drawing.Size(315, 240);
            this.projectTaskListContainer.TabIndex = 0;
            this.projectTaskListContainer.WrapContents = false;
            // 
            // pnl_txt
            // 
            this.pnl_txt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnl_txt.Controls.Add(this.lblProjectName);
            this.pnl_txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_txt.Location = new System.Drawing.Point(0, 0);
            this.pnl_txt.Name = "pnl_txt";
            this.pnl_txt.Size = new System.Drawing.Size(313, 51);
            this.pnl_txt.TabIndex = 1;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = false;
            this.lblProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectName.Font = new System.Drawing.Font("Poppins", 11F);
            this.lblProjectName.ForeColor = System.Drawing.Color.Black;
            this.lblProjectName.Location = new System.Drawing.Point(13, 6);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(239, 39);
            this.lblProjectName.TabIndex = 7;
            this.lblProjectName.Text = "Task Item Time";
            this.lblProjectName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProjectItemLayout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnl_txt);
            this.Controls.Add(this.projectTaskListContainer);
            this.Name = "ProjectItemLayout";
            this.Size = new System.Drawing.Size(313, 298);
            this.Load += new System.EventHandler(this.ProjectItemLayout_Load);
            this.pnl_txt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel projectTaskListContainer;
        private Guna.UI2.WinForms.Guna2Panel pnl_txt;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProjectName;
    }
}
