using System;
using Newtonsoft.Json;
using System.IO;

namespace DAL
{
    public abstract class Repository
    {
        public bool EstadoDatos{get;set;}
        public string SerialJson{get;set;}
        public string Path {get;set;}
        public abstract void GenerarSerialJson();
        public abstract void DeserializarObjeto();

        public Repository()
        {}

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
