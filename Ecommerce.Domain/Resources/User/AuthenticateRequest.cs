using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Resources.User
{
    public class AuthenticateRequest
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
