using Entity;
using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace DAL
{
    public class EmpleadoRepository : Repository
    {
        public List<Empleado> EmpleadosRegistrados{get;set;}
        
        public EmpleadoRepository() : base()
        {
        }
        public override void GenerarSerialJson()
        {
            SerialJson = JsonConvert.SerializeObject(EmpleadosRegistrados, Formatting.Indented);
        }

        public override void DeserializarObjeto()
        {
            try
            {
                EmpleadosRegistrados = JsonConvert.DeserializeObject<List<Empleado>>(SerialJson);
                EstadoDatos = true;
            }
            catch(Exception)
            {
                EstadoDatos = false;
                EmpleadosRegistrados = null;
            }
        }

        public override void DeclararElPath()
        {
            Path = "EmpleadosRepository.json";
        }
    }
}
