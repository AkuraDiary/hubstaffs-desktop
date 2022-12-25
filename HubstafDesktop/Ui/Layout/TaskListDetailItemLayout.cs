﻿using HubstafDesktop.Data.Model;
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
                //lblTaskName.Text = value.TaskName;


                //lblTimeNeeded.Text = TimerUtil.formatTime(taskData.TimeNeeded);
            }
        }


        public TaskListDetailItemLayout()
        {
            InitializeComponent();
        }



        #region appearance helper region
        public void setState(bool isActive)
        {
            if (isActive)
            {
                BackColor = Color.DodgerBlue;
                lblTaskName.ForeColor = Color.White;
                //lblTimeNeeded.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.White;
                lblTaskName.ForeColor = Color.Black;
                //lblTimeNeeded.ForeColor = Color.Black;
            }
        }
        #endregion

        private void TaskItemLayout_MouseEnter(object sender, EventArgs e)
        {
            setState(true);
        }

        private void TaskItemLayout_Click(object sender, EventArgs e)
        {
            IsSelected = true;
        }

        private void TaskItemLayout_MouseLeave(object sender, EventArgs e)
        {
            if (!IsSelected)
            {
                setState(false);
            }

        }
    }
}