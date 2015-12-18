namespace TelerikBest.UI.WUP.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TaDetailedProjectResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("data")]
        public TaBestProjectDetailed Project { get; set; }
    }
}
