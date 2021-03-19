using BirraNet.Infra.Data.Contexto;

namespace BirraNet.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Commit()
        {
            _dataContext.SaveChanges();
        }

        public void RollBack()
        {

        }
    }
}
