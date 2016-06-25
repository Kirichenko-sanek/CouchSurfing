using CouchSurfing.Core;

namespace CouchSurfing.Interfases.Repository
{
    public interface IUserRepository<T> : IRepository<T> where T : User
    {
        User GetUserByEmail(string email);
    }
}
