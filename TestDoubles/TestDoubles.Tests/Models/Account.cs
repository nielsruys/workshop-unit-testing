namespace TestDoubles.Tests.Models
{
    public class Account
    {
        private string _hash;

        public Account(string hash)
        {
            _hash = hash;
        }

        public string PasswordHash => _hash;
    }
}
