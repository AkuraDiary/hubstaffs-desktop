using HubstafDesktop.Data.Model.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HubstafDesktop.Data.Remote
{
    public static class ApiService
    {

        #region config
        public static string base_url = "http://localhost:8000/api/";
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
        public static string loginEndpoint = $"login";

        //public static string jadwalByIdEndpoint = "jadwal/{0}";
        //public static string hasilByIdEndpoint = "hasil/{0}";
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

            var client = getclient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));

            var responseMessage = await client.PostAsync(ApiService.loginEndpoint, content);

            //convert response message into string
            var resultArray = await responseMessage.Content.ReadAsStringAsync();

            // Deserialize the response content into a login response object
            var loginResponse = JsonConvert.DeserializeObject<UserAuthResponse>(resultArray);

            // var listHasilData = JsonConvert.DeserializeObject<List<HasilModel>>(resultArray);
            
            Debug.WriteLine("user login response : " + resultArray);

            return loginResponse;
        }


        #region how to fuckin do request

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


        #region how to call it from fragment
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

        #region get method
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
