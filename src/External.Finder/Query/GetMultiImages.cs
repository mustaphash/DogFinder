using External.Finder;
using External.Finders.Query.Interface;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

        public async Task<List<MultiDogs>> ExecuteAsync()
        {
            //int numberOfImages = int.Parse(Console.ReadLine());
            var httpClient = _httpClientContext.GetClient();
            HttpResponseMessage response = await httpClient.GetAsync($"https://dog.ceo/api/breeds/image/random/3");
            string content = await response.Content.ReadAsStringAsync();

            List<MultiDogs> breeds = JsonConvert.DeserializeObject<List<MultiDogs>>(content);

            return breeds;
        }
    }
}
