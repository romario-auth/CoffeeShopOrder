using CoffeeShopOrder.Domain.Common;

namespace CoffeeShopOrder.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : EntityBase
    {
        T Create(T entity);
        T Update(T entity);
        void Delete(T entity);
        Task<T> Get(Guid T, CancellationToken cancellation);
        Task<List<T>> GetAll(CancellationToken cancellation);
    }
}
