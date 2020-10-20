using Entity;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System;

namespace DAL
{
    public class EmpleadoRepository : Repository
    {
        public List<Empleado> EmpleadosRegistrados{get;set;}
        
        public EmpleadoRepository() : base()
        {
            Path = "EmpleadosRepository.json";
        }
        public override void GenerarSerialJson()
        {
            throw new NotImplementedException();
        }

        public override void DeserializarObjeto()
        {
            throw new NotImplementedException();
        }
    }
}
