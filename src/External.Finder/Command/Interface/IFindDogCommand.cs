using Models;
using System.Threading.Tasks;

namespace External.Finders.Query.Interface
{
    public interface IFindDogCommand
    {
        Task<Find> ExecuteAsync(Find getDog, string fileName);
    }
}
