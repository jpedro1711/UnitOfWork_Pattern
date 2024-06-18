using Microsoft.AspNetCore.Mvc;
using UnitOfShop.Models;
using UnitOfShop.Repositories.interfaces;
using UnitOfShop.Transactions.interfaces;

namespace UnitOfShop.Controllers
{
    [ApiController]
    [Route("v1/orders")]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Order Post(
            [FromServices] ICustomerRepository customerRepository,
            [FromServices] IOrderRepository orderRepository,
            [FromServices] IUnitOfWork unitOfWork
            ) 
        {
            try
            {
                var customer = new Customer { Id = 1, Name = "João" };
                var order = new Order { Id = 1, Number = "1'", Customer = customer };

                customerRepository.Save(customer);
                orderRepository.Save(order);

                unitOfWork.Commit();

                return order;
            }
            catch
            {
                unitOfWork.RollBack();
                return null;
            }
        }
    }
}
