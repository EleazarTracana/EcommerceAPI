using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Resources.User
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string validFrom { get; set; }
        public string validTo { get; set; }
        public string token { get; set; }
    }
}
