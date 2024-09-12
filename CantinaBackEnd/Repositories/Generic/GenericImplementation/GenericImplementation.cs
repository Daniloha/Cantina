using CantinaBackEnd.Context;
using CantinaBackEnd.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace CantinaBackEnd.Repositories.Generic.GenericImplementation
{
    public class GenericImplementation : IRepository<T> where T : BaseModel
    {

        protected MySQLContext _context;
        private DbSet<T> _dataset;

        public T Create(T item)
        {
            try
            {
                _dataset.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Delete(long id)
        {
            var result = _dataset.SingleOrDefault(p => p.ID.Equals(id));
            if (result != null)
            {
                try
                {
                    _dataset.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public List<T> FindAll()
        {
            return _dataset.ToList();
        }

        public T FindById(long id)
        {
            return _dataset.SingleOrDefault(p => p.ID.Equals(id));
        }

        public T Update(T item)
        {
            var result = _dataset.SingleOrDefault(p => p.ID.Equals(item.ID));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            else
            {
                return null;
            }
        }
    }
}
