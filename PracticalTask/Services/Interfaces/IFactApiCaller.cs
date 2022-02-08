using PracticalTask.Models;
using System.Threading.Tasks;

namespace PracticalTask.Services.Interfaces
{
    public interface IFactApiCaller
    {
        Task<FactModel> GetFactAsync();
    }
}
