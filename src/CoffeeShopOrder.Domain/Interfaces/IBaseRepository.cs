using CoffeeShopOrder.Domain.Common;

namespace CoffeeShopOrder.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : EntityBase
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> Get(Guid T, CancellationToken cancellation);
        Task<List<T>> GetAll(CancellationToken cancellation);
    }
}
