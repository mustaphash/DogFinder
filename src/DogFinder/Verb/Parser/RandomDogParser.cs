using External.Finder.Query;
using External.Finders.Query;
using External.Finders.Query.Interface;
using System.Threading.Tasks;

namespace DogFinder.Verb.Parser
{
    public class RandomDogParser
    {
        public async Task<int> Parse(FileLocationVerb folder)
        {
            IGetRandomDogQuery getDog = new GetRandomDogQuery();
            var dogs = await getDog.ExecuteAsync();

            IFindDogCommand findDog = new FindDogCommand();
            var dog = await findDog.ExecuteAsync(dogs,folder.Folder);

            return 0;
        }

    }
}
