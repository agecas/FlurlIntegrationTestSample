using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;

namespace FlurlDemo.ApiApp.IntegrationTests
{
    public sealed class FuturamaWebApplicationFactory : WebApplicationFactory<Startup>
    {
        protected override TestServer CreateServer(IWebHostBuilder builder)
        {
            var server = base.CreateServer(builder);
            server.PreserveExecutionContext = true; // As suggested in some forums
            return server;
        }
    }
}