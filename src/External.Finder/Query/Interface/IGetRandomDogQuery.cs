using Models;
using System.Threading.Tasks;

namespace External.Finders.Query.Interface
{
    public interface IGetRandomDogQuery
    {
        Task<Find> ExecuteAsync();
    }
}
