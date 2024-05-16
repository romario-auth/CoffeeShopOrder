namespace CoffeeShopOrder.Domain.Common
{
    public abstract class EntityBase
    {
        public Guid Id { get; protected set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}