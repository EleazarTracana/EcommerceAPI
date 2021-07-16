using Ecommerce.Domain;
using Ecommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Repositories
{
    public class OrderRepository: GenericRepository<Order>
    {
        public OrderRepository(ShoppingDbContext context): base(context)
        {
        }
        public override IEnumerable<Order> Find(Expression<Func<Order, bool>> predicate)
        {
            return context.Orders
                .Include(x => x.OrderDetails)
                .ThenInclude(x => x.Product)
                .Where(predicate)
                .ToList();
        }
        public override Order Update(Order entity)
        {
            var order = context.Orders
                .Include(x => x.OrderDetails)
                .ThenInclude(x => x.Product)
                .Single(x => x.Id == entity.Id);

            order.OrderDetails = entity.OrderDetails;
            order.CreationDate = entity.CreationDate;

            return base.Update(order);
        }
    }
}
