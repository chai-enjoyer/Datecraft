using Newtonsoft.Json;

namespace Datecraft.Data
{
    [JsonObject]
    public class CosmeticData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("unlock_condition")]
        public UnlockCondition UnlockCondition { get; set; }
    }

    [JsonObject]
    public class UnlockCondition
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("parameter")]
        public string Parameter { get; set; }

        [JsonProperty("threshold")]
        public int Threshold { get; set; }
    }
}