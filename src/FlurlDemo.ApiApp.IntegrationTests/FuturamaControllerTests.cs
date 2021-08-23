using System;
using System.Net;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using Xunit;

namespace FlurlDemo.ApiApp.IntegrationTests
{
    public class FuturamaControllerTests : IClassFixture<FuturamaWebApplicationFactory>
    {
        public FuturamaControllerTests(FuturamaWebApplicationFactory factory) =>
            Factory = factory ?? throw new ArgumentNullException(nameof(factory));

        private FuturamaWebApplicationFactory Factory { get; }

        [Fact]
        public async Task Given_Flurl_When_CallMade_Return_MockedResult()
        {
            using (var httpTest = new HttpTest())
            {
                var client = Factory.CreateClient();

                //Act
                httpTest.RespondWithJson(new { }, (int)HttpStatusCode.MethodNotAllowed);

                var response = await client.GetAsync("/futurama");

                //Assert
                Assert.Equal(HttpStatusCode.MethodNotAllowed, response.StatusCode);
            }
        }
    }
}