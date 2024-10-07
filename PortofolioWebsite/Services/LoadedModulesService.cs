using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using PortofolioWebsite.Models.Modules;

namespace PortofolioWebsite.Services
{
    /// <summary>
    /// Service to load modules from a JSON file from postgres.
    /// </summary>
    public class LoadedModulesService
    {
        private readonly string _filePath;

        public LoadedModulesService(string filePath)
        {
            _filePath = filePath;
        }

        /// <summary>
        /// Loads the loaded modules from a JSON file.
        /// </summary>
        /// <returns>A LoadedModulesModel instance containing a list of modules.</returns>
        public async Task<LoadedModulesModel> LoadModulesAsync()
        {
            if (!File.Exists(_filePath))
            {
                return new LoadedModulesModel(); // Return an empty list if the file doesn't exist
            }

            var json = await File.ReadAllTextAsync(_filePath);
            return JsonSerializer.Deserialize<LoadedModulesModel>(json);
        }
    }
}
