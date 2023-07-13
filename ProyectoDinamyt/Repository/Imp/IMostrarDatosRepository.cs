using ProyectoDinamyt.Models;

namespace ProyectoDinamyt.Repository.Imp
{
    public interface IMostrarDatosRepository
    {
        CantidadModels GetCantidadModels(string nombre);
        
    }
}
