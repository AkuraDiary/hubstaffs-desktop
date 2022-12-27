
namespace HubstafDesktop.Ui.Layout
{
    partial class TaskItemLayout
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
            this.lblTaskName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTimeNeeded = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = false;
            this.lblTaskName.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskName.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblTaskName.ForeColor = System.Drawing.Color.Black;
            this.lblTaskName.Location = new System.Drawing.Point(3, 3);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(176, 33);
            this.lblTaskName.TabIndex = 5;
            this.lblTaskName.Text = "Customer";
            this.lblTaskName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTaskName.Click += new System.EventHandler(this.TaskItemLayout_Click);
            this.lblTaskName.MouseEnter += new System.EventHandler(this.TaskItemLayout_MouseEnter);
            this.lblTaskName.MouseLeave += new System.EventHandler(this.TaskItemLayout_MouseLeave);
            // 
            // lblTimeNeeded
            // 
            this.lblTimeNeeded.AutoSize = false;
            this.lblTimeNeeded.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeNeeded.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblTimeNeeded.ForeColor = System.Drawing.Color.Black;
            this.lblTimeNeeded.Location = new System.Drawing.Point(185, 0);
            this.lblTimeNeeded.Name = "lblTimeNeeded";
            this.lblTimeNeeded.Size = new System.Drawing.Size(87, 36);
            this.lblTimeNeeded.TabIndex = 6;
            this.lblTimeNeeded.Text = "00:00";
            this.lblTimeNeeded.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTimeNeeded.Click += new System.EventHandler(this.TaskItemLayout_Click);
            this.lblTimeNeeded.MouseEnter += new System.EventHandler(this.TaskItemLayout_MouseEnter);
            this.lblTimeNeeded.MouseLeave += new System.EventHandler(this.TaskItemLayout_MouseLeave);
            // 
            // TaskItemLayout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTimeNeeded);
            this.Controls.Add(this.lblTaskName);
            this.Name = "TaskItemLayout";
            this.Size = new System.Drawing.Size(280, 36);
            this.Load += new System.EventHandler(this.TaskItemLayout_Load);
            this.Click += new System.EventHandler(this.TaskItemLayout_Click);
            this.MouseEnter += new System.EventHandler(this.TaskItemLayout_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.TaskItemLayout_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTaskName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimeNeeded;
    }
}
