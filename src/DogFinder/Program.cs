using External.Finder.Query;
using External.Finders.Query.Interface;
using System;
using System.Net;
using System.Threading.Tasks;

namespace DogFinder
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IGetRandomDogQuery getDog = new GetRandomDogQuery();
            var dogs = await getDog.ExecuteAsync();

            string uniqueName = Guid.NewGuid().ToString();

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(dogs.Message), $@"D:\Images\{uniqueName}.jpg");
                Console.WriteLine(dogs.Status);
            }
        }
    }
}
