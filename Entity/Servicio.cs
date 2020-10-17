using System;
using System.Collections.Generic;

namespace Entity
{
    public abstract class Servicio
    {
        public List<Material> MaterialesServicio {get;set;}
        public double ValorTotal {get;set;}
        public Servicio(List<Material> materialesServicio)
        {
            MaterialesServicio = materialesServicio;
            CalcularValorTotal();
        }

        public abstract void CalcularValorTotal(); 
    }
}