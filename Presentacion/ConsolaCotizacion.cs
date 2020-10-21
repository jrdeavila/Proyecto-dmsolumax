using BLL;
using Entity;
using System;
using System.Collections.Generic;

namespace Presentacion
{
    public class ConsolaCotizacion : Consola
    {
        public EmpleadoServices EmpleadoServices = new EmpleadoServices();

        public ConsolaCotizacion() : base()
        {
            Services = new CotizacionServices();
        }

        public override IDato Buscar()
        {
            throw new NotImplementedException();
        } 

        public override IDato Diligenciar()
        {
            long codigo = ((CotizacionServices)Services).Conteo;
            List<Empleado> empleadosParticipantes = new List<Empleado>();
            List<Empleado> empleadosDisponibles = EmpleadoServices.EmpleadosRegistrados;
            string nombreProyecto;
            DateTime tiempoRealizacion;
            Cliente cliente;
            List<Servicio> serviciosDelProyecto;
            cliente = DiligenciarCliente();
            ValidarCliente(cliente);
            
            throw new NotImplementedException();
        }

        public Cliente DiligenciarCliente()
        {
            string nombre, sexo;
            long cedula;
            int edad;

            Console.Write("Nombre: "); nombre = Console.ReadLine();
            cedula = (long)Extras.IsNumber("Cedula: ");
            edad = (int)Extras.IsNumber("Edad: ");
            sexo = Extras.Sexo();

            return new Cliente(nombre, edad, cedula, sexo);
        }

        public void ValidarCliente(Cliente Cliente){
            string opcion = Extras.SiNo("La informacion esta correcta?");
            if(opcion.Equals("S")) ValidarCliente(DiligenciarCliente());
        }

        public override void Eliminar()
        {
            throw new NotImplementedException();
        }

        public override int Menu()
        {
            throw new NotImplementedException();
        }

        public override void Modificar()
        {
            throw new NotImplementedException();
        }

        public override void MostrarInformacion(IDato Dato)
        {
            throw new NotImplementedException();
        }

        public override void AsignarServicio()
        {
            Services = new CotizacionServices();
        }
    }
}


