using HubstafDesktop.Data.Model;
using HubstafDesktop.Util;
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
    public partial class TaskItemLayout : UserControl
    {
        private UserTask taskData;
        private ProjectItemLayout parentContext;
        private bool isSelected;

        public bool IsSelected { get => isSelected; set { 
                isSelected = value;
                setState(isSelected);
            }}

        public UserTask TaskData
        {
            get => taskData; set
            {
                taskData = value;
                lblTaskName.Text = value.TaskName;


                lblTimeNeeded.Text = TimerUtil.formatTime(taskData.TimeNeeded);
            }
        }

        public TaskItemLayout(ProjectItemLayout parentContext)
        {
            InitializeComponent();
            this.parentContext = parentContext;
        }
        public TaskItemLayout(UserTask taskData)
        {
            InitializeComponent();
            this.TaskData = taskData;
          
        }




        #region appearance helper region
        public void setState(bool isActive)
        {
            if (isActive)
            {
                BackColor = Color.FromArgb(94, 148, 255);
                lblTaskName.ForeColor = Color.White;
                lblTimeNeeded.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.White;
                lblTaskName.ForeColor = Color.Black;
                lblTimeNeeded.ForeColor = Color.Black;
            }
        }
        #endregion

        private void TaskItemLayout_MouseEnter(object sender, EventArgs e)
        {
            setState(true);
        }

        private void TaskItemLayout_Click(object sender, EventArgs e)
        {
            //IsSelected = true;
            parentContext.ProjectItemLayout_Click(sender, e);
            parentContext.parentContext.SelectedTask = taskData;
        }

        private void TaskItemLayout_MouseLeave(object sender, EventArgs e)
        {
            if (!IsSelected)
            {
                setState(false);
            }
            
        }

        private void TaskItemLayout_Load(object sender, EventArgs e)
        {

        }
    }
}
