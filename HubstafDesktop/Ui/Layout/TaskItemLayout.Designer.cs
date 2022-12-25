
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
            this.lblTaskName.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(12, 3);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(179, 49);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "Mobile App Bug FIxes";
            this.lblTaskName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimeNeeded
            // 
            this.lblTimeNeeded.AutoSize = false;
            this.lblTimeNeeded.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeNeeded.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeNeeded.Location = new System.Drawing.Point(211, 3);
            this.lblTimeNeeded.Name = "lblTimeNeeded";
            this.lblTimeNeeded.Size = new System.Drawing.Size(66, 49);
            this.lblTimeNeeded.TabIndex = 1;
            this.lblTimeNeeded.Text = "00:00";
            this.lblTimeNeeded.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskItemLayout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblTimeNeeded);
            this.Controls.Add(this.lblTaskName);
            this.Name = "TaskItemLayout";
            this.Size = new System.Drawing.Size(280, 55);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTaskName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimeNeeded;
    }
}
