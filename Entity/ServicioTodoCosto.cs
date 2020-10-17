using System;
using System.Collections.Generic;
namespace Entity
{
    public class ServicioTodoCosto : Servicio
    {
        public ServicioTodoCosto(List<Material> materialesServicio) : base(materialesServicio)
        {}

        public override void CalcularValorTotal()
        {
            double aux = 0;
            foreach(Material i in MaterialesServicio)
            {
                aux += i.CostoTotalTodoCosto;
            }
            ValorTotal = aux;
        }
    }
}