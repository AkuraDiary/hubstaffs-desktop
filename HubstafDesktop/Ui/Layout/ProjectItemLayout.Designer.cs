
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
            this.lbl_task = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnl_txt.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectTaskListContainer
            // 
            this.projectTaskListContainer.AutoScroll = true;
            this.projectTaskListContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.projectTaskListContainer.Location = new System.Drawing.Point(-1, 57);
            this.projectTaskListContainer.Name = "projectTaskListContainer";
            this.projectTaskListContainer.Size = new System.Drawing.Size(309, 413);
            this.projectTaskListContainer.TabIndex = 0;
            this.projectTaskListContainer.WrapContents = false;
            // 
            // pnl_txt
            // 
            this.pnl_txt.Controls.Add(this.lbl_task);
            this.pnl_txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_txt.Location = new System.Drawing.Point(0, 0);
            this.pnl_txt.Name = "pnl_txt";
            this.pnl_txt.Size = new System.Drawing.Size(308, 51);
            this.pnl_txt.TabIndex = 1;
            // 
            // lbl_task
            // 
            this.lbl_task.AutoSize = false;
            this.lbl_task.BackColor = System.Drawing.Color.Transparent;
            this.lbl_task.Font = new System.Drawing.Font("Poppins", 11F);
            this.lbl_task.ForeColor = System.Drawing.Color.Black;
            this.lbl_task.Location = new System.Drawing.Point(13, 6);
            this.lbl_task.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.lbl_task.Name = "lbl_task";
            this.lbl_task.Size = new System.Drawing.Size(239, 39);
            this.lbl_task.TabIndex = 7;
            this.lbl_task.Text = "Task Item Time";
            this.lbl_task.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProjectItemLayout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnl_txt);
            this.Controls.Add(this.projectTaskListContainer);
            this.Name = "ProjectItemLayout";
            this.Size = new System.Drawing.Size(308, 470);
            this.Load += new System.EventHandler(this.ProjectItemLayout_Load);
            this.pnl_txt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel projectTaskListContainer;
        private Guna.UI2.WinForms.Guna2Panel pnl_txt;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_task;
    }
}
