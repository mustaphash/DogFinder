using External.Finder.Query;
using External.Finders.Query.Interface;
using System;
using System.Net;
using System.Threading.Tasks;

namespace DogFinder.Verb.Parser
{
    public class RandomDogParser
    {
        public async Task<int> Parse(FileLocationVerb fileName)
        {
            IGetRandomDogQuery getDog = new GetRandomDogQuery();
            var dogs = await getDog.ExecuteAsync();

            string uniqueName = Guid.NewGuid().ToString();

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(dogs.Message), $@"{fileName.Name}\{uniqueName}.jpg");
                Console.WriteLine(dogs.Status);
            }
            return 0;
        }

    }
}
