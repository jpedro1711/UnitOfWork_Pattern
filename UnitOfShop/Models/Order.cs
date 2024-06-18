namespace UnitOfShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

    }
}
