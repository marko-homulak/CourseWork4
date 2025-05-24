using System.IO;
using System.Linq;
using System.Text.Json;
using System.Collections.Generic;

namespace BeeBearGUI
{
    public static class SimulationResultManager
    {
        private static readonly string Folder = "results";

        static SimulationResultManager()
        {
            if (!Directory.Exists(Folder))
                Directory.CreateDirectory(Folder);
        }

        public static void Save(SimulationResult result)
        {
            string filename = $"simulation_{result.Timestamp:yyyyMMdd_HHmmss}.json";
            string path = Path.Combine(Folder, filename);
            string json = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(path, json);
        }

        public static List<SimulationResult> LoadAll()
        {
            return Directory.GetFiles(Folder, "*.json")
                .Select(File.ReadAllText)
                .Select(json => JsonSerializer.Deserialize<SimulationResult>(json))
                .Where(r => r != null)
                .ToList();
        }

        public static List<string> GetResultFilenames()
        {
            return Directory.GetFiles(Folder, "*.json").ToList();
        }

        public static SimulationResult Load(string path)
        {
            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<SimulationResult>(json);
        }
    }
}
