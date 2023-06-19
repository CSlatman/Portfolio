using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonsoftSerializeDeserializeObject
{
    public class Account
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Account(int accountId, string accountName, string password, string email)
        {
            AccountId = accountId;
            AccountName = accountName;
            Password = password;
            Email = email;
        }
    }
}
