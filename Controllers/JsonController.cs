// Controlador principal que guarda JSON completo y detalles
using Microsoft.AspNetCore.Mvc;

namespace JsonStorageApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JsonController : ControllerBase
    {
        // Métodos para manejar las solicitudes JSON
        [HttpGet]
        public IActionResult GetJson()
        {
            // Lógica para obtener el JSON completo
            return Ok();
        }

        [HttpPost]
        public IActionResult SaveJson([FromBody] object json)
        {
            // Lógica para guardar el JSON completo
            return CreatedAtAction(nameof(GetJson), new { id = 1 }, json);
        }

        [HttpGet("{id}")]
        public IActionResult GetJsonById(int id)
        {
            // Lógica para obtener un detalle del JSON por ID
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateJson(int id, [FromBody] object json)
        {
            // Lógica para actualizar un detalle del JSON por ID
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteJson(int id)
        {
            // Lógica para eliminar un detalle del JSON por ID
            return NoContent();
        }
    }
}