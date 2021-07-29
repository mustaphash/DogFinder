using Models;
using System.Threading.Tasks;

namespace External.Finders.Query.Interface
{
    public interface IFindDogQuery
    {
        Task<Find> ExecuteAsync(Find getDog, string fileName);
    }
}
