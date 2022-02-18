using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaJJT.Infraestructure.Services.Interfaces;

namespace PruebaTecnicaJJT.Web.Controllers.Pais
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class PaisController : ControllerBase
    {
        #region Fields
        private readonly IPaisService _service;
        #endregion

        #region Ctor
        public PaisController(IPaisService service)
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
