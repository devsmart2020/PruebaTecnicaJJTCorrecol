using Base.Infraestructure.Services.ApiClient.Implementation;
using PruebaTecnica.Cliente.Services.Interfaces;
using PruebaTecnicaJJT.Business.DTOs;
using PruebaTecnicaJJT.Transversal;

namespace PruebaTecnica.Cliente.Services.Implementation
{
    public sealed class PaisService : ApiClient, IPaisService
    {
        #region Ctor
        public PaisService()
        {
            BaseUrl = Configuration.ApiUrl;
        }
        #endregion

        #region Methods
        public async Task<IEnumerable<DTOPais>> ListarPaises()
        {
            RouteUrl = "Pais/GetAll";
            var query = await GetAsync<IEnumerable<DTOPais>>(false, cancellationToken: default);
            return query.Data ?? null;
        }
        #endregion
    }
}
