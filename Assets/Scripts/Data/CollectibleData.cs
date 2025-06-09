using Newtonsoft.Json;

namespace Datecraft.Data
{
    [JsonObject]
    public class CollectibleData
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}