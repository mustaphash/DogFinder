using External.Finders.Query;
using External.Finders.Query.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogFinder.Verb.Parser
{
    public class ByBreedParser
    {
        public async Task<int> Parse(FileLocationVerb fileName)
        {
            IGetMultiByBreed getBreed = new GetMultiByBreed();
            var byBreeds = await getBreed.ExecuteAsync();

            IFindDogQuery findDog = new FindDogQuery();
            var multi = await findDog.ExecuteAsync(byBreeds, fileName.Name);

            return 0;
        }
    }
}
