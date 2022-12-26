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

        private int idTask;
        private string taskName;
        private string taskDesc;
        private int timeNeeded;
        private string dateCreated;
        private string status;

        public int IdTask { get => idTask; set => idTask = value; }
        public string TaskName { get => taskName; set => taskName = value; }
        public string TaskDesc { get => taskDesc; set => taskDesc = value; }
        public int TimeNeeded { get => timeNeeded; set => timeNeeded = value; }
        public string DateCreated { get => dateCreated; set => dateCreated = value; }
        public string Status { get => status; set => status = value; }
        
        public UserTask()
        {

        }

        public UserTask(string name, string desc, int time, string date)
        {
            taskName = name;
            taskDesc = desc;
            timeNeeded = time;
            dateCreated = date;
        }

        //full constructor
        public UserTask(int idTask, string name, string desc, int time, string date, string status)
        {
            IdTask = idTask;
            taskName = name;
            taskDesc = desc;
            timeNeeded = time;
            dateCreated = date;
            Status = status;
        }

    }
}