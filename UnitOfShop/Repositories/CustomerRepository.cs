using UnitOfShop.Data;
using UnitOfShop.Models;
using UnitOfShop.Repositories.interfaces;

namespace UnitOfShop.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _dataContext;
        public CustomerRepository(DataContext context) 
        { 
            _dataContext = context;
        }

        public void Save(Customer customer)
        {
            _dataContext.Customers.Add(customer);
            
        }
    }
}
