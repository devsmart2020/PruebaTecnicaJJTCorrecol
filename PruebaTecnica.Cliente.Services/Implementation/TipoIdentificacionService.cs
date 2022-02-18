using Base.Infraestructure.Services.ApiClient.Implementation;
using PruebaTecnica.Cliente.Services.Interfaces;
using PruebaTecnicaJJT.Business.DTOs;
using PruebaTecnicaJJT.Transversal;

namespace PruebaTecnica.Cliente.Services.Implementation
{
    public sealed class TipoIdentificacionService : ApiClient, ITipoIdentificacionService
    {
        #region Ctor
        public TipoIdentificacionService()
        {
            BaseUrl = Configuration.ApiUrl;
        }
        #endregion

        #region Methods
        public async Task<IEnumerable<DTOTipoIdentificacion>> ListarTiposDeIdentificacion()
        {
            RouteUrl = "TipoIdentificacion/GetAll";
            var query = await GetAsync<IEnumerable<DTOTipoIdentificacion>>(false,cancellationToken: default);
            return query.Data ?? null;
        }
        #endregion

    }
}
