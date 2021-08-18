using External.Finders.Query.Interface;
using Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace External.Finders.Query
{
    public class FindMultiImagesCommand : IFindMultiImagesCommand
    {
        public Task ExecuteAsync(MultiDogs getMulti, int count)
        {

            foreach (var dogs in getMulti.Message)
            {
                string uniqueName = Guid.NewGuid().ToString();
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri(dogs), $@"D:\git\{uniqueName}.jpg");
                    Console.WriteLine(getMulti.Status);
                }
            }
            return Task.FromResult(getMulti);
        }
    }
}
