using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Micro.Client.Models;
using Newtonsoft.Json;

namespace Micro.Client.Clients
{
    public class HttpTeamServiceClient : ITeamServiceClient
    {
        private const string URL = "https://localhost:44394/api/teams";

        public async Task<IEnumerable<Team>> GetAllAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var teams = JsonConvert.DeserializeObject<IEnumerable<Team>>(content);
                    return teams;
                }
            }

            return new List<Team>();
        }
    }
}
