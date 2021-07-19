using Ecommerce.Domain.Models;
using Ecommerce.Domain.Resources.User;
using Ecommerce.Infrastructure.Interfaces;
using Ecommerce.Infrastructure.Repositories;
using Ecommerce.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserService service;

        public UsersController(IUserService service)
        {
            this.service = service;
        }
        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest request)
        {
            return null;
        }
        [HttpGet]
        public IActionResult All() => Ok(service.GetAll());
    }
}
