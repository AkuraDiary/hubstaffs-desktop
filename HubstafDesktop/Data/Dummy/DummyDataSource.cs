using HubstafDesktop.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HubstafDesktop.Data.Dummy
{
    public static class DummyDataSource
    {
        
        public static List<UserTask> dummyTaskList = new List<UserTask>()
        {
            new UserTask("ingfo", "ingfokan ingfo", 120, DateTime.Parse("2022-12-21")),

            new UserTask("ingfo lagi", "mengingfokan ingfo lagi ingfo", 300, DateTime.Parse("2022-12-25")),

            new UserTask("wanjay", "Anjay ingfo", 120, DateTime.Parse("2022-12-22")),
        };

        public static List<UserProject> dummyListProject = new List<UserProject>() {
            new UserProject("Konzi Project", dummyTaskList),
            new UserProject("Zendenta Project", dummyTaskList),
            new UserProject("Hubstaff Project", dummyTaskList)
        };

     
    }
}
