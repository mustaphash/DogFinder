using CommandLine;

namespace DogFinder.Verb
{
    [Verb("image", HelpText = "Select image count to save.")]
    public class ImageCountVerb
    {
        [Option('c', "count", Required = true, HelpText = "Images to save.")]
        public int ImageCount { get; set; }
    }
}
