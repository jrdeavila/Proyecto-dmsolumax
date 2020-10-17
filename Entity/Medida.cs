using System;

namespace Entity
{
    public abstract class Medida
    {
        public double CantidadMetros {get;set;}
        public double CostoPorMetro {get;set;}

        protected Medida(double cantidadMetros, double costoPorMetro)
        {
            CantidadMetros = cantidadMetros;
            CostoPorMetro = costoPorMetro;
        }
        
        public abstract double CalcularCostoTotal();
    }
}