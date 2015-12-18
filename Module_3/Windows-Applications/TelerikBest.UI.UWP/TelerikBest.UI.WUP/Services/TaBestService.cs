namespace TelerikBest.UI.WUP.Services
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Models;


    public class TaBestService
    {
        private const string ApiBaseUrl = "http://best.telerikacademy.com/api/projects/";
        private const string QueryString = "?lat={0}&lng={1}&date={2}&formatted=0";

        private HttpClient httpClient;

        public TaBestService()
        {
            this.httpClient = new HttpClient();
            this.httpClient.BaseAddress = new Uri(ApiBaseUrl);
        }


        public async Task<TABestReponseModel> GetPopularProjects()
        {
            var response = await this.httpClient.GetAsync("popular");

            var data = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<TABestReponseModel>(data);

            return  result;
        }

        public async Task<TaBestProjectDetailed> GetDetailedProject(string url)
        {
            var response = await this.httpClient.GetAsync(url);

            var data = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<TaDetailedProjectResponse>(data);

            return result.Project;
        }
    }
}

