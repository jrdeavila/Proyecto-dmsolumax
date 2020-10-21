using System;
using Entity;
using BLL;

namespace Presentacion
{
    public class ConsolaEmpleado : Consola
    {
        public ConsolaEmpleado() : base()
        {}

        public override int Menu()
        {
            Console.Clear();
            Console.WriteLine("\t\tGestionar empleados\n");
            Console.WriteLine("Agregar...............(1)");
            Console.WriteLine("Buscar................(2)");
            Console.WriteLine("Eliminar..............(3)\n");
            Console.WriteLine("Salir.................(0)\n");
            return (int)Extras.IsNumber("Seleccione: ");
        }
        public override IDato Diligenciar()
        {
            Console.Clear();
            string nombre, sexo;
            long cedula;
            int edad;
            double salarioDiario;
            Console.Write("Nombre: "); nombre = Console.ReadLine();
            cedula = (long)Extras.IsNumber("Cedula: ");
            edad = (int)Extras.IsNumber("Edad: ");
            sexo = Extras.Sexo();
            salarioDiario = Extras.IsNumber("Salario diario: ");
            return new Empleado(nombre, edad, cedula, sexo, salarioDiario);
        }
        
        public override void MostrarInformacion(IDato Dato)
        {
            try
            {
                Empleado Empleado = (Empleado)Dato;
                Console.WriteLine("Nombre: {0}", Empleado.Nombre);
                Console.WriteLine("Cedula: {0}", Empleado.Cedula);
                Console.WriteLine("Edad: {0}", Empleado.Edad);
                Console.WriteLine("Sexo: {0}", Empleado.Sexo);
                Console.WriteLine("Salario Diario: {0}", Empleado.SaldoDiario);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No hay informacion de este empleado");
            }

        }
        public override void Eliminar()
        {
            throw new NotImplementedException();
        }

        public override IDato Buscar()
        {
            throw new NotImplementedException();
        }

        public override void Modificar()
        {
            throw new NotImplementedException();
        }

        public override void AsignarServicio()
        {
            Services = new EmpleadoServices();
        }
    }
}
