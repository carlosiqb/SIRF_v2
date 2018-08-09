using SIRF.Utilerias;
using SIRF.Objetos;
using SIRF.Persistencia;
using System.Collections.Generic;

namespace SIRF.Negocio
{
    public class NFirma : Instance<NFirma>
    {
        public List<OFirma> ObtenerListaTodas()
        {
            DFirma tipo = new DFirma();
            return tipo.ObtenerListaTodas();
        }
    }
}
