using Newtonsoft.Json;
using System.Collections.Generic;

namespace Datecraft.Data
{
    [JsonObject]
    public class Character
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("traits")]
        public List<string> Traits { get; set; }

        [JsonProperty("initial_parameters")]
        public Dictionary<string, int> InitialParameters { get; set; }

        [JsonProperty("dilemma_pools")]
        public List<string> DilemmaPools { get; set; }

        [JsonProperty("chat_pools")]
        public List<string> ChatPools { get; set; }

        [JsonProperty("card_foreground")]
        public Dictionary<string, string> CardForeground { get; set; }

        [JsonProperty("collectible")]
        public CollectibleData Collectible { get; set; }

        [JsonProperty("emotion_state")]
        public string EmotionState { get; set; }

        [JsonProperty("emotion_effects")]
        public Dictionary<string, Dictionary<string, int>> EmotionEffects { get; set; }
    }
}