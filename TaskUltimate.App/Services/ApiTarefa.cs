using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskUltimate.Models;
using System.Net.Http.Json; 
using System.Net.Http;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskUltimate.App.Services
{

    public class ApiTarefa
    {
        public HttpClient _httpClient;
        public ApiTarefa(HttpClient client)
        {
            _httpClient = client;
        }
        public async Task<List<Tarefa>> GetAsync()
        {
            var result = await _httpClient.GetAsync("api/tarefas/");
            using var responseStream = await result.Content.ReadAsStreamAsync();
            var options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            return await JsonSerializer.DeserializeAsync<List<Tarefa>>(responseStream, options);
        }
        public async Task<Tarefa> GetForIdAsync(int id)
        {
            var result = await _httpClient.GetAsync($"api/tarefas/{id}");
            using var responseStream = await result.Content.ReadAsStreamAsync();

            var options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            return await JsonSerializer.DeserializeAsync<Tarefa>(responseStream, options);
        }

        public async Task<List<Tarefa>> GetForProjectIdAsync(int id)
        {
            var result = await _httpClient.GetAsync($"api/tarefas/projeto/{id}");
            using var responseStream = await result.Content.ReadAsStreamAsync();

            var options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            return await JsonSerializer.DeserializeAsync<List<Tarefa>>(responseStream, options);
        }

        public async Task<List<Tarefa>> GetParentByProject(int id){
            var result = await _httpClient.GetAsync($"api/tarefas/parentbyproject/{id}");
            using var responseStream = await result.Content.ReadAsStreamAsync();
            var options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            return await JsonSerializer.DeserializeAsync<List<Tarefa>>(responseStream, options);
        }

        public async Task<List<Tarefa>> GetFilho(int id)
        {
            var result = await _httpClient.GetAsync($"api/tarefas/filho/{id}");
            using var responseStream = await result.Content.ReadAsStreamAsync();
            var options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            return await JsonSerializer.DeserializeAsync<List<Tarefa>>(responseStream, options);
        }

        public async Task PutAsync(int id, Tarefa trf)
        {
            await _httpClient.PutAsJsonAsync<Tarefa>($"api/tarefas/{id}", trf);
        }

        public async Task Post(Tarefa trf)
        {
            await _httpClient.PostAsJsonAsync<Tarefa>("api/tarefas/", trf);
        }

        public async Task Delete(int id)
        {
            await _httpClient.DeleteAsync($"api/tarefas/{id}");
        }
    }
}