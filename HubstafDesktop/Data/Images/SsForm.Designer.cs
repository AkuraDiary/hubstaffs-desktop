
namespace HubstafDesktop.Data.Images
{
    partial class SsForm
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
            this.picBoxSsContainer = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSsContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxSsContainer
            // 
            this.picBoxSsContainer.ImageRotate = 0F;
            this.picBoxSsContainer.Location = new System.Drawing.Point(12, 12);
            this.picBoxSsContainer.Name = "picBoxSsContainer";
            this.picBoxSsContainer.Size = new System.Drawing.Size(1556, 884);
            this.picBoxSsContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSsContainer.TabIndex = 0;
            this.picBoxSsContainer.TabStop = false;
            // 
            // SsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.picBoxSsContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SsForm";
            this.Text = "SsForm";
            this.Load += new System.EventHandler(this.SsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSsContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picBoxSsContainer;
    }
}