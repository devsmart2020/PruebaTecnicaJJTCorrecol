namespace PruebaTecnicaJJT.Persistence.DAL.Repositories
{
    public interface IGenericRepository
    {
        Task<TEntity> CreateOrUpdate<TEntity>(TEntity entity, IDictionary<string, object> parameters);
        Task<IEnumerable<TEntity>> GetAll<TEntity>(TEntity entity);
        Task<bool> Delete<TEntity>(object pk, string nameColumnPk, TEntity entity);
        Task<TEntity> FindById<TEntity>(TEntity entity, IDictionary<string, object> parameters);
        Task<IEnumerable<TEntity>> FindListById<TEntity>(TEntity entity, string nameParameter, dynamic valueParameter);
    }
}
