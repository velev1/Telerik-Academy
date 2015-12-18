namespace TelerikBest.UI.WUP.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TaBestProjectDetailed : TaProject
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("repositoryUrl")]
        public string RepositoryUrl { get; set; }

        [JsonProperty("liveDemoUrl")]
        public string LiveDemoUrl { get; set; }

        [JsonProperty("imageUrls")]
        public IEnumerable<string> ImageUrls { get; set; }

        [JsonProperty("isLiked")]
        public bool IsLiked { get; set; }

        [JsonProperty("isFlagged")]
        public bool IsFlagged { get; set; }
    }
}
