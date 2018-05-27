using Newtonsoft.Json;

namespace HttpClient.Entity
{
    [JsonObject]
    public class Hotel
    {
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }
        [JsonProperty(PropertyName = "link")]
        public string link { get; set; }
    }
}
