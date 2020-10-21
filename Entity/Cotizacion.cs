using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Entity
{
    public class Cotizacion : IDato
    {
        public List<Servicio> ServiciosDelProyecto { get; set; }
        public List<Empleado> EmpleadosParticipantes { get; set; }
        public Cliente Cliente { get; set; }
        public string NombreProyecto { get; set; }
        public long Codigo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public DateTime TiempoRealizacion { get; set; }

        [JsonConstructor]
        public Cotizacion(long codigo, string nombreProyecto, Cliente cliente, List<Servicio> serviciosDelProyecto, List<Empleado> empleadosParticipantes, DateTime tiempoRealizacion)
        {
            NombreProyecto = nombreProyecto;
            Cliente = cliente;
            ServiciosDelProyecto = serviciosDelProyecto;
            EmpleadosParticipantes = empleadosParticipantes;
            TiempoRealizacion = tiempoRealizacion;
            Codigo = codigo;
        }

        public long CodigoDato()
        {
            return Codigo;
        }
    }
}
