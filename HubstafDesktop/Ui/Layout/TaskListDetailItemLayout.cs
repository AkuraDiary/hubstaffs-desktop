using HubstafDesktop.Data.Model;
using HubstafDesktop.Ui.Pages;
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
    public partial class TaskListDetailItemLayout : UserControl
    {

        private UserTask taskData;
        private bool isSelected;
        private TaskFragment parentContext;

        public bool IsSelected
        {
            get => isSelected; set
            {
                isSelected = value;
                setState(isSelected);
            }
        }

        public UserTask TaskData
        {
            get => taskData; set
            {
                taskData = value;
                lblTaskName.Text = value.TaskName;
                lblTaskDesc.Text = value.TaskDesc;
                lblDateCreated.Text = value.DateCreated;

                if (TaskData.Status.Equals("done"))
                {
                    BackColor = Color.PaleGreen;
                    taskPanel.BackColor = Color.PaleGreen;
                }
            }
        }


        public TaskListDetailItemLayout(TaskFragment parentContext)
        {
            InitializeComponent();
            this.parentContext = parentContext;
        }



        #region appearance helper region
        public void setState(bool isActive)
        {
            if (isActive)
            {
                BackColor = Color.FromArgb(94, 148, 255);
                taskPanel.BackColor = Color.FromArgb(94, 148, 255);

                lblTaskName.ForeColor = Color.White;
                lblTaskDesc.ForeColor = Color.White;
                lblDateCreated.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.White;
                taskPanel.BackColor = Color.White;

                lblTaskName.ForeColor = Color.Black;
                lblTaskDesc.ForeColor = Color.Black;
                lblDateCreated.ForeColor = Color.Black;
            }
        }

        #endregion

        private void TaskItemLayout_MouseEnter(object sender, EventArgs e)
        {
            if (!TaskData.Status.Equals("done"))
            {
                setState(true);
            }
                
        }

        private void TaskItemLayout_Click(object sender, EventArgs e)
        {
            //IsSelected = true;
            parentContext.parentContext.SelectedTask = taskData;
        }

        private void TaskItemLayout_MouseLeave(object sender, EventArgs e)
        {

            if (!TaskData.Status.Equals("done"))
            {
                if (!IsSelected)
                {
                    setState(false);
                }
            }

        }
    }
}
