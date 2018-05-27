using HttpClient.Entity;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace HttpClient
{
    class ApiCaller
    {
        private const string APIUrl = "http://localhost:8000";
        private const string APIVersion = "BETA-20180527";

        #region Factory
        private static RestClient httpClientFactory(RestRequest request)
        {
            var client = new RestClient(ApiCaller.APIUrl);
            request.AddHeader("API-VERSION", ApiCaller.APIVersion);
            IRestResponse response = client.Execute(request);

            return client;
        }
        #endregion

        #region Getters
        public static void GetAllHotels()
        {
            var request = new RestRequest("api/hotels", Method.GET);
            var client = httpClientFactory(request);

            var response = client.Execute(request);
            var deserialized = JsonConvert.DeserializeObject<Hotel>(response.Content);
            Console.WriteLine(JsonConvert.SerializeObject(deserialized));
        }
        #endregion
    }
}
