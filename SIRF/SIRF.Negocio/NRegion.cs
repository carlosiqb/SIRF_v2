using SIRF.Utilerias;
using SIRF.Objetos;
using SIRF.Persistencia;
using System.Collections.Generic;

namespace SIRF.Negocio
{
    public class NRegion : Instance<NRegion>
    {
        public List<OSelect> ObtenerListaTodas()
        {
            DRegion tipo = new DRegion();
            return tipo.ObtenerListaTodas();
        }
    }
}
