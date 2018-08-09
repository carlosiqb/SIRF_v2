using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OTipoDocumento 
    /// </summary>
    [Serializable]
    public class OTipoDocumento
    {
        // <summary>
        /// Identificador
        /// </summary>
        public int? TipoDocumentoID { get; set; }
        /// <summary>
        /// Identificador único del tipo de solicitud.
        /// </summary>
        public int tipoSolicitudID { get; set; }
        /// <summary>
        /// Tipo documento
        /// </summary>
        public string DescripcionTipoDoc { get; set; }
        /// <summary>
        /// Prefijo
        /// </summary>
        public string Prefijo { get; set; }
        /// <summary>
        /// Estatus lógico
        /// </summary>
        public bool EstatusLogico { get; set; }
    }
}
