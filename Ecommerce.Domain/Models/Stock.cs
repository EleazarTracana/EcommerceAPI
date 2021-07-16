using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OfficeId { get; set; }
        public Office Office { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
    }
}
