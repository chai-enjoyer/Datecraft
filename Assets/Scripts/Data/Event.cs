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
        public string Type { get; set; }

        [JsonProperty("pool")]
        public string Pool { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("choices")]
        public List<Choice> Choices { get; set; }
    }

    [JsonObject]
    public class Choice
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("effects")]
        public Dictionary<string, int> Effects { get; set; }

        [JsonProperty("responses")]
        public List<Response> Responses { get; set; }
    }

    [JsonObject]
    public class Response
    {
        [JsonProperty("emotion")]
        public string Emotion { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}