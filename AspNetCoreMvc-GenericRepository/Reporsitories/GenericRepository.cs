using AspNetCoreMvc_GenericRepository.Data;
using AspNetCoreMvc_GenericRepository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AspNetCoreMvc_GenericRepository.Reporsitories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly UrunDbContext _context;
        private DbSet<T> _dbSet;
        public GenericRepository(UrunDbContext context)
        {
            _context = context;             //ara katman - veritabana
            _dbSet = _context.Set<T>();     //tablo
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public T Get(Expression<Func<T, bool>> filter)
        {
            return  _dbSet.FirstOrDefault(filter);
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges(); 
        }


       

       

        
    }
}
