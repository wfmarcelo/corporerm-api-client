using CorporeRMApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CorporeRMApi.Processes
{
    public interface IProcess<T>
    {
        Task<T> GetSchemaAsync();
        Task ExecuteProcessAsync(object model);
        void SetAuthorization(string auth);

    }
}