using System;
using System.Collections.Generic;
using System.Text;

namespace Horus.Models
{
    public class LoginResponse
    {
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string AuthorizationToken { get; set; }
    }
}
