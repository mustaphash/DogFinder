using External.Finders.Query.Interface;
using Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace External.Finders.Query
{

    public class FindDogCommand : IFindDogCommand
    {
        public  Task<Find> ExecuteAsync(Find getDog, string folder)
        {
            string uniqueName = Guid.NewGuid().ToString();

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(getDog.Message), $@"{folder}\{uniqueName}.jpg");
                Console.WriteLine(getDog.Status);
            }
            return Task.FromResult(getDog);
        }
    }
}
