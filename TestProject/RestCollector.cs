using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class RestCollector
    {
        public static async void Collector()
        {
            HttpClient _client = new();
            List<string> responseStrings = new();
            for (int i = 0; i < 30; i++)
            {
                HttpRequestMessage _httpRequest = new(
                    HttpMethod.Get, $"https://somesite.com/api/somemethod/?page={i}"
                    );

                HttpResponseMessage responseMessage = await _client.SendAsync(_httpRequest);
                string response = await responseMessage.Content.ReadAsStringAsync();
                responseStrings.Add(response);
            }


        }
    }
}
