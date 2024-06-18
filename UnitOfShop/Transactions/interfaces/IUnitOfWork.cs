namespace UnitOfShop.Transactions.interfaces
{
    public interface IUnitOfWork
    {
        void Commit();
        void RollBack();
    }
}
