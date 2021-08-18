using Models;
using System.Threading.Tasks;

namespace External.Finders.Query.Interface
{
    public interface IFindMultiImagesCommand
    {
        Task ExecuteAsync(MultiDogs getMulti, int count);
    }
}
