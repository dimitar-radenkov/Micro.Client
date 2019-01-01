using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Micro.Client.Models;

namespace Micro.Client.Clients
{
    public interface ITeamServiceClient
    {
        Task<IEnumerable<Team>> GetAllAsync();

        Task<Team> CreateAsync(string name);

        Task<bool> DeleteAsync(Guid teamId);
    }
}
