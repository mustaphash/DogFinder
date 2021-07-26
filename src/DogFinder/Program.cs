using External.Finder.Query;
using External.Finders.Query.Interface;
using System;
using System.Net;

namespace DogFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            IGetRandomDogQuery dogFind = new GetRandomDogQuery();
            var dogs = dogFind.ExecuteAsync();


            string uniqueName = Guid.NewGuid().ToString();

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(dogs), $@"D:\Images\{uniqueName}.jpg");
            }
        }
    }
}
