using Ecommerce.Domain.Models;
using Ecommerce.Domain.Resources.User;
using Ecommerce.Infrastructure.Interfaces;
using Ecommerce.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> repository;
        public UserService(IRepository<User> repository)
        {
            this.repository = repository;
        }
        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            throw new NotImplementedException();
        }
        public GetAllResponse GetAll() => new GetAllResponse(repository.All());
    }
}
