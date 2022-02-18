using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaJJT.Infraestructure.Services.Interfaces;

namespace PruebaTecnicaJJT.Web.Controllers.Departamentos
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class DepartamentosController : ControllerBase
    {
        #region Fields
        private readonly IDepartamentoService _service;
        #endregion

        #region Ctor
        public DepartamentosController(IDepartamentoService service)
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

        [AllowAnonymous]
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAll<object>());
        }
        #endregion
    }
}
