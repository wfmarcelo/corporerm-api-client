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
using Uniarp.Util;

namespace CorporeRMApi
{
    public class ProcessClient
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _accessor;
        private string _auth;

        public ProcessClient(HttpClient httpClient,
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

        public async Task<T> GetSchemaAsync<T>(string processName)
        {
            AddAuthorization();
            var response = await _httpClient.GetAsync($"rest/restprocess/getschema/{processName}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsJsonAsync<T>();
        }

        public async Task ExecuteProcessAsync(object model, string processName)
        {
            AddAuthorization();
            _httpClient.MaxResponseContentBufferSize = 2147483647;
            var response = await _httpClient.PostAsJsonAsync($"rest/restprocess/executeprocess/{processName}", model);
            await response.EnsureSuccessStatusCodeAsync();

            var retorno = await response.Content.ReadAsJsonAsync<string>();

            if (retorno != "1")
            {
                throw new SimpleHttpResponseException(System.Net.HttpStatusCode.BadRequest, retorno);
            }
        }
    }
}
