
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
            this.lblProjectName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // projectTaskListContainer
            // 
            this.projectTaskListContainer.AutoScroll = true;
            this.projectTaskListContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.projectTaskListContainer.Location = new System.Drawing.Point(0, 73);
            this.projectTaskListContainer.Name = "projectTaskListContainer";
            this.projectTaskListContainer.Size = new System.Drawing.Size(310, 210);
            this.projectTaskListContainer.TabIndex = 0;
            this.projectTaskListContainer.WrapContents = false;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = false;
            this.lblProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectName.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.ForeColor = System.Drawing.Color.Black;
            this.lblProjectName.Location = new System.Drawing.Point(3, 3);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(304, 44);
            this.lblProjectName.TabIndex = 5;
            this.lblProjectName.Text = "Fix Bug In Home Page";
            this.lblProjectName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectItemLayout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.projectTaskListContainer);
            this.Name = "ProjectItemLayout";
            this.Size = new System.Drawing.Size(310, 283);
            this.Load += new System.EventHandler(this.ProjectItemLayout_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel projectTaskListContainer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProjectName;
    }
}
