
using System.Linq.Expressions;

namespace arcadeScore.api.Interfaces.Repositories;

public interface IRepositoryBase<T> where T : class
{
    public T GetById(Func<T, bool> predicate);
    public List<T> GetByCondition(Func<T, bool> predicate);
    public List<T> GetAll();
    public void Save(T entity);
}