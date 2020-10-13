using System.Collections.Generic;
using System.Threading.Tasks;
using CorporeRMApi.Data;
using CorporeRMApi.Models;

namespace CorporeRMApi.Processes
{
    public class Process<T> : IProcess<T>
    {
        private readonly ProcessClient _api;
        private readonly string _processName;

        public Process(ProcessClient processClient, string processName)
        {
            _api = processClient;
            _processName = processName;
        }

        public async Task ExecuteProcessAsync(object model)
        {
            await _api.ExecuteProcessAsync(model, _processName);
        }

        public Task<T> GetSchemaAsync()
        {
            throw new System.NotImplementedException();
        }

        public void SetAuthorization(string auth)
        {
            _api.SetAuthorization(auth);
        }

    }
}