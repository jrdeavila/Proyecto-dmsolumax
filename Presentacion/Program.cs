using System;
using Entity;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado nuevoEmpleado = new Empleado("jose ricardo", 19, 1003316620, "M", 50000);
            MostrarInformacionEmpleado(nuevoEmpleado);
        }

        public static void MostrarInformacionEmpleado(Empleado Empleado)
        {
            Console.WriteLine("Nombre: {0}", Empleado.Nombre);
            Console.WriteLine("Cedula: {0}", Empleado.Cedula);
            Console.WriteLine("Edad: {0}", Empleado.Edad);
            Console.WriteLine("Sexo: {0}", Empleado.Sexo);
            Console.WriteLine("Salario Diario: {0}", Empleado.SaldoDiario);
        }
    }
}
