using CommandLine;
using DogFinder.Verb;
using DogFinder.Verb.Parser;
using System.Collections.Generic;

namespace DogFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<FileLocationVerb,ImageCountVerb>(args)
                .MapResult(
                  (FileLocationVerb opts) => new RandomDogParser().Parse(opts).GetAwaiter().GetResult(),
                  (ImageCountVerb opts) => new MultiImagesParser().Parse(opts).GetAwaiter().GetResult(),
                  (IEnumerable < Error > errs) => new ExeptionParser().ExceptionHandling(errs).GetAwaiter().GetResult());
        }
    }
}
