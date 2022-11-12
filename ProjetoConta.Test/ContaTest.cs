using Castle.Core.Configuration;
using Moq;
using ProjetoConta.Api.Controllers;
using ProjetoConta.Api.Models;
using ProjetoConta.Api.Repositories;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using ProjetoConta.Api;

namespace ProjetoConta.Test
{
    public class ContaTest
    {
        private readonly HttpClient _client;

        public ContaTest()
        {
            var server = new TestServer(new WebHostBuilder() 
                .UseEnvironment("Development")
                .UseStartup<Startup>());
            _client = server.CreateClient();
        }

        [Theory]
        [InlineData("GET", 5)]
        public async Task NaoExisteContaAsync(string method, int? id = null)
        {
            var request = new HttpRequestMessage(new HttpMethod(method), $"/api/Contas/{id}");

            var response = await _client.SendAsync(request);

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);

        }

    }
}
