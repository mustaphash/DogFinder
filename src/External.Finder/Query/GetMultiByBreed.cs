﻿using External.Finder;
using External.Finders.Query.Interface;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace External.Finders.Query
{
    public class GetMultiByBreed : IGetMultiByBreed
    {
        private readonly Context _httpClientContext;

        public GetMultiByBreed()
            : this(new Context())
        {
        }

        public GetMultiByBreed(Context httpClientContext)
        {
            _httpClientContext = httpClientContext;
        }

        public async Task<List<ByBreed>> ExecuteAsync(string getMulti)
        {
            int numberOfImages = int.Parse(Console.ReadLine());
            var httpClient = _httpClientContext.GetClient();
            HttpResponseMessage response = await httpClient.GetAsync($"https://dog.ceo/api/breeds/image/random/{numberOfImages}");
            string content = await response.Content.ReadAsStringAsync();

            var breeds = JsonConvert.DeserializeObject<List<ByBreed>>(content);
            List<ByBreed> byBreeds = breeds.Where(p => p.Message.Contains(getMulti)).ToList();

            return byBreeds;
        }

    }
}
