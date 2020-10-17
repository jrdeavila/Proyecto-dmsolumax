using System;
using System.Collections.Generic;

namespace Entity
{
    public class Administrador : Persona
    {
        public Administrador(string nombre, int edad, long cedula, string sexo) : base(nombre,cedula,edad,sexo)
        {}
        
    }
}