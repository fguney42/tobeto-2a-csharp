using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.User
{
    public class LoginRequest
    {
        public string Email { set; get; }
        public string Password { set; get; }
    }
}
