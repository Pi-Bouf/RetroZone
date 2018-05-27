using RestSharp;
using System;
using System.Net.Http;

namespace RetroZone.HttpClient
{
    class HttpClient
    {
        public HttpClient()
        {

        }

        public static void getAllHotels()
        {
            var client = new RestClient("http://localhost:8000");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("api/", Method.GET);
            request.AddHeader("VERSION", "87456987456987456987456987456987456987456");

            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string

            client.ExecuteAsync(request, coco => {
                Console.WriteLine(coco.Content);
            });
        }
    }
}
