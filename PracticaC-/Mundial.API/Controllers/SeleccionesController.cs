using Microsoft.AspNetCore.Mvc;
using Mundial.API.Models;
using Mundial.API.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mundial.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeleccionesController(ISeleccionService SeleccionService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> ObtenerTodos()
        {
            List<Seleccion> selecciones =  await SeleccionService.ObtenerTodos();
            return Ok(selecciones);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> EliminarSeleccion([FromRoute] int Id)
        {
            await SeleccionService.BorrarSeleccion(Id);
            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CrearSeleccion([FromBody] Seleccion seleccion)
        {
            await SeleccionService.CrearSeleccion(seleccion);
            return Created();
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> ActualizarSeleccion([FromRoute] int Id, [FromBody] Seleccion seleccion)
        {
            seleccion.Id = Id;
            await SeleccionService.ActualizarSeleccion(seleccion);
            return NoContent();
        }
        
    }
}
