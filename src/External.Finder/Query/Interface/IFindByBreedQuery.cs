using Models;
using System.Threading.Tasks;

namespace External.Finders.Query.Interface
{
    public interface IFindByBreedQuery
    {
        Task<ByBreed> ExecuteAsync(ByBreed getMulti, string fileName);
    }
}
