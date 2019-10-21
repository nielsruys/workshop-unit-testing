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
            var userName = "boby@bmail.com";
            var user = new User()
            {
                Email = userName,
                Password = "boby"
            };
            var service = new LoginService(new FakeAccountDao());

            var loggedIn = service.Login(user);

            Assert.True(loggedIn);
        }
    }
}
