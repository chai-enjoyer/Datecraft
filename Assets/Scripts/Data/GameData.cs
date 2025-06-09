using Newtonsoft.Json;

namespace Datecraft.Data
{
    [JsonObject]
    public class GameData
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("energy_start")]
        public int EnergyStart { get; set; }

        [JsonProperty("fashion_tokens_start")]
        public int FashionTokensStart { get; set; }

        [JsonProperty("success_threshold")]
        public SuccessThreshold SuccessThreshold { get; set; }
    }

    [JsonObject]
    public class SuccessThreshold
    {
        [JsonProperty("min_all")]
        public int MinAll { get; set; }

        [JsonProperty("min_two")]
        public int MinTwo { get; set; }
    }
}