using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PruebaTecnica.Cliente.Services.Interfaces;
using PruebaTecnicaJJT.Business.DTOs;
using PruebaTecnicaJJT.Cliente.ViewModels.Vm;
using System.Collections.ObjectModel;

namespace PruebaTecnicaJJT.Cliente.Views.Pages.Clientes
{
    public class ListaModel : PageModel
    {  
        private readonly IClienteService _service;       

        public ListaModel(IClienteService service)
        {
            _service = service;
        }

        public ObservableCollection<DTOClientesGetAll> Clientes { get; set; } = new ObservableCollection<DTOClientesGetAll>();

        [BindProperty]
        public List<DTOClientesGetAll> ClientesList { get; set; } = new List<DTOClientesGetAll>();

        public async void OnGet()
        {

            Clientes = new ObservableCollection<DTOClientesGetAll>(await _service.ListarClientes());
            ClientesList = Clientes.ToList();
            //_clienteVM = new ClientesViewModel();
            //await _clienteVM.ListarClientes();
            //if (_clienteVM.ListadoClientes.Any())
            //{
            //    //ClientesList = new List<DTOClientesGetAll>(_clienteVM.ListadoClientes.ToList());
            //    ClientesList = new List<DTOClientesGetAll>(_clienteVM.ListadoClientes.ToList());
            //    ClientesList.Add(new DTOClientesGetAll { Id = 1, TipoIdentificacion = "PRueba" });
            //    //Clientes = new ObservableCollection<DTOClientesGetAll>(_clienteVM.ListadoClientes);
            //}
            //else
            //{

            //}


        }

        public async void OnPost()
        {

            //Clientes = new ObservableCollection<DTOClientesGetAll>(await _service.ListarClientes());
            //ClientesList = Clientes.ToList();
            //_clienteVM = new ClientesViewModel();
            //await _clienteVM.ListarClientes();
            //if (_clienteVM.ListadoClientes.Any())
            //{
            //    //Clientes = new ObservableCollection<DTOClientesGetAll>(_clienteVM.ListadoClientes);
            //    ClientesList = new List<DTOClientesGetAll>(_clienteVM.ListadoClientes.ToList());

            //}
            //else
            //{

            //}
        }
    }
}
