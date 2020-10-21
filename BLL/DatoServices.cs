using DAL;
using Entity;

namespace BLL
{
    public abstract class DatoServices
    {
        public Repository Repository { get; set;}

        public abstract bool Agregar(IDato objeto);
        public abstract bool Eliminar(long codigo);
        public abstract IDato Buscar(long codigo);

        public abstract void ActualizarDatos();
    }
}
