using System;

namespace Entity
{
    public class Cliente : Persona
    {
        public Cliente(string nombre, int edad, long cedula, string sexo) : base(nombre,cedula,edad,sexo)
        {
            
        }
    }
}