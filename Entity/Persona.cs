using System;

namespace Entity
{
    public abstract class Persona
    {
        public string Nombre {get;set;}
        public long Cedula {get;set;}
        public int Edad {get;set;}
        public string Sexo {get;set;}

        protected Persona(string nombre, long cedula, int edad, string sexo)
        {
            Nombre = nombre;
            Cedula = cedula;
            Edad = edad;
            Sexo = sexo;
        }
    }
}
