using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaJJT.Business.DTOs;
using PruebaTecnicaJJT.Infraestructure.Services.Interfaces;

namespace PruebaTecnicaJJT.Web.Controllers.Clientes
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class ClientesController : ControllerBase
    {
        #region Fields
        private readonly IClienteService _service;
        #endregion

        #region Ctor
        public ClientesController(IClienteService service)
        {
            _service = service;

        }
        #endregion

        #region Methods
        [AllowAnonymous]
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] DTOClientes cliente)
        {
            return Ok(await _service.Create(cliente));
        }

        [AllowAnonymous]
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int pk)
        {
            if (pk != default)
            {
                return Ok(await _service.Delete(pk));
            }
            else
            {
                return BadRequest(new {Msj = "El dato requerido no puede ser cero o nulo" });
            }

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
