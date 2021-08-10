using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace External.Finders.Query.Interface
{
    public interface IGetMultiImages
    {
        Task<List<MultiDogs>> ExecuteAsync();
    }
}
