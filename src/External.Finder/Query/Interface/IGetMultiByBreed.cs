using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace External.Finders.Query.Interface
{
    public interface IGetMultiByBreed
    {
        Task<List<ByBreed>> ExecuteAsync(string fileName);
    }
}
