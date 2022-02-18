using PruebaTecnicaJJT.Business.DTOs;

namespace PruebaTecnica.Cliente.Services.Interfaces
{
    public interface IPaisService
    {
        Task<IEnumerable<DTOPais>> ListarPaises();
    }
}
