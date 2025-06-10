using Newtonsoft.Json;
using System.Collections.Generic;

namespace Datecraft.Data
{
    [JsonObject]
    public class Location
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("sublocations")]
        public List<SubLocation> Sublocations { get; set; }
    }
}