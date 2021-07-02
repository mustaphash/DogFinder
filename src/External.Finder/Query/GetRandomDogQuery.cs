using External.Finder.Query.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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

        public async Task<Finder> ExecuteAsync(string townName)
        {
            var httpClient = _httpClientContext.GetClient();
            HttpResponseMessage response = await httpClient.GetAsync($"http://62.171.141.18/?fbclid=IwAR3YE74zv_w-pN6hJNNq5_oljKj3821fsXgupggehcRF2gZ9SmQX72L3sME");
            string content = await response.Content.ReadAsStringAsync();

            var places = JsonConvert.DeserializeObject<List<Place>>(content);
            List<> townLandmarks = places.Where(p => p.Address.Contains(townName)).ToList();

            return townLandmarks;
        }
    }
}
