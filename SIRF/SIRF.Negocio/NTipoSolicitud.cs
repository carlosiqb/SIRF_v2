using SIRF.Utilerias;
using SIRF.Objetos;
using SIRF.Persistencia;
using System.Collections.Generic;

namespace SIRF.Negocio
{
    /// <summary>
    /// Clase de negocio correspondiente al catalogo de Tipo de Solicitud.
    /// </summary>
    public class NTipoSolicitud : Instance<NTipoSolicitud>
    {
        /// <summary>
        /// Consulta tipo de solicitudes : Author JUVA
        /// </summary>
        /// <param name="regionID">Filtro</param>
        /// <param name="soloActivas">Filtro</param>
        /// <returns>Tipos de solicitud</returns>
        public List<OSelect> ObtenerLista(int regionID, bool soloActivas = false)
        {
            DTipoSolicitud tipoSolicitud = new DTipoSolicitud();
            return tipoSolicitud.ObtenerLista(regionID, soloActivas);
        }

        public List<OTipoSolicitud> ObtenerLista()
        {
            DTipoSolicitud tipoSolicitud = new DTipoSolicitud();
            return tipoSolicitud.ObtenerLista();
        }

        public List<OTipoSolicitud> ObtenerLista(int regionID, int codUa, bool soloActivas)
        {
            var tipoSolicitud = new DTipoSolicitud();
            return tipoSolicitud.ObtenerLista(regionID, codUa, soloActivas);
        }
    }
}
