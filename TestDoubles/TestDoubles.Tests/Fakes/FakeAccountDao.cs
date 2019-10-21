using System.Collections.Generic;
using TestDoubles.Tests.Models;
using TestDoubles.Tests.Services;

namespace TestDoubles.Tests.Fakes
{
    public class FakeAccountDao : IAccountDao
    {
       private IDictionary<string, Account> _accounts = new Dictionary<string, Account>();

        public FakeAccountDao()
        {
            this._accounts.Add("john@bmail.com", new Account("AQAAAAEAACcQAAAAEOp+tWVt0OJl6/HA5qEjrzji8Q/+nbJCuNNNfjSrUt6sETkjMfo+eOTiU80hINEFdg==")); //john
            this._accounts.Add("boby@bmail.com", new Account("AQAAAAEAACcQAAAAEEommnFPdjshRJj4+fZ9araSUaRrLFR3SpBniNbaK/EXwJJzkTCVrF3KFwrqQdmVgQ==")); //boby
        }

        public string getPasswordHash(string user)
        {
            return _accounts[user].PasswordHash;
        }
    }
}
