using System.Net.Http;
using System.Threading.Tasks;

namespace NFLPredictions.Services
{
    public class EspnNflService
    {
        private readonly HttpClient _httpClient;

        public EspnNflService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetScoreboardAsync()
        {
            string url = "https://site.api.espn.com/apis/site/v2/sports/football/nfl/scoreboard";

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            return json;
        }
    }
}