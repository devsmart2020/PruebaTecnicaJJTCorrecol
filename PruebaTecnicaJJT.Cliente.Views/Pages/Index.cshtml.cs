using Microsoft.AspNetCore.Mvc.RazorPages;
using PruebaTecnicaJJT.Cliente.ViewModels.Vm;

namespace PruebaTecnicaJJT.Cliente.Views.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private TipoIdentificacionViewModel _tipoIdenVM;
        private PaisViewModel _paisVM;
        private ClientesViewModel _clienteVM;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            PruebaConsumoApi();
        }

        public void OnGet()
        {

        }

        private void PruebaConsumoApi()
        {
            //Para Probar descomentar los bloques de codigo

            //Datos Ok desde Api
            //_tipoIdenVM = new TipoIdentificacionViewModel();
            //_tipoIdenVM.ListarTipoIdentificacionCommand.Execute(null);

            //Datos Ok desde Api
            //_paisVM = new PaisViewModel();
            //_paisVM.ListarPaisesCommand.Execute(null);

            //Datos cliente OK
            _clienteVM = new ClientesViewModel();
            _clienteVM.ListarClientesCommand.Execute(null);

        }
    }
}