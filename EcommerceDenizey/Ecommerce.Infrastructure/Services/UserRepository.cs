using Ecommerce.Application.Repository;
using Ecommerce.Domain;
using Ecommerce.Infrastructure.Presistance;

namespace Ecommerce.Infrastructure.Services
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DBContextApplication context) : base(context)
        {
        }

        // User CRUD Generic

        public Task AssignRoleToUserAsync(int userId, int roleId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetUserOrderHistory(int userid)
        {
            // get user order history with items
            throw new NotImplementedException();
        }
    }
}
