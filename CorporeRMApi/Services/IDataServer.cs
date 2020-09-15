using CorporeRMApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CorporeRMApi.Data
{
    public interface IDataServer<T>
    {
        Task<T> GetAsync(string id);

        Task<IList<T>> GetAllAsync(int start = 0, int limit = 0, string filter = null);

        Task<T> CreateAsync(T model);

        Task<T> DeleteAsync(string id);

        Task<T> UpdateAsync(string id, T model);
        Task<T> UpdatePartialAsync(string id, object model);
        void SetAuthorization(string auth);


    }
}