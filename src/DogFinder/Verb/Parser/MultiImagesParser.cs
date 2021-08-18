using External.Finders.Query;
using External.Finders.Query.Interface;
using System.Threading.Tasks;

namespace DogFinder.Verb.Parser
{
    public class MultiImagesParser
    {
        public async Task<int> Parse(ImageCountVerb imageCount)
        {
            IGetMultiImages getMultiImages = new GetMultiImages();
            var multiImages = await getMultiImages.ExecuteAsync(imageCount.ImageCount);
           
            IFindMultiImagesCommand findDog = new FindMultiImagesCommand();
            await findDog.ExecuteAsync(multiImages, imageCount.ImageCount);
            
            return 0;
        }
    }
}
