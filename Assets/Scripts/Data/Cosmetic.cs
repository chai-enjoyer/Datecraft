using System.Collections.Generic;
using Newtonsoft.Json;

namespace Datecraft.Data
{
    [JsonObject]
    public class Cosmetic
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("effect")]
        public Dictionary<string, int> Effect { get; set; }

        [JsonProperty("unlock_condition")]
        public UnlockCondition UnlockCondition { get; set; }
    }

    [JsonObject]
    public class UnlockCondition
    {
        [JsonProperty("collectible_npcs")]
        public List<string> CollectibleNpcs { get; set; }
    }
}