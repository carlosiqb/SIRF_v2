using SIRF.Utilerias;
using SIRF.Objetos;
using SIRF.Persistencia;
using System.Collections.Generic;

namespace SIRF.Negocio
{
    public class NEstadoSolicitud : Instance<NEstadoSolicitud>
    {
        /// <summary>
        /// Catálogo : Author ?
        /// </summary>
        /// <param name="perfilID">Filtro por perfil</param>
        /// <returns>Estatus correspondientes al perfil</returns>
        public List<OSelect> ObtenerLista(int perfilID, bool estatusLogico)
        {
            DEstadoSolicitud estatusSolicitudDatos = new DEstadoSolicitud();
            return estatusSolicitudDatos.ObtenerLista(perfilID, estatusLogico);
        }

        public OEstatusSolicitud ObtenerEstatus(int estatusID)
        {
            DEstadoSolicitud objEstatusSolicitud = new DEstadoSolicitud();
            return objEstatusSolicitud.ObtenerEstatus(estatusID);
        }
    }
}
