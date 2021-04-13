using CorporeRMApi.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
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

        public void SetContexto(Contexto contexto)
        {
            _httpClient.DefaultRequestHeaders.Add("CodColigada", contexto.CodColigada.ToString());
            _httpClient.DefaultRequestHeaders.Add("CodUsuario", contexto.CodUsuario);
            _httpClient.DefaultRequestHeaders.Add("DataSistema", contexto.DataSistema.ToString());
            _httpClient.DefaultRequestHeaders.Add("CodUsuarioServico", contexto.CodUsuarioServico);
            _httpClient.DefaultRequestHeaders.Add("CodFilial", contexto.CodFilial.ToString());
            _httpClient.DefaultRequestHeaders.Add("IdPrj", contexto.IdPrj.ToString());
            _httpClient.DefaultRequestHeaders.Add("CodTipoCurso", contexto.CodTipoCurso.ToString());
            _httpClient.DefaultRequestHeaders.Add("CodUnidadeBib", contexto.CodUnidadeBib.ToString());
            _httpClient.DefaultRequestHeaders.Add("CodLocPrt", contexto.CodLocPrt.ToString());
            _httpClient.DefaultRequestHeaders.Add("EduTipoUsr", contexto.EduTipoUsr);
            _httpClient.DefaultRequestHeaders.Add("RhTipoUsr", contexto.RhTipoUsr);
            _httpClient.DefaultRequestHeaders.Add("ChapaFuncionario", contexto.ChapaFuncionario);
            _httpClient.DefaultRequestHeaders.Add("CodigoExterno", contexto.CodigoExterno);
            _httpClient.DefaultRequestHeaders.Add("ExercicioFiscal", contexto.ExercicioFiscal);
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

            var response = await _httpClient.GetAsync("RMSRestDataServer/getavailableservices");

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

        public async Task<DataServerResult<T>> GetAsync<T>(string id, string dataServerName)
        {
            AddAuthorization();
            var response = await _httpClient.GetAsync($"RMSRestDataServer/rest/{dataServerName}/{id}");
            await response.EnsureSuccessStatusCodeAsync();

            var dataServerResult = await response.Content.ReadAsJsonAsync<DataServerResult<T>>();

            return dataServerResult;
        }

        public async Task<DataServerResult<T>> GetAllAsync<T>(int start, int limit, IList<string> filter, string dataServerName)
        {
            AddAuthorization();
            var response = await _httpClient.GetAsync($"RMSRestDataServer/rest/{dataServerName}?start={start}&limit={limit}&filter={JsonSerializer.Serialize(filter)}");
            await response.EnsureSuccessStatusCodeAsync();

            var dataServerResult = await response.Content.ReadAsJsonAsync<DataServerResult<T>>();



            return dataServerResult;
        }

        public async Task<DataServerResult<T>> DeleteAsync<T>(string id, string dataServerName)
        {
            AddAuthorization();
            var response = await _httpClient.DeleteAsync($"RMSRestDataServer/rest/{dataServerName}/{id}");
            await response.EnsureSuccessStatusCodeAsync();

            var dataServerResult = await response.Content.ReadAsJsonAsync<DataServerResult<T>>();

            return dataServerResult;
        }

        public async Task<DataServerResult<T>> CreateAsync<T>(object model, string dataServerName)
        {
            AddAuthorization();
            var response = await _httpClient.PostAsJsonAsync($"RMSRestDataServer/rest/{dataServerName}", model);
            await response.EnsureSuccessStatusCodeAsync();

            var dataServerResult = await response.Content.ReadAsJsonAsync<DataServerResult<T>>();

            return dataServerResult;
        }

        public async Task<DataServerResult<T>> PutAsync<T>(string id, object model, string dataServerName)
        {
            AddAuthorization();
            var response = await _httpClient.PutAsJsonAsync($"RMSRestDataServer/rest/{dataServerName}/{id}", model);
            await response.EnsureSuccessStatusCodeAsync();

            var dataServerResult = await response.Content.ReadAsJsonAsync<DataServerResult<T>>();

            return dataServerResult;
        }

        public async Task<DataServerResult<T>> PatchAsync<T>(string id, object model, string dataServerName)
        {
            AddAuthorization();
            var response = await _httpClient.PatchAsJsonAsync($"RMSRestDataServer/rest/{dataServerName}/{id}", model);
            await response.EnsureSuccessStatusCodeAsync();

            var dataServerResult = await response.Content.ReadAsJsonAsync<DataServerResult<T>>();

            return dataServerResult;
        }

    }
}
