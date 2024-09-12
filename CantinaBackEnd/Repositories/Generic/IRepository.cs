using CantinaBackEnd.Models.Base;

namespace CantinaBackEnd.Repositories.Generic
{
    public interface IRepository<T> where T : BaseModel
    {
        T Create(T item);
        T Update(T item);
        T FindById(long id);
        List<T> FindAll();
        void Delete(long id);
    }
}
