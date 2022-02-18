using Base.Infraestructure.Services.ApiClient.Implementation;
using PruebaTecnica.Cliente.Services.Interfaces;
using PruebaTecnicaJJT.Business.DTOs;

namespace PruebaTecnica.Cliente.Services.Implementation
{
    public sealed class ClienteService : ApiClient, IClienteService
    {
        #region Ctor
        public ClienteService()
        {

        }
        #endregion

        #region Methods
        public async Task<bool> CrearActualizarCliente(DTOClientes cliente)
        {
            RouteUrl = "Clientes/Create";
            var query = await PostAsync<DTOClientes, bool>(cliente, false, cancellationToken: default);
            return query.Data;
        }

        public async Task<bool> EliminarCliente(int clienteId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DTOClientesGetAll>> ListarClientes()
        {
            RouteUrl = "Clientes/GetAll";
            var query = await GetAsync<IEnumerable<DTOClientesGetAll>>(false, cancellationToken: default);
            return query.Data ?? null;
        }
        #endregion
    }
}
