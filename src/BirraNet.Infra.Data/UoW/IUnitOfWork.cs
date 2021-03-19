namespace BirraNet.Infra.Data.UoW
{
    public interface IUnitOfWork
    {
        void Commit();
        void RollBack();
    }
}
