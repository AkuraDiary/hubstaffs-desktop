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
            new UserTask(1,"ingfo", "ingfokan ingfo", 120, "2022-12-21", "done"),

            new UserTask(2, "ingfo lagi", "mengingfokan ingfo lagi ingfo", 300, "2022-12-25", "done"),

            new UserTask(3, "wanjay", "Anjay ingfo", 120, "2022-12-22", "done"),

            new UserTask(4, "add revisi design", "Lorem ipsum dolor sit amet hasbadlasdaljsd", 30, "2022-12-27", "todo"),

            new UserTask(5, "some kinda long task name", "aisdalksdalwdad", 3, "2022-12-29", "todo"),
        };

        public static List<UserTask> ZendentadummyTaskList = new List<UserTask>()
        {
            new UserTask(1,"ingfo", "ingfokan ingfo", 120, "2022-12-21", "done"),

            new UserTask(2, "ingfo lagi", "mengingfokan ingfo lagi ingfo", 300, "2022-12-25", "done"),

            new UserTask(3, "wanjay", "Anjay ingfo", 120, "2022-12-22", "done"),

            new UserTask(4, "add revisi design", "Lorem ipsum dolor sit goes brrrrrrrrrrr", 30, "2022-12-27", "todo"),

            new UserTask(5, "some kinda long task name", "asdasaasbbrrrrrrrrrrrrrrrrrrrrrrrrr", 30, "2022-12-29", "todo"),
        };

        public static List<UserTask> hbsdummyTaskList = new List<UserTask>()
        {
            new UserTask(1,"ingfo", "ingfokan ingfo", 120, "2022-12-21", "done"),

            new UserTask(2, "ingfo lagi", "mengingfokan ingfo lagi ingfo", 300, "2022-12-25", "done"),

            new UserTask(3, "wanjay", "Anjay ingfo", 120, "2022-12-22", "done"),

            new UserTask(4, "add revisi design aajnsdjan", "Lorem ipsum dolor sit amet hasbadlasdaljsd", 30, "2022-12-27", "todo"),

            new UserTask(5, "some kinda long task name", "asdasdasccxcvzxcv", 30, "2022-12-29", "todo"),
        };

        public static List<UserProject> dummyListProject = new List<UserProject>() {
            new UserProject(1, "Konzi Project", dummyTaskList),
            new UserProject(2, "Zendenta Project", ZendentadummyTaskList),
            new UserProject(3, "Hubstaff Project", hbsdummyTaskList)
        };

     
    }
}
