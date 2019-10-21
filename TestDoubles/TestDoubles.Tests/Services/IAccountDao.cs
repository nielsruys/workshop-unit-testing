using System;
using System.Security.Cryptography;
using System.Text;

namespace TestDoubles.Tests.Services
{
    public interface IAccountDao
    {
        string getPasswordHash(string user);
    }
}
