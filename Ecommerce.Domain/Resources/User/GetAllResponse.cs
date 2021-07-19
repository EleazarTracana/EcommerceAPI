
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Domain.Models;

namespace Ecommerce.Domain.Resources.User
{
    public class GetAllResponse
    {
        public IEnumerable<Models.User> users { get; set; }
        public int count { get; set; }

        public GetAllResponse(IEnumerable<Models.User> users)
        {
            this.users = users;
            this.count = users.Count();
        }
    }
}
