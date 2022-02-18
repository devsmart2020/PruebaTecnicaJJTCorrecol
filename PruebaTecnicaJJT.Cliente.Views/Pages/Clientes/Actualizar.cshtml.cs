using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PruebaTecnicaJJT.Business.DTOs;

namespace PruebaTecnicaJJT.Cliente.Views.Pages.Clientes
{
    public class ActualizarModel : PageModel
    {

        [BindProperty]
        public DTOClientes Cliente { get; set; }

        public void OnGet()
        {
        }
    }
}
