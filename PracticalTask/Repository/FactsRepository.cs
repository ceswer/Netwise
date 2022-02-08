using PracticalTask.Models;
using PracticalTask.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticalTask.Repository
{
    public class FactsRepository : IFactsRepository
    {
        public static List<FactModel> Facts = new List<FactModel>();
     
        private readonly IFileService fileService;
        private readonly IFactApiCaller factApiCaller;
        public FactsRepository(IFileService fileService, IFactApiCaller factApiCaller)
        {
            this.factApiCaller = factApiCaller;
            this.fileService = fileService;
        }

        public async Task<FactModel> GetFactAsync()
        {
            var fact = await factApiCaller.GetFactAsync();

            Facts.Add(fact);
            await fileService.WriteFactToFileAsync(fact);

            return fact;
        }
    }
}
