using System;
using System.Collections.Generic;
namespace Entity
{
    public class ServicioManoDeObra : Servicio
    {
        public ServicioManoDeObra(List<Material> materialesServicio) : base(materialesServicio)
        {}

        public override void CalcularValorTotal()
        {
            double aux = 0;
            foreach(Material i in MaterialesServicio)
            {
             aux += i.CostoTotalManoObra;   
            }
            ValorTotal = aux;
        }
    }
}