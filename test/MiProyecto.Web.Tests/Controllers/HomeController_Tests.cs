using System.Threading.Tasks;
using MiProyecto.Models.TokenAuth;
using MiProyecto.Web.Controllers;
using Shouldly;
using Xunit;

namespace MiProyecto.Web.Tests.Controllers
{
    public class HomeController_Tests: MiProyectoWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}