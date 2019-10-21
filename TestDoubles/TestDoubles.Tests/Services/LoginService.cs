using Microsoft.AspNetCore.Identity;
using TestDoubles.Tests.Models;
using TestDoubles.Tests.Services;

namespace TestDoubles.Tests.Services
{
    public class LoginService
    {
        private readonly IAccountDao _accountDao;

        public LoginService(IAccountDao accountDao)
        {
            _accountDao = accountDao;
        }

        public bool Login(User user)
        {
            var passwordHash = _accountDao.getPasswordHash(user.Email);

            var hasher = new PasswordHasher<string>();
            var result = hasher.VerifyHashedPassword(user.Email, passwordHash, user.Password);

            return result == PasswordVerificationResult.Success;
        }
    }
}
