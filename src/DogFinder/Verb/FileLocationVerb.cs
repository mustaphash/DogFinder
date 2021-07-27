using CommandLine;

namespace DogFinder.Verb
{
    [Verb("location", HelpText = "Select folder to save.")]
    public class FileLocationVerb
    {
        [Option('n', "name", Required = true, HelpText = "Folder to save.")]
        public string Name { get; set; }
    }
}
