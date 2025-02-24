using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service
{
    public class DeepSeekService
    {
        private readonly HttpClient _httpClient;
        private const string ApiUrl = "https://api.deepseek.com/chat/completions"; // URL de la API de DeepSeek

        public DeepSeekService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Domain.ChatResponse> SendMessageAsync(Domain.ChatRequest request)
        {
            var requestBody = new
            {
                model = "deepseek-chat",
                messages = new[]
            {
                new { role = "user", content = request.Message }
            },
                temperature = 0.7,
                max_tokens = 500
            };

            var json = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue
                (
                    "Bearer",
                    "sk-53751d5c6f344a5dbc0571de9f51313e"
                );

            var response = await _httpClient.PostAsync(ApiUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync();
                var rsp = JsonSerializer.Deserialize<Domain.ChatResponse>(responseJson);
                return rsp;
            }

            // Manejo de errores
            throw new HttpRequestException($"Error: {response.StatusCode}");
        }
    }
}
