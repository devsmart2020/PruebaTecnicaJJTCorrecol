using System.Data;

namespace PruebaTecnicaJJT.Persistence.DAL.Repositories
{
    public abstract class BaseRepository
    {
        #region Fields
        protected IDbTransaction Transaction { get; set; }
        protected IDbConnection Connection => Transaction.Connection;
        #endregion

        #region Ctor
        public BaseRepository(IDbTransaction transaction)
        {
            Transaction = transaction;
        }
        #endregion
    }
}
