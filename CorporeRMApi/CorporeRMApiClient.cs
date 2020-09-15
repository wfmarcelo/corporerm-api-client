using CorporeRMApi.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Uniarp.Extensions;

namespace CorporeRMApi
{
    public class CorporeRMApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _accessor;
        private string _auth;

        public CorporeRMApiClient(HttpClient httpClient,
            IHttpContextAccessor accessor)
        {
            _httpClient = httpClient;
            _accessor = accessor;
        }


        public void SetAuthorization(string auth)
        {
            _auth = auth;
        }

        public void AddAuthorization(string auth)
        {
            var authorization = new AuthenticationHeaderValue("Basic", auth);
            _httpClient.DefaultRequestHeaders.Authorization = authorization;
        }

        private void AddAuthorization()
        {
            string auth;

            if (_accessor.HttpContext == null)
            {
                auth = _auth;
            }
            else
            {
                if (_accessor.HttpContext.User.Claims.Any() == false)
                {
                    auth = _auth;
                }
                else
                {
                    auth = _accessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type == "authenticationHeader").Value;
                }

                if (auth == null)
                {
                    throw new ArgumentException("Token não foi salvo");
                }
            }


            AddAuthorization(auth);
        }

        public async Task<AuthResult> LoginAsync(Auth model)
        {

            AddAuthorization(model.GetAuthenticationHeader());

            var response = await _httpClient.GetAsync("service/educacional");

            return new AuthResult
            {
                Succeeded = response.IsSuccessStatusCode
            };
        }

        public async Task<List<Service>> GetAvailableServicesAsync()
        {
            AddAuthorization();
            var response = await _httpClient.GetAsync("getavailableservices");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsJsonAsync<List<Service>>();
        }

        public async Task<T> GetAsync<T>(string id, string dataServerName)
        {
            AddAuthorization();
            var response = await _httpClient.GetAsync($"rest/{dataServerName}/{id}");
            await response.EnsureSuccessStatusCodeAsync();

            var dataServerResult = await response.Content.ReadAsJsonAsync<DataServerResult<T>>();

            return dataServerResult.Data;
        }

        public async Task<T> GetAllAsync<T>(int start, int limit, string filter, string dataServerName)
        {
            AddAuthorization();
            var response = await _httpClient.GetAsync($"rest/{dataServerName}?start={start}&limit={limit}&filter={filter}");
            await response.EnsureSuccessStatusCodeAsync();

            var dataServerResult = await response.Content.ReadAsJsonAsync<DataServerResult<T>>();



            return dataServerResult.Data;
        }

        public async Task<T> DeleteAsync<T>(string id, string dataServerName)
        {
            AddAuthorization();
            var response = await _httpClient.DeleteAsync($"rest/{dataServerName}/{id}");
            await response.EnsureSuccessStatusCodeAsync();

            var dataServerResult = await response.Content.ReadAsJsonAsync<DataServerResult<T>>();

            return dataServerResult.Data;
        }

        public async Task<T> CreateAsync<T>(T model, string dataServerName)
        {
            AddAuthorization();
            var response = await _httpClient.PostAsJsonAsync($"rest/{dataServerName}", model);
            await response.EnsureSuccessStatusCodeAsync();

            var dataServerResult = await response.Content.ReadAsJsonAsync<DataServerResult<T>>();

            return dataServerResult.Data;
        }

        public async Task<T> PutAsync<T>(string id, T model, string dataServerName)
        {
            AddAuthorization();
            var response = await _httpClient.PutAsJsonAsync($"rest/{dataServerName}/{id}", model);
            await response.EnsureSuccessStatusCodeAsync();

            var dataServerResult = await response.Content.ReadAsJsonAsync<DataServerResult<T>>();

            return dataServerResult.Data;
        }

        public async Task<T> PatchAsync<T>(string id, object model, string dataServerName)
        {
            AddAuthorization();
            var response = await _httpClient.PatchAsJsonAsync($"rest/{dataServerName}/{id}", model);
            await response.EnsureSuccessStatusCodeAsync();

            var dataServerResult = await response.Content.ReadAsJsonAsync<DataServerResult<T>>();

            return dataServerResult.Data;
        }

    }
}
