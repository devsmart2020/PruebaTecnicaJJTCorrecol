using PruebaTecnicaJJT.Persistence.DAL.Repositories;
using System.Data;
using System.Data.SqlClient;

namespace PruebaTecnicaJJT.Persistence.DAL.UnitOfWork
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        #region Fields
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private IGenericRepository _repository;
        private bool _dispose;
        #endregion

        #region Ctor
        public UnitOfWork(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }
        #endregion

        #region Methods

        public IGenericRepository GenericRepository
        {
            get { return _repository ?? (_repository = new GenericRepository(_transaction)); }
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                ResetRepositories();
            }
        }

        private void ResetRepositories()
        {
            _repository = null;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_dispose)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _dispose = true;
            }
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
        #endregion
    }
}
