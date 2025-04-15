using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CounselCat;

namespace AdviceWrapper.Services
{
    public class AdviceService
    {
        private readonly HttpClient _httpClient;

        public AdviceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string?> GetAdviceAsync()
        {
            var response = await _httpClient.GetAsync("https://api.adviceslip.com/advice");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            using var jsonDoc = JsonDocument.Parse(content);

            return jsonDoc.RootElement.GetProperty("slip").GetProperty("advice").GetString();
        }
    }
}
