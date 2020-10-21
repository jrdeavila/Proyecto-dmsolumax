using System;
using System.IO;

namespace DAL
{
    public abstract class Repository
    {
        public bool EstadoDatos{get;set;}
        public string SerialJson{get;set;}
        public string Path {get;set;}
        public Repository()
        {
            DeclararElPath();
            if(File.Exists(Path))
            {
                ObtenerSerialJsonDelRepositorio();
                if(SerialJson != "[]") DeserializarObjeto();
                else File.Delete(Path);
            }
        }
        public void ActualizarDatosRepository()
        {
            GenerarSerialJson();
            if(SerialJson != "[]") GuardarSerialJsonEnRepositorio();
            else File.Delete(Path);
        }
        public abstract void DeclararElPath();
         public abstract void GenerarSerialJson();
         public abstract void DeserializarObjeto();
        public void GuardarSerialJsonEnRepositorio(){
            using(StreamWriter writer = File.CreateText(Path)){
                writer.Write(SerialJson);
            }
        }
        public void ObtenerSerialJsonDelRepositorio(){
            using(StreamReader reader = File.OpenText(Path)){
                SerialJson = reader.ReadToEnd();
            }
        }

    }
}
