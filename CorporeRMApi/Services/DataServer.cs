using System.Collections.Generic;
using System.Threading.Tasks;
using CorporeRMApi.Data;

namespace CorporeRMApi.Services
{
    public class DataServer<T> : IDataServer<T>
    {
        private readonly CorporeRMApiClient _api;
        private readonly string _dataServerName;

        public DataServer(CorporeRMApiClient corporeRMApiClient, string dataServerName)
        {
            _api = corporeRMApiClient;
            _dataServerName = dataServerName;
        }

        public void SetAuthorization(string auth)
        {
            _api.SetAuthorization(auth);
        }

        public async Task<T> CreateAsync(T model)
        {
            return await _api.CreateAsync(model, _dataServerName);
        }

        public async Task<T> DeleteAsync(string id)
        {
            return await _api.DeleteAsync<T>(id, _dataServerName);
        }

        public async Task<IList<T>> GetAllAsync(int start = 0, int limit = 0, string filter = null)
        {
            return await _api.GetAllAsync<IList<T>>(start, limit, filter, _dataServerName);
        }

        public async Task<T> GetAsync(string id)
        {
            return await _api.GetAsync<T>(id, _dataServerName);
        }

        public async Task<T> UpdateAsync(string id, T model)
        {
            return await _api.PutAsync(id, model, _dataServerName);
        }

        public async Task<T> UpdatePartialAsync(string id, object model)
        {
            return await _api.PatchAsync<T>(id, model, _dataServerName);
        }
    }
}