using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace TaskUltimate.Server.Services
{
    public class Apiservice
    {
        private static HttpClient _httpClient;

        public ApiTarefa apiTarefa;
        public ApiProjeto apiProjeto;
        public Apiservice(HttpClient client)
        {
            _httpClient = client;
            apiProjeto = new ApiProjeto(_httpClient);
            apiTarefa = new ApiTarefa(_httpClient);
        }
        
    }
}
