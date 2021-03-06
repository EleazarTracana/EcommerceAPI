using Ecommerce.Domain;
using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Repositories
{
    public class SellerRepository : GenericRepository<Seller>
    {
        public SellerRepository(ShoppingDbContext context) : base(context)
        {
        }
    }
}
