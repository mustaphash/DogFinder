using Models;
using System.Threading.Tasks;

namespace External.Finders.Query.Interface
{
    public interface IFindMultiImagesQuery
    {
        Task ExecuteAsync(MultiDogs getMulti, string folder);
    }
}
