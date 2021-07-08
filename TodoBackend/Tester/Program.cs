using Newtonsoft.Json;
using SampleWebApi.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var listEntity = new ListEntity()
            {
                Name = "List1",
                List = new List<string> { "dsfs", "sadsad", "jiji" }
            };

            using (var client = new HttpClient())
            {
                var url = $"http://localhost:51255/api/todo/";

                var json = JsonConvert.SerializeObject(listEntity);
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");

                var response = client.PostAsync(url, stringContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    var getResponse = client.GetAsync($"{url}/List1").Result;
                    if (getResponse.IsSuccessStatusCode)
                    {
                        var result = getResponse.Content.ReadAsStringAsync();
                    }
                }
            }
        }
    }
}
