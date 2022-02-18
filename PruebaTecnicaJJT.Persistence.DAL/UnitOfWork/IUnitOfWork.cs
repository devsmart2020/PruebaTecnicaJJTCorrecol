using PruebaTecnicaJJT.Persistence.DAL.Repositories;

namespace PruebaTecnicaJJT.Persistence.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository GenericRepository { get; }
        void Commit();
    }
}
