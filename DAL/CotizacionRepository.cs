using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Entity;

namespace DAL
{
    public class CotizacionRepository : Repository
    {
        public List<Cotizacion> CotizacionesRegistradas {get;set;}

        public CotizacionRepository() : base()
        {
        }
        public override void DeserializarObjeto()
        {
            CotizacionesRegistradas = JsonConvert.DeserializeObject<List<Cotizacion>>(SerialJson);
        }

        public override void GenerarSerialJson()
        {
            SerialJson = JsonConvert.SerializeObject(CotizacionesRegistradas, Formatting.Indented);
        }

        public override void DeclararElPath()
        {
            Path = "CotizacionesRepository.json";
        }
    }
}
