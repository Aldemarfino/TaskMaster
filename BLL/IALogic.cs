using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace BLL
{
    public class IALogic
    {

        private readonly string ApiKey;
        private static readonly HttpClient _httpClient = new HttpClient();
        public IALogic() 
        {
            ApiKey = "sk-proj-Gly0MgeDq7q7ggiP6WF4v7AyKeLzjbw7eUByA7PR1r6zmiScMzPdn5Wm" +
             "MBPtCOXyG7vdEzgwBiT3BlbkFJ9ZnsMPbmfkkiNmfEIQAJeE19DEWeoc9X_G9AMQWJPUxgE6rvr0PSCwjsPqDdK945GsHXNPKKMA";
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {ApiKey}");
        }       
        public async Task<string> IAReply(string prompt)
        {

            try
            {
                var url = "https://api.openai.com/v1/chat/completions";

                var requestBody = new
                {
                    model = "gpt-4",
                    messages = new[]
                    {
                    new { role = "system", content = "Eres un asistente útil." },
                    new { role = "user", content = prompt }
                    },
                    max_tokens = 500,
                    temperature = 0.2
                };

                var bodyJson = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(bodyJson, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                var responseString = await response.Content.ReadAsStringAsync();

                var responseJson = JsonSerializer.Deserialize<JsonElement>(responseString);
                string reply = responseJson.GetProperty("choices")[0]
                                           .GetProperty("message")
                                           .GetProperty("content")
                                           .GetString();

                return reply;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        internal async Task<string> SuggestTasks(string name, string description)
        {
            string prompt = $"Quiero generar un listado de tareas para un proyecto llamado '{name}'," +
                $"que tiene como descripcion '{description}'." +
                "Necesito que las tareas tengan " +
                "los siguientes elementos:Título, Descripción, Prioridad (1, 2, 3 siendo 1 la mas alta)" +
                "Además, por favor este listado mandalo como un solo string empezado por 'Tareas:' Y seguido escribes " +
                "cada tarea separada por un '/' y solo escribes el valor de cada elemento separado por un ';' " +
                " la lista mandala sin saltos de linea";


            return await IAReply(prompt);
        }
    }
}
