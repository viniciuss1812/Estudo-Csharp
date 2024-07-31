using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTApi.Services
{
    public class Client
    {  protected readonly HttpClient httpClient = new HttpClient();
        public readonly string _baseurl = "https://api.openai.com/v1/chat";
        public async Task<string> GptRequest(string Authorization, string Request)
        {
            try
            {
                httpClient.DefaultRequestHeaders.Add(nameof(Authorization), $"Bearer{Authorization}");
                var requestbdpy = new {
                   
                  model = "gpt-4",
                  messages = new[]
                  {
                      new {role = "system", content = "Você é um Assistente"},
                      new {role = "User", content = Request},

                  },
                  max_tokens = 1000,
                  temperature = 0.5
                };
                var httpContent = new StringContent(JsonConvert.SerializeObject(requestbdpy), Encoding.UTF8, "application/json" );
                var response = await httpClient.PostAsync($"{_baseurl}/completetions", httpContent);
                return await response.Content.ReadAsStringAsync();  
            }
            catch (Exception)
            { 
               throw; 
            }
          
        }
    }
}
