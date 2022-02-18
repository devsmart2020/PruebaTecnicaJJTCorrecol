using PruebaTecnicaJJT.Business.DTOs;

namespace PruebaTecnica.Cliente.Services.Interfaces
{
    public interface IDepartamentoService
    {
        Task<IEnumerable<DTODepartamentosColombia>> GetDepartamentos();
    }
}
