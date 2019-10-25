using Microsoft.AspNetCore.Identity;
using System;
using TestDoubles.Tests.Fakes;
using TestDoubles.Tests.Models;
using TestDoubles.Tests.Services;
using Xunit;

namespace TestDoubles.Tests
{
    public class LoginServiceTest
    {
        [Fact]
        public void LogInWithPasswordShouldBeOk()
        {
            var user = new User()
            {
                Email = "boby@bmail.com",
                Password = "boby"
            };
            var service = new LoginService(new FakeAccountDao());

            var loggedIn = service.Login(user);

            Assert.True(loggedIn);
        }
    }
}
