using Ecommerce.Domain.Models;
using Ecommerce.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IRepository<Order> repository;
        public OrdersController(IRepository<Order> repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public IEnumerable<Order> Orders()
        {
            return repository.All();
        }
    }
}
