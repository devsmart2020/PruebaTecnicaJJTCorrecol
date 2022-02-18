using Dapper;
using PruebaTecnicaJJT.Persistence.DAL.Helpers;
using PruebaTecnicaJJT.Transversal;
using System.Data;

namespace PruebaTecnicaJJT.Persistence.DAL.Repositories
{
    public sealed class GenericRepository : BaseRepository, IGenericRepository
    {

        #region Ctor
        public GenericRepository(IDbTransaction transaction) : base(transaction)
        {
            Transaction = transaction;
        }
        #endregion

        #region Methods
        public async Task<TEntity> CreateOrUpdate<TEntity>(TEntity entity, IDictionary<string, object> parameters)
        {
            CommandDefinition cmd = new(commandText: Helper.GetNameStoreProcedure(entity, Constants.TIPO_ACCION_INSERT),
                parameters: Helper.ToDapperParameters(parameters),
                transaction: Transaction,
                commandType: CommandType.StoredProcedure);
            var query = await Transaction.Connection.QueryFirstAsync<TEntity>(cmd).ConfigureAwait(false);
            return query;
        }

        public async Task<bool> Delete<TEntity>(dynamic pk, string nameColumnPk, TEntity entityName)
        {
            DynamicParameters parameters = new();
            if (pk is int)
            {
                parameters.Add(nameColumnPk, pk, dbType: DbType.Int32);
            }
            else
            {
                string pkStringValue = pk.ToString();
                parameters.Add(nameColumnPk, pkStringValue, dbType: DbType.String);
            }
            CommandDefinition cmd = new(commandText: Helper.GetNameStoreProcedure(entityName, Constants.TIPO_ACCION_DELETE),
                parameters: parameters, Transaction,
                commandType: CommandType.StoredProcedure);
            IDictionary<string, object> query = await Transaction.Connection.QueryFirstOrDefaultAsync(cmd).ConfigureAwait(false);
            return query != null;
        }

        public async Task<TEntity> FindById<TEntity>(TEntity entity, IDictionary<string, object> parameters)
        {
            CommandDefinition cmd = new(commandText: Helper.GetNameStoreProcedure(entity, Constants.TIPO_ACCION_GETBY_ID),
                parameters: Helper.ToDapperParameters(parameters),
                transaction: Transaction,
                commandType: CommandType.StoredProcedure);
            return await Transaction.Connection.QueryFirstOrDefaultAsync<TEntity>(cmd).ConfigureAwait(false);
        }

        public async Task<IEnumerable<TEntity>> FindListById<TEntity>(TEntity entity, string nameParameter, dynamic valueParameter)
        {

            DynamicParameters dapperParameters = new();
            dapperParameters.Add(nameParameter, valueParameter);

            CommandDefinition cmd = new(commandText: Helper.GetNameStoreProcedure(entity, Constants.TIPO_ACCION_GETALL),
                parameters: dapperParameters,
                transaction: Transaction,
                commandType: CommandType.StoredProcedure);
            return await Transaction.Connection.QueryAsync<TEntity>(cmd).ConfigureAwait(false);
        }

        public async Task<IEnumerable<TEntity>> GetAll<TEntity>(TEntity entity)
        {
            CommandDefinition cmd = new(commandText: Helper.GetNameStoreProcedure(entity, Constants.TIPO_ACCION_GETALL),
                transaction: Transaction,
                commandType: CommandType.StoredProcedure);
            return await Transaction.Connection.QueryAsync<TEntity>(cmd).ConfigureAwait(false);
        }
        #endregion
    }
}
