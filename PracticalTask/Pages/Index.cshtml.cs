using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticalTask.Models;
using PracticalTask.Repository;

namespace PracticalTask.Pages
{
    public class IndexModel : PageModel
    {
        public FactModel FactModel;
        public List<FactModel> Facts;

        private readonly IFactsRepository factsRepository;
        public IndexModel(IFactsRepository factsRepository)
        {
            this.factsRepository = factsRepository;
        }
        
        public async Task OnGetAsync()
        {
            FactModel = await factsRepository.GetFactAsync();
            Facts = FactsRepository.Facts;
        }
    }
}
