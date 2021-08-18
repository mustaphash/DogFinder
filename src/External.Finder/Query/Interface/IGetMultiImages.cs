using Models;
using System.Threading.Tasks;

namespace External.Finders.Query.Interface
{
    public interface IGetMultiImages
    {
        Task<MultiDogs> ExecuteAsync(int numberOfImages);
    }
}
