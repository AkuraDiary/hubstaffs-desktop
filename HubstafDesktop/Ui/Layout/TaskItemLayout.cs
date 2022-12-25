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

        public UserTask TaskData { get => taskData; set {
                taskData = value;
                lblTaskName.Text = value.TaskName;


                lblTimeNeeded.Text = TimerUtil.formatTime(taskData.TimeNeeded);
            } }

        public TaskItemLayout()
        {
            InitializeComponent();
        }
        public TaskItemLayout(UserTask taskData)
        {
            InitializeComponent();
            this.TaskData = taskData;
        }

        private void lblTaskName_Click(object sender, EventArgs e)
        {

        }
    }
}
