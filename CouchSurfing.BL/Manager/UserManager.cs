using CouchSurfing.Core;
using CouchSurfing.Interfases.Manager;
using CouchSurfing.Interfases.Repository;
using CouchSurfing.Interfases.Validator;

namespace CouchSurfing.BL.Manager
{
    public class UserManager<T> : Manager<T>, IUserManager<T> where T : User
    {
        private readonly IUserRepository<User> _userRepository;
        public UserManager(IUserRepository<User> userRepository, IRepository<T> repository, IValidator<T> validator)
            : base(repository, validator)
        {
            _userRepository = userRepository;
        }

        public User GetUserByEmail(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }
    }
}
