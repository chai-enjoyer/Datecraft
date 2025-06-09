using Newtonsoft.Json;
using System.Collections.Generic;

namespace Datecraft.Data
{
    [JsonObject]
    public class Event
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; } // "dilemma" or "chat"

        [JsonProperty("pool_id")]
        public string PoolId { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("situation", NullValueHandling = NullValueHandling.Ignore)]
        public string Situation { get; set; } // For dilemmas

        [JsonProperty("prompt", NullValueHandling = NullValueHandling.Ignore)]
        public string Prompt { get; set; } // For chats

        [JsonProperty("required_traits")]
        public List<string> RequiredTraits { get; set; }

        [JsonProperty("required_cosmetics")]
        public List<string> RequiredCosmetics { get; set; }

        [JsonProperty("emotion_change")]
        public Dictionary<string, string> EmotionChange { get; set; }

        [JsonProperty("choices", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Choice> Choices { get; set; } // For dilemmas

        [JsonProperty("responses", NullValueHandling = NullValueHandling.Ignore)]
        public List<Response> Responses { get; set; } // For chats
    }

    [JsonObject]
    public class Choice
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("effects")]
        public Dictionary<string, int> Effects { get; set; }

        [JsonProperty("trait_modifiers")]
        public Dictionary<string, Dictionary<string, int>> TraitModifiers { get; set; }

        [JsonProperty("cosmetic_modifiers")]
        public Dictionary<string, Dictionary<string, int>> CosmeticModifiers { get; set; }
    }

    [JsonObject]
    public class Response
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("effects")]
        public Dictionary<string, int> Effects { get; set; }

        [JsonProperty("trait_modifiers")]
        public Dictionary<string, Dictionary<string, int>> TraitModifiers { get; set; }

        [JsonProperty("cosmetic_modifiers")]
        public Dictionary<string, Dictionary<string, int>> CosmeticModifiers { get; set; }
    }
}