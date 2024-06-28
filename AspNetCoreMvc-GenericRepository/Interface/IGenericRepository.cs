using System.Linq.Expressions;

namespace AspNetCoreMvc_GenericRepository.Interface
{
    public interface IGenericRepository<T> where T : class, new()
    {
        List<T> GetAll();
        T GetById(int id);
        T Get(Expression<Func<T, bool>> filter);

        void Add (T entity);
        void Update(T entity);
        void Delete(T entity);

    }

}

