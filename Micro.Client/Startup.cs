using Micro.Client.Clients;
using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Micro.Client
{
    public class Startup
    {


        public void ConfigureServices(IServiceCollection services)
        {
            //var url = this.Conf
            services.AddScoped<ITeamServiceClient, HttpTeamServiceClient>();
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
