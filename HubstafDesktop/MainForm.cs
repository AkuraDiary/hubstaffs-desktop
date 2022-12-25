﻿using HubstafDesktop.Data.Dummy;
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

        #region prop region
        private UserProject selectedProject;
        private UserTask selectedTask;

        public UserProject SelectedProject { 
            get => selectedProject;
            set { 
                selectedProject = value;
                if (selectedProject != null)
                {
                    taskFragment.ListtData = selectedProject.TaskList;
                    lblCurrentProjectName.Text = selectedProject.ProjectName;
                }
                
            }
        }

        public UserTask SelectedTask
        {
            get => selectedTask;
            set
            {
                selectedTask = value;
                if (selectedTask != null)
                {
                    mainTimer.ChoosedTask = selectedTask;

                    lblSelectedTaskName.Text = selectedTask.TaskName;
                    lblSelectedTaskDesc.Text = selectedTask.TaskDesc;
                    mainTimer.ProjectName = selectedProject.ProjectName;
                    lblTaskName.Text = selectedTask.TaskName;
                }

            }
        }
        #endregion


        public MainForm()
        {
            InitializeComponent();
            mainTimer.parentContext = this;
            taskFragment.parentContext = this;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            //Debug.WriteLine(DummyDataSource.dummyListProject.AsQueryable());
           // setTimer(120);
            setupProjectList(DummyDataSource.dummyListProject);

        }


        #region timer region
        public void setTimer(int value)
        {
            mainTimer.TimerCountdownValue = value;
        }

        #endregion


        #region project list region
        public void setupProjectList(List<UserProject> projectData)
        {
            projectListFragmentContainer.Controls.Clear();
            foreach (var projectItem in projectData)
            {
                ProjectItemLayout item = new ProjectItemLayout(this, projectItem);

                projectListFragmentContainer.Controls.Add(item);
            }
        }

        #endregion

        #region misceleannous
        internal void focusMode(bool state)
        {
            projectTaskDetailFragmentCOntainer.Enabled = !state;
            projectListFragmentContainer.Enabled = !state;
            btnExit.Visible = !state;
            
        }


        #endregion

        #region formSetting

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion
    }
}
