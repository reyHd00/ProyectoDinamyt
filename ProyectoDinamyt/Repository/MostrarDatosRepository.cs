using ProyectoDinamyt.Models;
using ProyectoDinamyt.Repository.Acess;
using ProyectoDinamyt.Repository.Tables;
using ProyectoDinamyt.Repository.Imp;

namespace ProyectoDinamyt.Repository
{
    public class MostrarDatosRepository : IMostrarDatosRepository
    {
        private BuscadorDbContext _context;
        public MostrarDatosRepository(BuscadorDbContext context)
        {
            _context = context;
        }
        public CantidadModels GetCantidadModels(string username)
        {
            var cantidad = _context.Users.Where(x => x.Username == username).FirstOrDefault();

            if (cantidad != null)
            {
                CantidadModels cantidadModels = new();

                cantidadModels.IdUser = cantidad.IdUser;
                cantidadModels.Username = cantidad.Username;
                cantidadModels.Email = cantidad.Email;
                cantidadModels.Pass = cantidad.Pass;

                return cantidadModels;

            }

            return null;
        }

        

    }
}
