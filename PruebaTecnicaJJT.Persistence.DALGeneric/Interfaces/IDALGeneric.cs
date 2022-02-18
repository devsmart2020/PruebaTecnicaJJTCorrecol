namespace PruebaTecnicaJJT.Persistence.DALGeneric.Interfaces
{
    public interface IDALGeneric
    {
        Task<TEntity> CreateOrUpdate<TEntity>(TEntity entity, IDictionary<string, object> parameters);
        Task<IEnumerable<TEntity>> GetAll<TEntity>(TEntity entity);
        Task<bool> Delete<TEntity>(dynamic pk, string nameColumnPk, TEntity entity);
        Task<TEntity> FindById<TEntity>(TEntity entity, IDictionary<string, object> parameters);
        Task<IEnumerable<TEntity>> FindListById<TEntity>(TEntity entity,string nameParameter, dynamic valueParameter);
    }
}
