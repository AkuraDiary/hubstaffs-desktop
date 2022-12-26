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

        public static void doLoginUser(string username, string password)
        {
            try
            {
                loggedInUser = Task.Run(() => ApiService.loginUserAsync(username, password)).Result;//.getAllHasilDataAsync()).Result;
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
