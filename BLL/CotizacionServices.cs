using System.Collections.Generic;
using DAL;
using Entity;

namespace BLL
{
    public class CotizacionServices : DatoServices
    {
        public List<Cotizacion> CotizacionesRegistradas { get; set; }
        public int Conteo { get; set; }
        public CotizacionServices()
        {
            Repository = new CotizacionRepository();
            CotizacionesRegistradas = ((CotizacionRepository)Repository).CotizacionesRegistradas;
            if (CotizacionesRegistradas == null) CotizacionesRegistradas = new List<Cotizacion>();
            ObtenerConteo();
        }
        public override void ActualizarDatos()
        {
            ((CotizacionRepository)Repository).CotizacionesRegistradas = CotizacionesRegistradas;
            Repository.ActualizarDatosRepository();
        }

        public override bool Agregar(IDato objeto)
        {
            Cotizacion cotizacion = (Cotizacion)Buscar(((Cotizacion)objeto).Codigo);
            if (cotizacion == null)
            {
                CotizacionesRegistradas.Add((Cotizacion)objeto);
                ActualizarDatos();
                return true;
            }
            return false;
        }

        public override IDato Buscar(long codigo)
        {
            foreach (Cotizacion i in CotizacionesRegistradas)
            {
                if (i.Codigo == (long)codigo) return i;
            }
            return null;
        }

        public override bool Eliminar(long codigo)
        {
            Cotizacion cotizacion = (Cotizacion)Buscar(codigo);
            if (CotizacionesRegistradas.Contains(cotizacion))
            {
                CotizacionesRegistradas.Remove(cotizacion);
                return true;
            }
            return false;
        }

        public void ObtenerConteo()
        {
            Conteo = CotizacionesRegistradas.Count + 1;
        }
    }
}
