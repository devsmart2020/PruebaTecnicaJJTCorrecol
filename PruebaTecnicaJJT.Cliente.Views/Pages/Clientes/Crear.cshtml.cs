using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PruebaTecnica.Cliente.Services.Interfaces;
using PruebaTecnicaJJT.Business.DTOs;

namespace PruebaTecnicaJJT.Cliente.Views.Pages.Clientes
{
    public class CrearModel : PageModel
    {
        private readonly IClienteService _service;
        private readonly ITipoIdentificacionService _tipoIdentificacionservice;
        private readonly IPaisService _paisService;
        private readonly IDepartamentoService _departamentoService;
        private readonly IMunicipioService _municipioService;
        public int paisSelected;

        public CrearModel(IClienteService service, 
            ITipoIdentificacionService tipoIdentificacionservice,
            IPaisService paisService, IDepartamentoService departamentoService,
            IMunicipioService municipioService)
        {
            _service = service;
            _tipoIdentificacionservice=tipoIdentificacionservice;
            _paisService = paisService;
            _departamentoService = departamentoService;
            _municipioService = municipioService;
        }

        [BindProperty]
        public DTOClientes Cliente { get; set; }

        [BindProperty]
        public IEnumerable<DTOTipoIdentificacion> TiposIdent { get; set; }

        [BindProperty]
        public IEnumerable<DTOPais> Paises { get; set; }

        [BindProperty]
        public IEnumerable<DTODepartamentosColombia> Departamentos { get; set; }

        [BindProperty]
        public IEnumerable<DTODivisionPoliticaColombia> Municipios { get; set; }

        public async Task OnGet()
        {
            TiposIdent = await _tipoIdentificacionservice.ListarTiposDeIdentificacion();
            Paises = await _paisService.ListarPaises();
            //Departamentos = await _departamentoService.GetDepartamentos();
            //Municipios = await _municipioService.GetMunicipios();
        }

        public async Task OnPost()
        {
            await _service.CrearActualizarCliente(Cliente);
        }
    }
}
