using Newtonsoft.Json;
namespace Entity
{
    public class Empleado : Persona
    {
        public double SaldoDiario {get;set;}
        [JsonConstructor]
        public Empleado(string nombre, int edad, long cedula, string sexo, double saldoDiario) : base(nombre,cedula,edad,sexo)
        {
            SaldoDiario = saldoDiario;
        }

    }
}
