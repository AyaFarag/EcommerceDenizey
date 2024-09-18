using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        // Additional methods specific to user if needed
        Task AssignRoleToUserAsync(int userId, int roleId);
    }
}
