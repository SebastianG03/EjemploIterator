
using EjemploIterator.Domain.Iterator;
using System.Text.Json;

namespace EjemploIterator.Domain.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private static ApiService? instance;
        private readonly string _url = "https://itemscollection20240123185859.azurewebsites.net/api/Item";

        private ApiService() { }

        public static ApiService Singleton()
        {
            if (instance == null)
            {
                instance = new ApiService();
            }
            return instance;
        }

        public async Task<List<Item>> GetItems()
        {
            try
            {

                HttpResponseMessage response = await _httpClient.GetAsync(_url);
                response.EnsureSuccessStatusCode();

                var jsonOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true, // Ignora mayúsculas y minúsculas
                };

                var jsonStream = await response.Content.ReadAsStreamAsync();
                var res = await JsonSerializer.DeserializeAsync<List<Item>>(jsonStream, jsonOptions);

                Console.WriteLine(res);
                return res!;
            } catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
