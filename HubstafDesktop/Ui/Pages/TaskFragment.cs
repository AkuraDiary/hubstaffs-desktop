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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        internal MainForm parentContext;
        private List<UserTask> listData = new List<UserTask>();
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

        void setupTaskList()
        {
            detailedTaskListContainer.Controls.Clear();
            foreach (var taskItem in listData)
            {
                TaskListDetailItemLayout taskItemLayout = new TaskListDetailItemLayout(this);
                taskItemLayout.TaskData = taskItem;

                detailedTaskListContainer.Controls.Add(taskItemLayout);
            }
        }

        private void TaskFragment_Load(object sender, EventArgs e)
        {
            bindData();
        }

        private void lblTaskName_Click(object sender, EventArgs e)
        {

        }
    }
}
