using PruebaTecnicaJJT.Business.DTOs;

namespace PruebaTecnica.Cliente.Services.Interfaces
{
    public interface IMunicipioService
    {
        Task<IEnumerable<DTODivisionPoliticaColombia>> GetMunicipios();

    }
}
