using PracticalTask.Models;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;
using PracticalTask.Services.Interfaces;
using System;
using System.Diagnostics;

namespace PracticalTask.Services.Implementations
{
    public class FactApiCaller : IFactApiCaller
    {
        private readonly WebClient Client;
        public FactApiCaller()
        {
            Client = new WebClient();
        }

        public async Task<FactModel> GetFactAsync()
        {
            var result = await Client.DownloadStringTaskAsync("https://catfact.ninja/fact");
            var fact = JsonConvert.DeserializeObject<FactModel>(result);
            
            return fact;
        }
    }
}
