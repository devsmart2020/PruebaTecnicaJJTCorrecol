using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaJJT.Infraestructure.Services.Interfaces;

namespace PruebaTecnicaJJT.Web.Controllers.DivisionPolitica
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class DivisionPoliticaController : ControllerBase
    {
        #region Fields
        private readonly IDivisionPoliticaService _service;
        #endregion

        #region Ctor
        public DivisionPoliticaController(IDivisionPoliticaService service)
        {
            _service = service;
        }
        #endregion

        #region Methods
        [AllowAnonymous]
        [HttpGet("GetListById/{value}")]
        public async Task<IActionResult> GetAll(int value)
        {
            return Ok(await _service.FindListById<object>(value));
        }
        #endregion
    }
}
