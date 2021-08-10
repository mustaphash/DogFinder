using CommandLine;

namespace DogFinder.Verb
{
    [Verb("location", HelpText = "Select folder to save.")]
    public class FileLocationVerb
    {
        [Option('f', "folder", Required = true, HelpText = "Folder to save.")]
        public string Folder { get; set; }

        [Option('c', "imageCount", Required = true, HelpText = "Folder to save.")]
        public string ImageCount { get; set; }
    }
}
