using HubstafDesktop.Data.Model.Response;
using HubstafDesktop.Data.Remote;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HubstafDesktop.Data
{
    public static class Repository
    {
        public static UserAuthResponse loggedInUser; //= new UserAuthResponse();
        public static List<ProjectResponse> projectListResponse;
        public static List<TaskResponse> tasksListResponse;

        public static void doLoginUser(string username, string password)
        {
            try
            {
                loggedInUser = Task.Run(() => ApiService.loginUserAsync(username, password)).Result;
            }
            catch (Exception ex)
            {
                //TODO handle the exception
                Debug.WriteLine("error " + ex.Message);
                MessageBox.Show("error " + ex.Message);
                throw;
            }
        }

        public static void getAllProject()
        {
            try
            {
                projectListResponse = Task.Run(() => ApiService.getAllProjectAsync()).Result;
                Debug.WriteLine("Project List Response : " + projectListResponse.ToString());
            }
            catch (Exception ex)
            {
                //TODO handle the exception
                Debug.WriteLine("error " + ex.Message);
                MessageBox.Show("error " + ex.Message);
                throw;
            }
        }

        public static void getAllTasks()
        {
            try
            {
                tasksListResponse = Task.Run(() => ApiService.getAllTaskAsync()).Result;
                Debug.WriteLine("Task List Response : " + projectListResponse.ToString());
            }
            catch (Exception ex)
            {
                //TODO handle the exception
                Debug.WriteLine("error " + ex.Message);
                MessageBox.Show("error " + ex.Message);
                throw;
            }
        }
    }
}
