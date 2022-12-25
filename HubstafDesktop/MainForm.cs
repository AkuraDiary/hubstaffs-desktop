using HubstafDesktop.Data.Dummy;
using HubstafDesktop.Data.Model;
using HubstafDesktop.Ui.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HubstafDesktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
            //Debug.WriteLine(DummyDataSource.dummyListProject.AsQueryable());
            setupProjectList(DummyDataSource.dummyListProject);
        }


        #region timer region
        public void setTimer()
        {
            mainTimer.TimerCountdownValue = 120;
        }

        #endregion


        #region project list region
        public void setupProjectList(List<UserProject> projectData)
        {
            projectListFragmentContainer.Controls.Clear();
            foreach (var projectItem in projectData)
            {
                ProjectItemLayout item = new ProjectItemLayout(projectItem);

                projectListFragmentContainer.Controls.Add(item);
            }
        }

        #endregion




    }
}
