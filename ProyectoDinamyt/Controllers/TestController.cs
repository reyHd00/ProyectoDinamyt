using Microsoft.AspNetCore.Mvc;
//using ProyectoDinamyt.Models;
using ProyectoDinamyt.Repository.Imp;
using ProyectoDinamyt.Repository.Tables;

namespace ProyectoDinamyt.Controllers

{
    [ApiController]
    [Route("[controller]")]

    public class TestController : ControllerBase
    {
        private readonly IUserValidationRepository _userValidationRepository;

        public TestController(IUserValidationRepository userValidationRepository)
        {
            _userValidationRepository = userValidationRepository;
        }

        [HttpGet("PrimeraPrueba")]
        public ActionResult GetPrimeraPrueba()
        {
            return Ok("Hola Mundo");
        }
        [HttpGet("ValidarUsuario/{email}/{password}")]
        public async Task<ActionResult> ValidarUsuario([FromRoute] string email, [FromRoute] string password)
        {
            // Realiza la validación de usuario utilizando el repositorio de validación
            UsersTable user = await _userValidationRepository.Get(email, password);

            if (user != null)
            {
                return Ok("Usuario válido");
            }
            else
            {
                return BadRequest("Usuario no válido");
            }
        }



    }
}
