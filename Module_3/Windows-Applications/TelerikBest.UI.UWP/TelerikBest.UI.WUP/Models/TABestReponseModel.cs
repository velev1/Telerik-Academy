namespace TelerikBest.UI.WUP.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TABestReponseModel
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("data")]
        public IEnumerable<TaProject> Projects { get; set; } 
    }
}
