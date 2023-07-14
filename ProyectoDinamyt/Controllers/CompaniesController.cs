using Microsoft.AspNetCore.Mvc;
using ProyectoDinamyt.Dto;
using ProyectoDinamyt.Repository.Acess;
using ProyectoDinamyt.Repository.Tables;

namespace ProyectoDinamyt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompaniesController : Controller
    {
        //tambien se agrego. errores eliminar o modificar
        private readonly BuscadorDbContext _buscadorDbContext;

        public CompaniesController(BuscadorDbContext buscadorDbContext)
        {
            _buscadorDbContext = buscadorDbContext;
        }
        // hasta aqui


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CompanyDto))] //agrega los estados a swagger
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetCompany(int id)
        {

            CompaniesTable result = await _buscadorDbContext.Get(id);
            return new OkObjectResult(result.ToDto()); //se utiliza para los metodos get y poder devolver el status
            
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CompanyDto))]
        public async Task<IActionResult> CreateCompany(CreateCompanyDto createCompanyDto) //IActionResult sirve para poder devolver un status 
        {
            CompaniesTable result = await _buscadorDbContext.Add(createCompanyDto);
            return new CreatedResult($"http://localhost:7030/api/company/{result.IdCompany}", null); //CreatedResult se utiliza para los metodos post y devolver el status
        }
    }
}
