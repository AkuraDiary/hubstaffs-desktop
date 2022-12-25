using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HubstafDesktop.Data.Model
{
    public class UserTask
    {
        private string taskName;
        private string taskDesc;
        private int timeNeeded;
        private DateTime dateCreated;
        private int idTask;
        private string status;

        public int IdTask { get => idTask; set => idTask = value; }
        public string TaskName { get => taskName; set => taskName = value; }
        public string TaskDesc { get => taskDesc; set => taskDesc = value; }
        public int TimeNeeded { get => timeNeeded; set => timeNeeded = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public string Status { get => status; set => status = value; }
        public UserTask()
        {

        }

        public UserTask(string name, string desc, int time, DateTime date)
        {
            taskName = name;
            taskDesc = desc;
            timeNeeded = time;
            dateCreated = date;
        }

    }
}