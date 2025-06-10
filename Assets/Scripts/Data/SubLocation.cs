using Newtonsoft.Json;

namespace Datecraft.Data
{
    [JsonObject]
    public class SubLocation
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }
}