using External.Finder;
using External.Finders.Query.Interface;
using Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace External.Finders.Query
{
    public class FindMultiImagesQuery : IFindMultiImagesQuery
    {
        private readonly Context _httpClientContext;

        public FindMultiImagesQuery()
            : this(new Context())
        {
        }

        public FindMultiImagesQuery(Context httpClientContext)
        {
            _httpClientContext = httpClientContext;
        }

        public async Task ExecuteAsync(MultiDogs getMulti, string folder)
        {
            string uniqueName = Guid.NewGuid().ToString();

            foreach (var dogs in getMulti.Message)
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri(dogs), $@"{folder}\{uniqueName}.jpg");
                    Console.WriteLine(getMulti.Status);
                }
            }
        }
    }
}
