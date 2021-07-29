using DogFinder.Verb;
using External.Finder;
using External.Finders.Query.Interface;
using Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace External.Finders.Query
{

    public class FindDogQuery : IFindDogQuery
    {
        private readonly Context _httpClientContext;

        public FindDogQuery()
            : this(new Context())
        {
        }

        public FindDogQuery(Context httpClientContext)
        {
            _httpClientContext = httpClientContext;
        }

        public async Task<Find> ExecuteAsync(Find getDog,string fileName)
        {
            string uniqueName = Guid.NewGuid().ToString();

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(getDog.Message), $@"{fileName}\{uniqueName}.jpg");
                Console.WriteLine(getDog.Status);
            }
            return 0;
            
        }
    }
}
