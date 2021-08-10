using External.Finders.Query;
using External.Finders.Query.Interface;
using System.Threading.Tasks;

namespace DogFinder.Verb.Parser
{
    public class MultiImagesParser
    {
        public async Task<int> Parse(FileLocationVerb fileName)
        {
            IGetMultiImages getMultiImages = new GetMultiImages();
            var multiImages = await getMultiImages.ExecuteAsync();

            IFindMultiImagesQuery findDog = new FindMultiImagesQuery(multiImages);
            var multi = await findDog.ExecuteAsync(multiImages, fileName.Folder);

            return 0;
        }
    }
}
