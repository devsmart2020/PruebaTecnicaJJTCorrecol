using Base.Infraestructure.Services.ApiClient.Implementation;
using PruebaTecnica.Cliente.Services.Interfaces;
using PruebaTecnicaJJT.Business.DTOs;
using PruebaTecnicaJJT.Transversal;

namespace PruebaTecnica.Cliente.Services.Implementation
{
    public sealed class MunicipioService : ApiClient, IMunicipioService
    {
        #region Ctor
        public MunicipioService()
        {
            BaseUrl = Configuration.ApiUrl;
        }
        #endregion

        #region Methods
        public async Task<IEnumerable<DTODivisionPoliticaColombia>> GetMunicipios()
        {
            RouteUrl = "DivisionPoliticaColombia/GetAll";
            var query = await GetAsync<IEnumerable<DTODivisionPoliticaColombia>>(false, cancellationToken: default);
            return query.Data;
        }
        #endregion
    }
}
