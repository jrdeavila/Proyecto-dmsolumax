using BLL;
using Entity;
using System;

namespace Presentacion
{
    public abstract class Consola
    {
        public DatoServices Services { get; set; }

        public Consola()
        {
            AsignarServicio();
            Iniciar();
        }
        public abstract int Menu();
        public abstract IDato Diligenciar();
        public abstract void Eliminar();
        public abstract IDato Buscar();
        public abstract void Modificar();
        public abstract void AsignarServicio();
        public abstract void MostrarInformacion(IDato Dato);
        public void Opciones(int Opcion)
        {
            switch (Opcion)
            {
                case 0: { break; }
                case 1: { Guardar(); Console.ReadKey(); Iniciar(); break; }
                case 2: { Buscar(); Console.ReadKey(); Iniciar(); break; }
                case 3: { Eliminar(); Console.ReadKey(); Iniciar(); break; }
                default: { Modificar(); Console.WriteLine("Opcion invalida"); Console.ReadKey(); Iniciar(); break; }

            }
        }

        public void Guardar()
        {
            IDato Dato = Diligenciar();
            if(Dato == null){
                Console.WriteLine("Ocurrio un error, intente nuevamente");
                Guardar(); 
            }
            else{
                if (Services.Agregar(Dato)) Console.WriteLine("Se ha agregado correctamente");
                else Console.WriteLine("No se ha agregado, esta informacion ya existe");
            }
        }

        public void Iniciar() { Opciones(Menu()); }
    }
}
