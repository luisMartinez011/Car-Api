using Newtonsoft.Json.Linq;

namespace CarApi.Shared
{
    public class HttpClientRepository
    {
        private IHttpClientFactory _httpClientFactory;

        public HttpClientRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<T?>> GetAsync<T>(string url,string keyName, string apiKey)
        {
            var client = _httpClientFactory.CreateClient("HttpClient");
            
            
            client.DefaultRequestHeaders.Add(keyName, apiKey);

            var response = await client.GetAsync(url);
            if (!response.IsSuccessStatusCode)
                throw new Exception($"{response.StatusCode}: {response.ReasonPhrase}");
            var responseObject = await response.Content.ReadFromJsonAsync<List<T>>();
            return responseObject;
        }

        public async Task<List<T?>> GetAsync<T>(string url)
        {
            var client = _httpClientFactory.CreateClient("HttpClient");

            var response = await client.GetAsync(url);
            if (!response.IsSuccessStatusCode)
                throw new Exception($"{response.StatusCode}: {response.ReasonPhrase}");
            var responseObject = await response.Content.ReadFromJsonAsync<List<T>>();
            return responseObject;
        }

        //static async Task GetFromJsonAsync(HttpClient httpClient)
        //{
        //    var todos = await httpClient.GetFromJsonAsync<List<Todo>>(
        //        "todos?userId=1&completed=false");

        //    Console.WriteLine("GET https://jsonplaceholder.typicode.com/todos?userId=1&completed=false HTTP/1.1");
        //    todos?.ForEach(Console.WriteLine);
        //    Console.WriteLine();

        //}
    }
}
