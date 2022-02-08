using PracticalTask.Models;
using PracticalTask.Repository;
using PracticalTask.Services.Interfaces;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace PracticalTask.Services.Implementations
{
    public class FileService : IFileService
    {
        public readonly static string FactsFileName = "Data/Facts.txt";

        public static void ReadFactsFromFile()
        {
            var fileInfo = new FileInfo(FactsFileName);

            if (fileInfo.Exists)
            {
                using var streamReader = new StreamReader(fileInfo.OpenRead());

                string line;
                while (null != (line = streamReader.ReadLine()))
                {
                    string[] properties = line.Split("\t");

                    var fact = new FactModel()
                    {
                        Fact = properties[0],
                        Length = int.Parse(properties[1])
                    };

                    FactsRepository.Facts.Add(fact);
                }
            }
        }

        // Overwritting is a time-consuming thing if list of facts is huge.
        public async Task OverwriteFileAsync()
        {
            using var streamWriter = new StreamWriter(FactsFileName);
            foreach (FactModel fact in FactsRepository.Facts)
                await streamWriter.WriteLineAsync(fact.ToString());
        }

        public async Task WriteFactToFileAsync(FactModel fact)
        {
            using var streamWriter = new StreamWriter(FactsFileName, true);
            await streamWriter.WriteLineAsync(fact.ToString());
        }
    }
}
