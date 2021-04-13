using CorporeRMApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CorporeRMApi.Data
{
    public interface IDataServer<T>
    {
        Task<DataServerResult<T>> GetAsync(string id);

        Task<DataServerResult<IList<T>>> GetAllAsync(IList<string> filter, int start = 0, int limit = 0);

        Task<DataServerResult<T>> CreateAsync(object model);

        Task<DataServerResult<T>> DeleteAsync(string id);

        Task<DataServerResult<T>> UpdateAsync(string id, object model);
        Task<DataServerResult<T>> UpdatePartialAsync(string id, object model);
        void SetAuthorization(string auth);
        void SetContexto(Contexto contexto);


    }
}