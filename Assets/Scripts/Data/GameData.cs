using Newtonsoft.Json;
using System.Collections.Generic;

namespace Datecraft.Data
{
    [JsonObject]
    public class GameData
    {
        [JsonProperty("success_thresholds")]
        public List<SuccessThreshold> SuccessThresholds { get; set; }
    }

    [JsonObject]
    public class SuccessThreshold
    {
        [JsonProperty("parameter")]
        public string Parameter { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}