using HubstafDesktop.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HubstafDesktop.Ui.Layout
{
    public partial class ProjectItemLayout : UserControl
    {
        private UserProject projectData;
        internal MainForm parentContext;
        public UserProject ProjectData
        {
            get => projectData; set
            {
                projectData = value;
                
                
                if (projectData != null)
                {
                    lblProjectName.Text = value.ProjectName;

                    bool hasUnfinishedTask = projectData.TaskList.Any(it => it.Status.Equals("todo"));
                    this.Visible = hasUnfinishedTask;
                }

            }
        }

        public ProjectItemLayout(MainForm parentContext, UserProject userProject)
        {
            InitializeComponent();
            ProjectData = userProject;
            this.parentContext = parentContext;
        }
        public ProjectItemLayout()
        {
            InitializeComponent();
        }

        private void ProjectItemLayout_Load(object sender, EventArgs e)
        {
            if (projectData != null)
            {
                bindData();
            }
        }


        void bindData()
        {
            if (projectData.TaskList.Count > 0)
            {
                setupTaskListPreview();
            }
        }

        void setupTaskListPreview()
        {
            //show 3 todo task
            projectTaskListContainer.Controls.Clear();
            int counter = 0;
            foreach (var taskItem in projectData.TaskList)
            {
                if (counter == 3)
                {
                    break;
                }

                if (!taskItem.Status.Equals("done"))
                {
                    TaskItemLayout taskItemLayout = new TaskItemLayout(this);
                    taskItemLayout.TaskData = taskItem;

                    projectTaskListContainer.Controls.Add(taskItemLayout);
                    counter++;
                }
            }
        }


        internal void ProjectItemLayout_Click(object sender, EventArgs e)
        {
            //send data into main form
            parentContext.SelectedProject = projectData;
        }
    }
}
