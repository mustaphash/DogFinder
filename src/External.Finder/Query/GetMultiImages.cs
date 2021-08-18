using External.Finder;
using External.Finders.Query.Interface;
using Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace External.Finders.Query
{
    public class GetMultiImages : IGetMultiImages
    {
        private readonly Context _httpClientContext;

        public GetMultiImages()
            : this(new Context())
        {
        }

        public GetMultiImages(Context httpClientContext)
        {
            _httpClientContext = httpClientContext;
        }

        public async Task<MultiDogs> ExecuteAsync(int numberOfImages)
        {
            var httpClient = _httpClientContext.GetClient();
            HttpResponseMessage response = await httpClient.GetAsync($"https://dog.ceo/api/breeds/image/random/{numberOfImages}");
            string content = await response.Content.ReadAsStringAsync();

            MultiDogs breeds = JsonConvert.DeserializeObject<MultiDogs>(content);

            return breeds;
        }
    }
}
