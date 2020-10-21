using DAL;
using System.Collections.Generic;
using Entity;

namespace BLL
{
    public class EmpleadoServices : DatoServices
    {
        public List<Empleado> EmpleadosRegistrados {get;set;}
        public EmpleadoServices() : base()
        {
            Repository = new EmpleadoRepository();
            EmpleadosRegistrados = ((EmpleadoRepository)Repository).EmpleadosRegistrados;
            if(EmpleadosRegistrados == null) EmpleadosRegistrados = new List<Empleado>();
        }

        public override void ActualizarDatos(){
            ((EmpleadoRepository)Repository).EmpleadosRegistrados = EmpleadosRegistrados;
            Repository.ActualizarDatosRepository();
        }

        public override bool Agregar(IDato objeto){
            Empleado empleado = (Empleado)objeto;
            empleado = ((Empleado)Buscar(empleado.Cedula));
            if(empleado == null){
                EmpleadosRegistrados.Add((Empleado)objeto);
                ActualizarDatos();
                return true;
            }
            return false;
        }
        public override IDato Buscar(long codigo){
            foreach(Empleado i in EmpleadosRegistrados){
                if(i.Cedula == codigo) return i;
            }
            return null;
        }

        public override bool Eliminar(long codigo){
            Empleado empleado = (Empleado)Buscar(codigo);
            if(EmpleadosRegistrados.Contains(empleado))
            {
                EmpleadosRegistrados.Remove(empleado);
                ActualizarDatos();
                return true;
            }
            return false;
        }
    }
}
