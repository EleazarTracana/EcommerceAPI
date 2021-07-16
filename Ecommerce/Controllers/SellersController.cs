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
    public class SellersController : ControllerBase
    {
        private readonly IRepository<Seller> repository;
        public SellersController(IRepository<Seller> repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public IEnumerable<Seller> Orders()
        {
            return repository.All();
        }
    }
}
