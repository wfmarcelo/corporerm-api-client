using System.Collections.Generic;
using System.Threading.Tasks;
using CorporeRMApi.Data;
using CorporeRMApi.Models;

namespace CorporeRMApi.DataServer
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

        public virtual async Task<DataServerResult<T>> CreateAsync(object model)
        {
            return await _api.CreateAsync<T>(model, _dataServerName);
        }

        public virtual async Task<DataServerResult<T>> DeleteAsync(string id)
        {
            return await _api.DeleteAsync<T>(id, _dataServerName);
        }

        public virtual async Task<DataServerResult<IList<T>>> GetAllAsync(IList<string> filter, int start = 0, int limit = 0)
        {
            return await _api.GetAllAsync<IList<T>>(start, limit, filter, _dataServerName);
        }

        public virtual async Task<DataServerResult<T>> GetAsync(string id)
        {
            return await _api.GetAsync<T>(id, _dataServerName);
        }

        public virtual async Task<DataServerResult<T>> UpdateAsync(string id, object model)
        {
            return await _api.PutAsync<T>(id, model, _dataServerName);
        }

        public virtual async Task<DataServerResult<T>> UpdatePartialAsync(string id, object model)
        {
            return await _api.PatchAsync<T>(id, model, _dataServerName);
        }

        public virtual void SetContexto(Contexto contexto)
        {
            _api.SetContexto(contexto);
        }
    }
}