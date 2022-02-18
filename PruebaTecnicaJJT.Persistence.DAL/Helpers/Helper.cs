using Dapper;
using System.Data;

namespace PruebaTecnicaJJT.Persistence.DAL.Helpers
{
    public static class Helper
    {
        public static DynamicParameters ToDapperParameters(this IDictionary<string, object> parameters)
        {
            if (parameters == null || parameters.Count == 0)
            {
                return null;
            }
            DynamicParameters dapperParameters = new DynamicParameters();
            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                if (parameter.Value is DataTable dt)
                {
                    dapperParameters.Add(parameter.Key, dt.AsTableValuedParameter());
                }
                else
                {
                    dapperParameters.Add(parameter.Key, parameter.Value);
                }
            }
            return dapperParameters;
        }

        public static string GetNameStoreProcedure<TEntity>(TEntity entity, string tipoAccion)
        {
            if (typeof(TEntity) == typeof(string))
            {
                string? tableName = entity.ToString();
                return $"{tableName}{tipoAccion}";
            }
            else
            {
                string? tableName = entity.GetType().Name;
                if (tableName == "String")
                {
                    tableName = entity.ToString();
                }
                return $"{tableName}{tipoAccion}";
            }
           
        }
    }
}
