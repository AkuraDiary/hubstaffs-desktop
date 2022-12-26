using HubstafDesktop.Data.Dummy;
using HubstafDesktop.Data.Images;
using HubstafDesktop.Data.Model;
using HubstafDesktop.Ui.Layout;
using HubstafDesktop.Util;
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
        private int totalTimeSpent = 0;
        public int TotalTimeSpent { get => totalTimeSpent; 
            set { 
                totalTimeSpent = value;
                lblTotalTimeSpent.Text = TimerUtil.formatTime(totalTimeSpent);
            } 
        }

        public UserProject SelectedProject
        {
            get => selectedProject;
            set
            {
                selectedProject = value;
                if (selectedProject != null)
                {
                    taskFragment.ListtData = selectedProject.TaskList;
                    lblCurrentProjectName.Text = selectedProject.ProjectName;
                    int totalTime = 0;

                    foreach (var item in selectedProject.TaskList)
                    {
                        if (item.Status.Equals("done"))
                        {
                            totalTime += item.TimeNeeded;
                        }
                    }
                    TotalTimeSpent = totalTime;
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
                    lblSelectedTaskStatus.Text = selectedTask.Status;

                    //syncSelectedTask(selectedTask);
                }
            }
        }


        public void syncSelectedTask(UserTask newTaskData)
        {
            //var result = from r in list where r.ProductID == 2 select r;

            //result.First().ProductName = “Chan”;
            if (SelectedProject.TaskList.Exists(it => it.IdTask == newTaskData.IdTask))
            {
                int index = SelectedProject.TaskList.FindIndex(it => it.IdTask == newTaskData.IdTask);
                SelectedProject.TaskList.RemoveAt(index); 
                SelectedProject.TaskList.Insert(index, newTaskData);
                refreshMainPage();
                
            }
        }

        public void refreshMainPage()
        {
            updateDataInDataSource();
            taskFragment.setupTaskList();
            mainTimer.clearBinding();
            setTimer(0);
            clearSelectedTaskBinding();
            //SelectedTask = null;
        }

        void clearSelectedTaskBinding()
        {
            lblSelectedTaskDesc.Text = "";
            lblCurrentProjectName.Text = "";
            lblSelectedTaskStatus.Text = "";
            lblSelectedTaskName.Text = "";
        }

        public void updateDataInDataSource()
        {
            if (DummyDataSource.dummyListProject.Exists(it => it.IdProject == selectedProject.IdProject))
            {
                int index = DummyDataSource.dummyListProject.FindIndex(it => it.IdProject== selectedProject.IdProject);
                DummyDataSource.dummyListProject.RemoveAt(index);
                DummyDataSource.dummyListProject.Insert(index, selectedProject);
                setupProjectList(DummyDataSource.dummyListProject); // refresh
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
            foreach (UserProject projectItem in projectData)
            {
                ProjectItemLayout item = new ProjectItemLayout(this, projectItem);
                projectListFragmentContainer.Controls.Add(item);
            }
            //SelectedProject = null;
            
        
        }



        #endregion

        #region photo and ss region
        public void takeAndShowScreenshot()
        {
            bringBackTheFuckingOriginalSizeOfForm();
            var ss = ImagesUtil.takeScreenshoot();
            ImagesUtil.ShowSsResult(ss);
           

        }
        #endregion

        #region misceleannous
        internal void focusMode(bool state)
        {
            projectTaskDetailFragmentCOntainer.Enabled = !state;
            projectListFragmentContainer.Enabled = !state;
            btnExit.Visible = !state;
            btnMinimze.Visible = state;
            btnFormMode.PerformClick();

        }

        int FormOriginalWidth = 1294;
        int FormOriginalHeight = 775;
        bool isMini = false;
        bool isSmall = true;


       public void miniMode() {

            isMini = !isMini; // switch state
            btnFormMode.PerformClick();
            if (isMini)
            {
                this.Width = 340;
                this.Height = 300;
            }
            else
            {
                bringBackTheFuckingOriginalSizeOfForm();
                //this.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void btnFormMode_Click(object sender, EventArgs e)
        {
            isSmall = !isSmall; // switch state
            if (isSmall)
            {
                this.Width = 340;
                //this.Height = 340;
                this.BringToFront();

            }
            else
            {
                bringBackTheFuckingOriginalSizeOfForm();
                //this.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        public void bringBackTheFuckingOriginalSizeOfForm()
        {
            this.Width = FormOriginalWidth;
            this.Height = FormOriginalHeight;
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

        private void btnMinimze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    


    }
}
