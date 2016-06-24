using CouchSurfing.Core;

namespace CouchSurfing.Interfases.Validator
{
    public interface IValidator<in T> where T : BaseEntity
    {
        bool IsValid(T entity);
        bool IsExists(long id);
    }
}
