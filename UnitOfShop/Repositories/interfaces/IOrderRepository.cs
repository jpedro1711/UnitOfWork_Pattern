using UnitOfShop.Models;

namespace UnitOfShop.Repositories.interfaces
{
    public interface IOrderRepository
    {
        void Save(Order order);
    }
}
