using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ProyectoDinamyt.Repository.Tables;

namespace ProyectoDinamyt.Repository.Acess
{
    public class BuscadorDbContext : DbContext
    {
    
        public BuscadorDbContext(DbContextOptions<BuscadorDbContext> options) : base(options)
        {

        }
        public DbSet<UsersTable> Users { get; set; }

        
    }
}
