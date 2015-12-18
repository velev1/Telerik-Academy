namespace TelerikBest.UI.WUP.Models
{
    using Newtonsoft.Json;

    public class Colaborator
    {
        [JsonProperty("UserName")]
        public string UserName { get; set; }

        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }
    }
}
