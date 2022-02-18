using Base.Infraestructure.Services.ApiClient.Implementation;
using PruebaTecnica.Cliente.Services.Interfaces;
using PruebaTecnicaJJT.Business.DTOs;
using PruebaTecnicaJJT.Transversal;

namespace PruebaTecnica.Cliente.Services.Implementation
{
    public sealed class DepartamentoService : ApiClient, IDepartamentoService
    {
        #region Ctor
        public DepartamentoService()
        {
            BaseUrl = Configuration.ApiUrl;
        }
        #endregion

        #region Methods
        public async Task<IEnumerable<DTODepartamentosColombia>> GetDepartamentos()
        {
            RouteUrl = "DepartamentosColombia/GetAll";
            var query = await GetAsync<IEnumerable<DTODepartamentosColombia>>(false, cancellationToken: default);
            return query.Data;
        }
        #endregion
    }
}
