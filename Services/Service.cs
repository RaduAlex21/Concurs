using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Services;

public class Service<T>
{
    private readonly string? url = "https://localhost:7211/api";
    public Service(string domain)
    {
        url = url + "/" + domain;
    }

    public async Task<List<T>> GetAll()
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri(this.url);
            var result = await client.GetAsync("GetAll"); ;
            string resultContent = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<T>>(resultContent);
        }
    }

    public async Task<T> Insert(T entity)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri(this.url);
            var response = await client.PostAsJsonAsync("Insert", entity); //put pt update delete sau del pt delete
            if (response.IsSuccessStatusCode)
            {
                string resultContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(resultContent);
            }
            else
                throw new Exception($"Error at insert {nameof(T)}, Status code: {response.StatusCode}");
        }
    }

    public async Task<T> Update(T entity)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri(this.url);
            var response = await client.PutAsJsonAsync("Update", entity); //put pt update delete sau del pt delete
            if (response.IsSuccessStatusCode)
            {
                string resultContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(resultContent);
            }
            else
                throw new Exception($"Error at update {nameof(T)}, Status code: {response.StatusCode}");
        }
    }

    public async Task<bool> Delete(int id)
    {
        using (var client = new HttpClient()) 
        {
            client.BaseAddress = new Uri(this.url);
            var response = await client.DeleteAsync($"{id}");

            if (response.IsSuccessStatusCode)
            {
                string resultContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<bool>(resultContent);
            }
            else
                throw new Exception($"Error at delete white {id}, Status code: {response.StatusCode}"); 
        } 
    }
}
           
     
