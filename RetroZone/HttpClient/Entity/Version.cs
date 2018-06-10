using Newtonsoft.Json;

namespace HttpClient.Entity
{
    [JsonObject]
    public class Version
    {
        [JsonProperty(PropertyName = "authorized")]
        public bool authorized { get; set; }
        [JsonProperty(PropertyName = "lastUpdate")]
        public string lastUpdate { get; set; }
    }
}
