using Newtonsoft.Json;
using NuGet.DependencyResolver;

namespace CarApi.Shared
{
    public interface IReadAndParseJson
    {
        List<T> ReadJson<T>();
    }

    public class ReadAndParseJson : IReadAndParseJson
    {
        private string filePath;

        public ReadAndParseJson(string _filePath)
        {
            filePath= _filePath;
        }

        public List<T> ReadJson<T>()
        {
            using StreamReader reader = new(filePath);
            var json = reader.ReadToEnd();
            List<T> listJson = JsonConvert.DeserializeObject<List<T>>(json);
            return listJson;
        }
    }
}
