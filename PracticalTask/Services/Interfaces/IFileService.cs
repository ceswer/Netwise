using PracticalTask.Models;
using System.Threading.Tasks;

namespace PracticalTask.Services.Interfaces
{
    public interface IFileService
    {
        Task WriteFactToFileAsync(FactModel fact);
        Task OverwriteFileAsync();
    }
}
