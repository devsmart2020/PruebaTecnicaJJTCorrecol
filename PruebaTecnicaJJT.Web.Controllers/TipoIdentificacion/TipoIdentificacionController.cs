using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaJJT.Infraestructure.Services.Interfaces;

namespace PruebaTecnicaJJT.Web.Controllers.TipoIdentificacion
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class TipoIdentificacionController : ControllerBase
    {
        #region Fields
        private readonly ITipoIdentificacionService _service;

        #endregion

        #region Ctor
        public TipoIdentificacionController(ITipoIdentificacionService service)
        {
            _service = service;
        }
        #endregion

        #region Methods
        [AllowAnonymous]
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAll<object>());
        }
        #endregion
    }
}
