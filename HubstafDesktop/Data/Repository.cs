using HubstafDesktop.Data.Model;
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
        public static UserAuthResponse loggedInUser; 
        public static List<ProjectResponse> projectListResponse;

        public static List<UserProject> listProjectUser = new List<UserProject>();

        //public static List<TaskResponse> tasksListResponse;

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
                int currentUserId = Repository.loggedInUser.Id;
                string userToken = Repository.loggedInUser.Token;
                projectListResponse = Task.Run(() => ApiService.getAllProjectAsync(currentUserId, userToken)).Result;

                if (projectListResponse.Count > 0)
                {
                   Repository.listProjectUser = DataMapper.MapListProjectResponseToListUserProject(projectListResponse);
                }
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

        public static void setTakAsDone(int taskId)
        {
            try
            {
                string userToken = Repository.loggedInUser.Token;
                Task.Run(() => ApiService.markTaskAsDoneAsync(taskId, userToken));
                
            }
            catch (Exception ex)
            {
                //TODO handle the exception
                Debug.WriteLine("error " + ex.Message);
                MessageBox.Show("error " + ex.Message);
                throw;
            }
        }

        public static void doLogoutUser()
        {
            try
            {
                string userToken = Repository.loggedInUser.Token;
                Task.Run(() => ApiService.logOutUserAsync(userToken));

            }
            catch (Exception ex)
            {
                //TODO handle the exception
                Debug.WriteLine("error " + ex.Message);
                MessageBox.Show("error " + ex.Message);
                throw;
            }
        }

        public static void sendImage(int taskId, string imageFilePath)//Byte[] imgData)
        {
            try
            {
                string userToken = Repository.loggedInUser.Token;
                Task.Run(() => ApiService.uploadImage(taskId, userToken, imageFilePath));

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
