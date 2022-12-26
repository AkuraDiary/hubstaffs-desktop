using HubstafDesktop.Data.Model;
using HubstafDesktop.Ui.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HubstafDesktop.Ui.Pages
{


    public partial class TaskFragment : UserControl
    {


        internal MainForm parentContext;
        private List<UserTask> listData = new List<UserTask>();
        

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<UserTask> ListtData
        {
            get => listData; set
            {
                listData = value;
                if (listData != null)
                {
                    bindData();
                }

            }
        }

        public TaskFragment()
        {
            InitializeComponent();
        }


        void bindData()
        {
            if (listData.Count > 0)
            {
                setupTaskList();
            }
        }


        private bool showDone = false;

        public bool ShowDone { get => showDone; set {
                showDone = value;
                setupTaskList();
            }

    }

        public void setupTaskList()
        {
            detailedTaskListContainer.Controls.Clear();
            foreach (var taskItem in listData)
            {
                if (ShowDone)
                {
                    TaskListDetailItemLayout taskItemLayout = new TaskListDetailItemLayout(this);
                    taskItemLayout.TaskData = taskItem;

                    detailedTaskListContainer.Controls.Add(taskItemLayout);
                }
                else
                {
                    if (!taskItem.Status.Equals("done"))
                    {
                        TaskListDetailItemLayout taskItemLayout = new TaskListDetailItemLayout(this);
                        taskItemLayout.TaskData = taskItem;

                        detailedTaskListContainer.Controls.Add(taskItemLayout);
                    }
                }
                

            }
        }

        private void TaskFragment_Load(object sender, EventArgs e)
        {
            bindData();
        }

        private void lblTaskName_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxShowDone_CheckedChanged(object sender, EventArgs e)
        {
            ShowDone = checkBoxShowDone.Checked;
        }
    }
}
