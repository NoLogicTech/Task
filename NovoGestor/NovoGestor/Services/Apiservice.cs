using System.Collections.Generic;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using NovoGestor.Model;

namespace NovoGestor.Services
{
    public class ApiService
    {
        public HttpClient _httpClient;
        public ApiService(HttpClient client)
        {
            _httpClient = client;
        }
        public async Task<List<Tarefa>> GetTarefaAsync()
        {
            var result = await _httpClient.GetAsync("api/tarefas");
            using var responseStream = await result.Content.ReadAsStreamAsync();
            var options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            return await JsonSerializer.DeserializeAsync<List<Tarefa>>(responseStream, options);
        }
        public async Task<Tarefa> GetTarefaPorIdAsync(int id)
        {
            var result = await _httpClient.GetAsync($"api/tarefas/{id}");
            using var responseStream = await result.Content.ReadAsStreamAsync();

            var options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            return await JsonSerializer.DeserializeAsync<Tarefa>(responseStream, options);
        }

        /* envia dados para a api */
        /* precisa ser construido ainda */
        public async Task<List<Tarefa>> PutTarefaAsync()
        {
            var response = await _httpClient.GetAsync("api/tarefas/");
            response.EnsureSuccessStatusCode();
            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<Tarefa>>(responseContent);
        }

    }
}