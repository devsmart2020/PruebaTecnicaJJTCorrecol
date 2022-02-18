using PruebaTecnicaJJT.Business.DTOs;

namespace PruebaTecnica.Cliente.Services.Interfaces
{
    public interface ITipoIdentificacionService
    {
        Task<IEnumerable<DTOTipoIdentificacion>> ListarTiposDeIdentificacion();
    }
}
