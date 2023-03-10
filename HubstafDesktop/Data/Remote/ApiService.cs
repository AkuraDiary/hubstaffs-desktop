using HubstafDesktop.Data.Model.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HubstafDesktop.Data.Remote
{
    public static class ApiService
    {

        #region config
        public static string base_url = "http://192.168.1.22:8080/api/";//"http://localhost:8000/api/";
        private static HttpClient api_client = new HttpClient
        {
            BaseAddress = new Uri(base_url)
        };

        public static HttpClient getclient()
        {
            // Assign default header to (Json Serialization)
            api_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return api_client;
        }
        #endregion

        #region endpoints region
        
        public static string organizationEndpoint = $"organizations";
        public static string projectEndpoint = "{0}/projects";
        public static string taskEndpoint = $"tasks";
        
        public static string loginEndpoint = $"login";
        public static string logoutEndpoint = $"logout";

        public static string uploadImageEndpoint = "tasks/{0}/upload-image";   
        public static string taskDoneEndpoint = "tasks/{0}/task-done";   
        #endregion

        public static async Task<UserAuthResponse> loginUserAsync(string mUsername, string mPassword)
        {

            // Create a login request object
            var request = new
            {
                username = mUsername,
                password = mPassword,
            };

            // Convert the request object to a JSON string
            var requestJson = JsonConvert.SerializeObject(request);

            // Create a StringContent object with the request JSON string
            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");


            // make and api call and receive HttpResponseMessage
            var responseMessage = await getclient().PostAsync(ApiService.loginEndpoint, content);

            //convert response message into string
            var resultArray = await responseMessage.Content.ReadAsStringAsync();
          

            if (resultArray != null)
            {
                // Deserialize the response content into a login response object
                var loginResponse = JsonConvert.DeserializeObject<UserAuthResponse>(resultArray);

                // var listHasilData = JsonConvert.DeserializeObject<List<HasilModel>>(resultArray);

                Debug.WriteLine("user login response : " + resultArray);

                return loginResponse;
            }
            else
            {
                MessageBox.Show("Not Found");
                return null;
                //user login response: { "message":"Wrong username or password","status":404}
            }

            
        }

        public static async Task<List<ProjectResponse>> getAllProjectAsync(int idUser, string bearerToken)
        {
            string endpointWithParam = string.Format(projectEndpoint, idUser);

            // Set the Authorization header with the Bearer token
            var client = getclient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

            // make and api call and receive HttpResponseMessage
            var responseMessage = await client.GetAsync(endpointWithParam, HttpCompletionOption.ResponseContentRead);

            //convert response message into string
            var resultArray = await responseMessage.Content.ReadAsStringAsync();

            GetProjectOfUserResponse responseResult = JsonConvert.DeserializeObject<GetProjectOfUserResponse>(resultArray);
            //Debug.WriteLine("user project list " + listData.Count);
            List<ProjectResponse> listData = responseResult.Project;

            Debug.WriteLine("user project list endpoint : " + endpointWithParam);
            Debug.WriteLine("user project list " + resultArray);

            return listData;
        }

        public static async void markTaskAsDoneAsync(int taskId, string bearerToken)
        {

            string endpointWithParam = string.Format(taskDoneEndpoint, taskId);

            // Set the Authorization header with the Bearer token
            var client = getclient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

            // make and api call and receive HttpResponseMessage
            var responseMessage = await client.PostAsync(endpointWithParam, new StringContent(""));// make a post request with empty content

            //convert response message into string
           var resultResponseMessage = await responseMessage.Content.ReadAsStringAsync();

          
            
            Debug.WriteLine("mark Project As Done : " + resultResponseMessage);

        }
        public static async void logOutUserAsync( string bearerToken)
        {

            string endpointWithParam = string.Format(logoutEndpoint);

            // Set the Authorization header with the Bearer token
            var client = getclient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

            // make and api call and receive HttpResponseMessage
            var responseMessage = await client.PostAsync(endpointWithParam, new StringContent(""));// make a post request with empty content

            //convert response message into string
            var resultResponseMessage = await responseMessage.Content.ReadAsStringAsync();



            Debug.WriteLine("Logout User : " + resultResponseMessage);

        }

        public static async void uploadImage(int idTask, string bearerToken, string filePath)
        {
            // The URL of the REST API endpoint
            string url = string.Format(uploadImageEndpoint, idTask);

            // Set the Authorization header with the Bearer token
            var client = getclient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

            // Create a boundary string
            string boundary = "--" + DateTime.Now.Ticks.ToString("x");

            // Create the content for the request
            var content = new MultipartFormDataContent(boundary);

            // Read the contents of the file
            byte[] imageData = File.ReadAllBytes(filePath);

            // Add the image file as a form data part
            content.Add(new ByteArrayContent(imageData), "image", Path.GetFileName(filePath));

            // Call the POST method
            var responseMessage = client.PostAsync(url, content).Result;

            // Read the response message
            var resultResponseMessage = await responseMessage.Content.ReadAsStringAsync();

            Debug.WriteLine("mark  Upload The Image Endpoint : " + url);
            Debug.WriteLine("Image Exist : " + File.Exists(filePath));
            Debug.WriteLine("mark Upload The Image : " + resultResponseMessage);    

        }


        #region [notes] how to do fuckin request

        //public static async Task<List<HasilModel>> getAllHasilDataAsync()
        //{

        //    // make and api call and receive HttpResponseMessage
        //    var responseMessage = await getclient().GetAsync(Service.hasilListEndpoint, HttpCompletionOption.ResponseContentRead);

        //    //convert response message into string
        //    var resultArray = await responseMessage.Content.ReadAsStringAsync();

        //    var listHasilData = JsonConvert.DeserializeObject<List<HasilModel>>(resultArray);
        //    Debug.WriteLine("hasildata list " + listHasilData.Count);
        //    return listHasilData;
        //}

        // how to fckin call the request method
        //public static void getAllHasilFromApi()
        //{
        //    try
        //    {
        //        listHasilData = Task.Run(() => Service.getAllHasilDataAsync()).Result;
        //    }
        //    catch (Exception ex)
        //    {
        //        //TODO handle the exception
        //        throw;
        //    }
        //}


        #endregion

        #region [notes] how to call it from fragment
        //private List<HasilBindingModel> listDataHasil;

        //public ListHasilFragment()
        //{
        //    InitializeComponent();
        //}

        //private async void ListHasilFragment_Load(object sender, EventArgs e)
        //{
        //    //await Repository.RequestThyAllFckinData();
        //    await requestDataHasil();
        //    //getDataListHasil();
        //    bindDataToViews();
        //}

        //private void bindDataToViews()
        //{
        //    hasilListContainer.Controls.Clear();
        //    foreach (HasilBindingModel item in listDataHasil)
        //    {
        //        ListHasilItemLayout hasilItem = new ListHasilItemLayout();
        //        // pass the tim data into timItem like that
        //        hasilItem.HasilData = item;
        //        hasilListContainer.Controls.Add(hasilItem); //create individual item
        //    }

        //}


        //private async Task requestDataHasil()
        //{
        //    await Task.Run(() => Repository.getHasilDataBinding()); // get data from api
        //    listDataHasil = Repository.listHasilBindingData;
        //    //bindDataToViews();
        //    //listDataHasil = DataMapper.mapHasilBinding(Repository.listBindingJadwalData, Repository.listHasilData);//DummyDataSource.generateDummyTimList();
        //    //Repository.listHasilBindingData = listDataHasil;
        //}
        #endregion

        #region [notes]  get method

        //public static async Task<TimModel> getTimById(int id)
        //{

        //    string endpointWithParam = string.Format(timByIdEndpoint, id);

        //    // make and api call and receive HttpResponseMessage
        //    var responseMessage = await getclient().GetAsync(endpointWithParam, HttpCompletionOption.ResponseContentRead);

        //    //convert response message into string
        //    var resultArray = await responseMessage.Content.ReadAsStringAsync();

        //    var timData = JsonConvert.DeserializeObject<TimModel>(resultArray);
        //    Debug.WriteLine("hasildata by id tim :  " + timData.nama_tim);
        //    return timData;
        //}

        //public static async Task<List<HasilModel>> getAllHasilDataAsync()
        //{

        //    // make and api call and receive HttpResponseMessage
        //    var responseMessage = await getclient().GetAsync(Service.hasilListEndpoint, HttpCompletionOption.ResponseContentRead);

        //    //convert response message into string
        //    var resultArray = await responseMessage.Content.ReadAsStringAsync();

        //    var listHasilData = JsonConvert.DeserializeObject<List<HasilModel>>(resultArray);
        //    Debug.WriteLine("hasildata list " + listHasilData.Count);
        //    return listHasilData;
        //}
        //#endregion

        //#region get data by id (path param)
        //public static async Task<TimModel> getTimById(int id)
        //{

        //    string endpointWithParam = string.Format(timByIdEndpoint, id);

        //    // make and api call and receive HttpResponseMessage
        //    var responseMessage = await getclient().GetAsync(endpointWithParam, HttpCompletionOption.ResponseContentRead);

        //    //convert response message into string
        //    var resultArray = await responseMessage.Content.ReadAsStringAsync();

        //    var timData = JsonConvert.DeserializeObject<TimModel>(resultArray);
        //    Debug.WriteLine("hasildata by id tim :  " + timData.nama_tim);
        //    return timData;
        //}
        #endregion
    }
}
