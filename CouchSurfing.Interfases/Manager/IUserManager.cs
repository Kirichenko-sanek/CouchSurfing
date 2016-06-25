using CouchSurfing.Core;

namespace CouchSurfing.Interfases.Manager
{
    public interface IUserManager<T> : IManager<T> where T : User
    {
        User GetUserByEmail(string email);
    }
}
