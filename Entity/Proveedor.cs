using System;

namespace Entity
{
    public class Proveedor
    {
        public long CodigoProveedor {get;set;}
        public string NombreProveedor {get;set;}

        public Proveedor(long codigoProveedor, string nombreProveedor)
        {
            CodigoProveedor = codigoProveedor;
            NombreProveedor = nombreProveedor;
        }
    }
}