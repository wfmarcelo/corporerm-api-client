using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace CorporeRMApi.Models
{
    public class Auth
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public string GetAuthenticationHeader()
        {
            return Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Login}:{Senha}"));
        }
    }


    public class AuthResult
    {
        public bool Succeeded { get; set; }
    }
}
