using CoffeeShopOrder.Domain.Exceptions;

namespace CoffeeShopOrder.Domain.Common
{
    public abstract class EntityBase
    {
        public Guid Id { get; protected set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsValid() => Validate().Count == 0;
        public abstract List<string> Validate();
        public void SetCreate()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;

            ValidateEntities();
        }

        public void SetUpdated()
        {
            ValidateEntities();
            UpdatedAt = DateTime.UtcNow;
        }

        public void ValidateEntities()
        {
            if (!IsValid())
                throw new OrderException(String.Join(", ", Validate().ToArray()));
        }
    }
}