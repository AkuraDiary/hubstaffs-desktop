using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HubstafDesktop.Data.Images
{
    public partial class SsForm : Form
    {
        public SsForm(byte[] imageData)
        {
            InitializeComponent();

            MemoryStream imgStream = new MemoryStream(imageData);
            picBoxSsContainer.Image = Image.FromStream(imgStream);
            picBoxSsContainer.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void SsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
