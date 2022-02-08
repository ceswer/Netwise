using PracticalTask.Models;
using System.Threading.Tasks;

namespace PracticalTask.Repository
{
    public interface IFactsRepository
    {
        Task<FactModel> GetFactAsync();
    }
}
