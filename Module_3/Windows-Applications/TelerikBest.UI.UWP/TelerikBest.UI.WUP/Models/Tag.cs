namespace TelerikBest.UI.WUP.Models
{
    using System;
    using Newtonsoft.Json;

    public class Tag
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("foregroundColor")]
        public string ForegroundColor { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }
    }
}
