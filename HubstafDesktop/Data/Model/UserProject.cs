using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubstafDesktop.Data.Model
{
    public class UserProject
    {
        private string projectName;
        private List<UserTask> taskList;
        private string companyName;

        public string CompanyName { get => companyName; set => companyName = value; }
        public string ProjectName { get => projectName; set => projectName = value; }
        public List<UserTask> TaskList { get => taskList; set => taskList = value; }
    }
}
