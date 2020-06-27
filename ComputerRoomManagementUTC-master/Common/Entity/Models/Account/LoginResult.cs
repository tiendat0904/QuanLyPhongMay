using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entity.Models.Account
{
    public class LoginResult
    {
        // jwt return from server when authenticate process successes
        public string token { get; set; }
    }
}
