using External.Finders.Query.Interface;
using Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace External.Finder.Query
{
    public class GetRandomDogQuery : IGetRandomDogQuery
    {
        private readonly Context _httpClientContext;

        public GetRandomDogQuery()
            : this(new Context())
        {
        }

        public GetRandomDogQuery(Context httpClientContext)
        {
            _httpClientContext = httpClientContext;
        }

        public async Task<Find> ExecuteAsync()
        {
            var httpClient = _httpClientContext.GetClient();
            HttpResponseMessage response = await httpClient.GetAsync($"https://dog.ceo/api/breeds/image/random");
            string content = await response.Content.ReadAsStringAsync();

            var finders = JsonConvert.DeserializeObject<Find>(content);

            return finders;
        }

    }
}
