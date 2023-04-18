using eshop.Entities;

namespace eshop.Infrastructure.Repositories
{
    public interface IRepository<T> where T : IEntity, new()
    {
        void Add(T item);
        void Update(T item);
        void Delete(int id);

        IList<T> GetAll();
        T Get(int id);


    }
}
