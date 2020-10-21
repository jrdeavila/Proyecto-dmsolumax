using Newtonsoft.Json;
namespace Entity
{
    public class Empleado : Persona, IDato
    {
        public double SaldoDiario {get;set;}
        [JsonConstructor]
        public Empleado(string nombre, int edad, long cedula, string sexo, double saldoDiario) : base(nombre,cedula,edad,sexo)
        {
            SaldoDiario = saldoDiario;
        }

        public long CodigoDato()
        {
            return Cedula;
        }
    }
}
