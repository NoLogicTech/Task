using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskUltimate.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace TaskUltimate.App.Services
{
    public class ApiProjeto
    {
        private HttpClient _httpClient;
        public ApiProjeto(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<Projeto>> GetAsync()
        {
            var result = await _httpClient.GetAsync("api/projeto");
            using var responseStream = await result.Content.ReadAsStreamAsync();
            var options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            return await JsonSerializer.DeserializeAsync<List<Projeto>>(responseStream, options);
        }

        public async Task<Projeto> GetForIdAsync(int id)
        {
            var result = await _httpClient.GetAsync($"api/projeto/{id}");
            using var responseStream = await result.Content.ReadAsStreamAsync();

            var options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            return await JsonSerializer.DeserializeAsync<Projeto>(responseStream, options);
        }
        public async Task PutAsync(int id, Projeto value)
        {
            await _httpClient.PutAsJsonAsync<Projeto>($"api/projeto/{id}", value);
        }

        public async Task Post(Projeto value)
        {
            await _httpClient.PostAsJsonAsync<Projeto>("api/tarefas/", value);
        }

        public async Task Delete(int id)
        {
            await _httpClient.DeleteAsync($"api/projeto/{id}");
        }
    }
}
