using Products.Domain.Authentication;
using System.Collections.Generic;

namespace Products.Service.Services.Interfaces
{
    public interface ICustomAuthenticationService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest authenticateRequest);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
