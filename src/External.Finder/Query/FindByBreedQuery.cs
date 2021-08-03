using External.Finder;
using External.Finders.Query.Interface;
using Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace External.Finders.Query
{
    class FindByBreedQuery:IFindByBreedQuery
    {
        private readonly Context _httpClientContext;

        public FindByBreedQuery()
            : this(new Context())
        {
        }

        public FindByBreedQuery(Context httpClientContext)
        {
            _httpClientContext = httpClientContext;
        }

        public async Task<ByBreed> ExecuteAsync(ByBreed getMulti, string fileName)
        {
            IGetMultiByBreed getBreeds = new GetMultiByBreed();
            var breed = getBreeds.ExecuteAsync();
            string uniqueName = Guid.NewGuid().ToString();

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(getMulti.Message), $@"{fileName}\{uniqueName}.jpg");
                Console.WriteLine(getMulti.Status);
            }
            return getMulti;
        }
    }
}
