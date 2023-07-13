using Microsoft.EntityFrameworkCore;
using ProyectoDinamyt.Repository.Acess;
using ProyectoDinamyt.Repository.Tables;
using System;
using System.Linq;
using System.Threading.Tasks;
using ProyectoDinamyt.Repository.Imp;


namespace ProyectoDinamyt.Repository
{
    public class UserValidationRespository : IUserValidationRepository
    {
        private readonly BuscadorDbContext _context;
        public UserValidationRespository(BuscadorDbContext context)
        {
            _context = context;
        }
        public async Task<UsersTable> Get(string email, string password)
        {
            // Realiza la lógica para obtener el usuario de acuerdo con el correo electrónico y la contraseña proporcionados
            UsersTable user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email && x.Pass == password);
            return user;
        }
        public async Task<UsersTable> Get(long id)
        {
            try
            {
                UsersTable user = await _context.Users.FirstOrDefaultAsync(x => x.IdUser == id);
                return user;
            }
            catch (Exception ex)
            {
                // Manejo de errores si es necesario
                // Puedes registrar el error o lanzar una excepción personalizada
                throw new Exception("Error al obtener el usuario", ex);
            }
        }

        public Task<bool> ValidateUserAsync(string Email, string Pass)
        {
            throw new NotImplementedException();
        }
    }
}
