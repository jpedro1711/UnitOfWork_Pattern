using UnitOfShop.Models;

namespace UnitOfShop.Repositories.interfaces
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);
    }
}
