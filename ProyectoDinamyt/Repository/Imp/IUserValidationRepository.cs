
using ProyectoDinamyt.Repository.Tables;

namespace ProyectoDinamyt.Repository.Imp
{
    public interface IUserValidationRepository
    {
        Task<bool> ValidateUserAsync(string Email, string Pass);

        Task<UsersTable> Get(string email, string password);
    };
}
