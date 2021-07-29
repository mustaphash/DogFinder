using External.Finder.Query;
using External.Finders.Query;
using External.Finders.Query.Interface;
using System.Threading.Tasks;

namespace DogFinder.Verb.Parser
{
    public class RandomDogParser
    {
        public async Task<int> Parse(FileLocationVerb fileName)
        {
            IGetRandomDogQuery getDog = new GetRandomDogQuery();
            var dogs = await getDog.ExecuteAsync();

            IFindDogQuery findDog = new FindDogQuery();
            var dog = await findDog.ExecuteAsync(dogs,fileName.Name);

            return 0;
        }

    }
}
