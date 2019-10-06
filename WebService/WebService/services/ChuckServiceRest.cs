using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebService.bo;

namespace WebService.services
{
    class ChuckServiceRest : ChuckService
    {
        async public Task<List<Joke>> GetJokes()
        {
            var client = new System.Net.Http.HttpClient();
            var result = await client.GetStringAsync(new Uri("https://api.chucknorris.io/jokes/random"));
            Console.WriteLine(result);
            var jokes = JsonConvert.DeserializeObject<List<Joke>>("["+result+"]");
            //client.Dispose();
            return jokes;
        }
    }
}
