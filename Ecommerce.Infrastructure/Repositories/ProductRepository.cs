using Ecommerce.Domain;
using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(ShoppingDbContext context) : base(context)
        {
        }
        public override Product Update(Product entity)
        {
            var product = context.Products.Single(x => x.Id == entity.Id);

            product.Name = entity.Name;
            product.WholesalePrice = entity.WholesalePrice;
            product.RetailPrice = entity.RetailPrice;
            product.CategoryId = entity.CategoryId;

            return base.Update(product);

        }
    }
}
