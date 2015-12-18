namespace TelerikBest.UI.WUP.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TaProject
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("mainImageUrl")]
        public string MainImageUrl { get; set; }

        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("shortDate")]
        public string ShortDate { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("visits")]
        public int Visits { get; set; }

        [JsonProperty("comments")]
        public int Comments { get; set; }

        [JsonProperty("flags")]
        public int Flags { get; set; }

        [JsonProperty("isHidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("titleUrl")]
        public string TitleUrl { get; set; }

        [JsonProperty("collaborators")]
        public IEnumerable<Colaborator> Collaborators { get; set; }

        [JsonProperty("tags")]
        public IEnumerable<Tag> Tags { get; set; }
    }
}
