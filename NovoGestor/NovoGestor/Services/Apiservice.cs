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
            var response = await _httpClient.GetAsync("api/tarefas");
            response.EnsureSuccessStatusCode();
            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<Tarefa>>(responseContent);
        }
        public async Task<Tarefa> GetTarefaPorIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/tarefas/{id}");
            response.EnsureSuccessStatusCode();
            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<Tarefa>(responseContent);
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