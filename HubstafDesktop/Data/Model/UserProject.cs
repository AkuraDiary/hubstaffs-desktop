using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubstafDesktop.Data.Model
{
    public class UserProject
    {
        private int idProject;
        private string projectName;
        private List<UserTask> taskList;
        private string companyName;
        private int timeSpan = 0;
      

        public int IdProject { get => idProject; set => idProject = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string ProjectName { get => projectName; set => projectName = value; }
        public List<UserTask> TaskList { get => taskList; set => taskList = value; }
        public int TimeSpan { get => timeSpan; set => timeSpan = value; }
        public UserProject()
        {

        }

        public UserProject(string name, List<UserTask> taskList)
        {
            ProjectName = name;
            TaskList = taskList;
        }

        public UserProject(int id,string name, List<UserTask> taskList, string companyName, int timeSpan)
        {
            IdProject = id;
            ProjectName = name;
            TaskList = taskList;
            CompanyName = companyName;
            TimeSpan = timeSpan;
        }
        
        //full constructor
        public UserProject(int id, string name, List<UserTask> taskList)
        {
            IdProject = id;
            ProjectName = name;
            TaskList = taskList;
        }
    }
}
