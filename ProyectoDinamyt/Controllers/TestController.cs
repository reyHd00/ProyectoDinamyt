using Microsoft.AspNetCore.Mvc;
using ProyectoDinamyt.Models;
using ProyectoDinamyt.Repository.Imp;

namespace ProyectoDinamyt.Controllers

{
    [ApiController]
    [Route("[controller]")]
    
    public class TestController : ControllerBase
    {
        private IMostrarDatosRepository _mostrarDatosRepository;
        public TestController(IMostrarDatosRepository mostrarDatosRepository)
        {
            _mostrarDatosRepository = mostrarDatosRepository;
        }

        [HttpGet("PrimeraPrueba")]
        public ActionResult GetPrimeraPrueba()
        {
            return Ok("Hola Mundo");
        }

        [HttpGet("{nombre}")]
        public ActionResult MostrarDatos([FromRoute] string nombre)
        {
            CantidadModels cantidad = _mostrarDatosRepository.GetCantidadModels(nombre);
            return Ok(cantidad);
        }

        
    }
}
