using SIRF.Utilerias;
using System.Collections.Generic;
using SIRF.Persistencia;
using SIRF.Objetos;

namespace SIRF.Negocio
{
    /// <summary>
    /// Clase de la capa de negocios correspondiente a NSolicitud
    /// </summary>
    public class NSolicitud : Instance<NSolicitud>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<OSolicitud> ObtenerSolicitudesVentanillaUnica(OSolicitud filtro)
        {
            DSolicitud solicitudNegocio = new DSolicitud();
            return solicitudNegocio.ObtenerSolicitudesVentanillaUnica(filtro);
        }
    }
}
