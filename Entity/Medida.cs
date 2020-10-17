using System;

namespace Entity
{
    public class Medida
    {
        public double CantidadMetros {get;set;}
        public double CostoPorMetro {get;set;}
        public double CostoTotal{get;set;}
        protected Medida(double cantidadMetros, double costoPorMetro)
        {
            CantidadMetros = cantidadMetros;
            CostoPorMetro = costoPorMetro;
            CalcularCostoTotal();
        }
        
        public void CalcularCostoTotal(){ CostoTotal = CantidadMetros*CostoPorMetro; }
    }
}