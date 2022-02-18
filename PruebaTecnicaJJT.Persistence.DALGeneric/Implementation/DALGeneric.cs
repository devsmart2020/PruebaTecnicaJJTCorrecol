using PruebaTecnicaJJT.Persistence.DAL.UnitOfWork;
using PruebaTecnicaJJT.Persistence.DALGeneric.Interfaces;
using PruebaTecnicaJJT.Transversal;

namespace PruebaTecnicaJJT.Persistence.DALGeneric.Implementation
{
    public sealed class DALGeneric : IDALGeneric
    {
        private string DbConnection { get; set; }
        #region Ctor
        public DALGeneric()
        {
            DbConnection = Configuration.DbConn;
        }
        #endregion

        #region Methods
        public async Task<TEntity> CreateOrUpdate<TEntity>(TEntity entity, IDictionary<string, object> parameters)
        {
            using UnitOfWork work = new(DbConnection);
            var query = await work.GenericRepository.CreateOrUpdate(entity, parameters);
            work.Commit();
            return query;
        }

        public async Task<bool> Delete<TEntity>(dynamic pk, string nameColumnPk, TEntity entity)
        {
            using UnitOfWork work = new(DbConnection);
            var query = await work.GenericRepository.Delete(pk, nameColumnPk, entity);
            work.Commit();
            return query;
        }

        public Task<TEntity> FindById<TEntity>(TEntity entity, IDictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> GetAll<TEntity>(TEntity entity)
        {
            using UnitOfWork work = new(DbConnection);
            var query = await work.GenericRepository.GetAll(entity);
            work.Commit();
            return query;
        }

        public async Task<IEnumerable<TEntity>> FindListById<TEntity>(TEntity entity, string nameParameter, dynamic valueParameter)
        {
            using UnitOfWork work = new(DbConnection);
            var query = await work.GenericRepository.FindListById(entity, nameParameter, valueParameter);
            work.Commit();
            return query;
        }
        #endregion


    }
}
