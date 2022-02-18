using PruebaTecnicaJJT.Business.DTOs;

namespace PruebaTecnica.Cliente.Services.Interfaces
{
    public interface IClienteService
    {
        Task<bool> CrearActualizarCliente(DTOClientes cliente);
        Task<bool> EliminarCliente(int clienteId);
        Task<IEnumerable<DTOClientesGetAll>> ListarClientes();
    }
}
