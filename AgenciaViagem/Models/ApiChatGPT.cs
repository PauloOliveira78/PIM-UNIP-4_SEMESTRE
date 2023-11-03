using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViagem.Models
{
    internal class ApiChatGPT
    {
        private readonly string apiKey;
        public string Prompt { get; private set; }

        public ApiChatGPT(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public void SetPrompt(string prompt)
        {
            Prompt = prompt;
        }

        public async Task<string> GetChatSuggestion()
        {
            string apiUrl = "https://api.openai.com/v1/engines/text-davinci-003/completions";
            var requestData = new { prompt = Prompt, max_tokens = 50 };

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                var requestContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(apiUrl, requestContent);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    dynamic jsonResult = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                    return jsonResult.choices[0]?.text ?? string.Empty;
                }
                else
                {
                    return "Erro ao fazer a solicitação ao ChatGPT.";
                }
            }
        }
    }
}
