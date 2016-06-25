using System.Linq;
using CouchSurfing.Core;
using CouchSurfing.Interfases.Repository;

namespace CouchSurfing.Data.Repository
{
    public class UserRepository<T> : Repository<T>, IUserRepository<T> where T : User
    {
        public UserRepository(DataContext context) : base(context)
        {

        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(x => x.Email == email);
        }
    }
}
