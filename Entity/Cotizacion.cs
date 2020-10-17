using System;
using System.Collections.Generic;
namespace Entity
{
    public class Cotizacion
    {
        public List<Servicio> ServiciosDelProyecto {get;set;}
        public List<Empleado> EmpleadosParticipantes {get;set;}
        public Cliente Cliente {get;set;}
        public string NombreProyecto {get;set;}

        public DateTime FechaInicio {get;set;}
        public DateTime FechaFinalizacion {get;set;}
        public DateTime TiempoRealizacion {get;set;}

        public Cotizacion(string nombreProyecto, Cliente cliente, List<Servicio> serviciosDelProyecto, List<Empleado> empleadosParticipantes, DateTime tiempoRealizacion)
        {
            NombreProyecto = nombreProyecto;
            Cliente = cliente;
            ServiciosDelProyecto = serviciosDelProyecto;
            EmpleadosParticipantes = empleadosParticipantes;
            TiempoRealizacion = tiempoRealizacion;
        }
    }
}