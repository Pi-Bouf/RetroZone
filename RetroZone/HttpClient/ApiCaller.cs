using HttpClient.Entity;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpClient
{
    class ApiCaller
    {
        public static string APIUrl = "http://retrozone.pierreb.tk";
        public const string APIVersion = "BETA-20180527";

        #region checkUpdate
        public static async Task<Entity.Version> checkVersion()
        {
            var request = new RestRequest("api/need_update", Method.GET);
            request.AddHeader("API-VERSION", ApiCaller.APIVersion);
            var client = new RestClient(ApiCaller.APIUrl);
            var response = await client.ExecuteTaskAsync(request);

            if (response.ErrorException != null)
            {
                MessageBox.Show("We are sorry, RetroZone server can't be contacted... Check your network ! \n\nVisit retrozone.net for more help !");
                Entity.Version ver = new Entity.Version();
                ver.authorized = true;
                return ver;
            }

            try
            {
                return JsonConvert.DeserializeObject<Entity.Version>(response.Content);
            }
            catch(Exception e)
            {
                MessageBox.Show("We are sorry, RetroZone server can't be contacted... Check your network ! \n\nVisit retrozone.net for more help !");
                Entity.Version ver = new Entity.Version();
                ver.authorized = true;
                return ver;
            }
        }
        #endregion

        #region Getters

        #region Hotels
        public static async Task<List<Hotel>> GetAllHotels()
        {
            var request = new RestRequest("api/hotels", Method.GET);
            request.AddHeader("API-VERSION", ApiCaller.APIVersion);
            var client = new RestClient(ApiCaller.APIUrl);
            var response = await client.ExecuteTaskAsync(request);

            if (response.ErrorException != null)
            {
                MessageBox.Show("Can't connect to RetroZone server. Try again later !");
                return new List<Hotel>();
            }

            return JsonConvert.DeserializeObject<List<Hotel>>(response.Content);
        }
        #endregion

        #endregion
    }
}
