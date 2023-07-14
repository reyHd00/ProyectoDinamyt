using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Identity.Client;
using ProyectoDinamyt.Dto;
using ProyectoDinamyt.Repository.Tables;

namespace ProyectoDinamyt.Repository.Acess
{
    public class BuscadorDbContext : DbContext
    {
    
        public BuscadorDbContext(DbContextOptions<BuscadorDbContext> options) : base(options)
        {

        }
        public DbSet<UsersTable> Users { get; set; }
        public DbSet<CompaniesTable> Companies { get; set; }

        //a partir de aqui cambios, modificar o comentar por cualquier problema
        public async Task<CompaniesTable> Get(int id)
        {
            return await Companies.FirstAsync(x => x.IdCompany == id);
        }
        //añadir elementos
        public async Task <CompaniesTable> Add(CreateCompanyDto createCompanyDto)
        {
            CompaniesTable companiesTable = new CompaniesTable()
            {
                IdCompany = null,
                CompanyName = createCompanyDto.CompanyName,
                TotalJobs = createCompanyDto.TotalJobs,
                SearchDate = createCompanyDto.SearchDate,
            };
            EntityEntry<CompaniesTable> response = await Companies.AddAsync(companiesTable);
            await SaveChangesAsync();
            return await Get(response.Entity.IdCompany ?? throw new Exception("No se guardo"));
        }
    }
}
