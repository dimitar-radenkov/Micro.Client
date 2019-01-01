using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Micro.Client.Models;
using Microsoft.AspNetCore.Blazor;

namespace Micro.Client.Clients
{
    public class HttpTeamServiceClient : ITeamServiceClient
    {
        private const string URL = "https://localhost:44394/api/teams";

        public async Task<Team> CreateAsync(string name)
        {
            using (var httpClient = new HttpClient())
            {
                var created = await httpClient.PostJsonAsync<Team>(URL, name);
                Console.WriteLine(created);
                return created;
            }
        }

        public async Task<bool> DeleteAsync(Guid teamId)
        {
            using (var httpClient = new HttpClient())
            {
                var responseMessage = await httpClient.DeleteAsync($"{URL}/{teamId}");
                if (responseMessage.IsSuccessStatusCode)
                {
                    return true;
                }

                return false;
            }
        }

        public async Task<IEnumerable<Team>> GetAllAsync()
        {
            using (var httpClient = new HttpClient())
            {               
                var response = await httpClient.GetJsonAsync<IEnumerable<Team>>(URL);
                return response;
            }
        }
    }
}
