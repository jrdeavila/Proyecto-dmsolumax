using System;

namespace Entity
{
    public class Material
    {
        public double MedidaMaterial {get;set;}
        public Proveedor ProveedorMaterial {get;set;}
        public string TipoMedida {get;set;}
        public string Calidad {get;set;}
        public double CostoManoObraPorMetro {get;set;}
        public double PrecioMaterialPorMetro {get;set;}
        public double CostoTotalManoObra {get;set;}
        public double CostoTotalTodoCosto {get;set;}
        public Material(double medidaMaterial, Proveedor proveedorMaterial, string tipoMedida, string calidad, double costoManoObraPorMetro, double precioMaterialPorMetro)
        {
            MedidaMaterial = medidaMaterial;
            ProveedorMaterial = proveedorMaterial;
            TipoMedida = tipoMedida;
            Calidad = calidad;
            CostoManoObraPorMetro = costoManoObraPorMetro;
            PrecioMaterialPorMetro = precioMaterialPorMetro;
        }

        public void CalcularCostoTotalManoDeObra() 
        {
            CostoTotalManoObra = MedidaMaterial * CostoManoObraPorMetro;
        }

        public void CalcularCostoTotalTodoCosto()
        {
            CostoTotalTodoCosto = MedidaMaterial * PrecioMaterialPorMetro * CostoManoObraPorMetro;
        }

    }
}