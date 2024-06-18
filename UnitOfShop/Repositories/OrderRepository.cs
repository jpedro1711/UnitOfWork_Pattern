using UnitOfShop.Data;
using UnitOfShop.Models;
using UnitOfShop.Repositories.interfaces;

namespace UnitOfShop.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _dataContext;
        public OrderRepository(DataContext context)
        {
            _dataContext = context;
        }

        public void Save(Order order)
        {
            _dataContext.Orders.Add(order);
            
        }
    }
}
