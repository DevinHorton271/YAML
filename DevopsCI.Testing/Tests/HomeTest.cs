using DevopsCI.client.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DevOpsCI.Testing.Tests
{
    public class HomeTests
    {
        [Fact]
        public void HomeController_Test()
        {
            var sut = new HomeController();
            IActionResult view = sut.Index();

            Assert.NotNull(view);
        }
    }
}