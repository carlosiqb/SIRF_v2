using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OFaltasIntegrante
    /// </summary>
    public class OFaltasIntegrante
    {
        /// <summary>
        /// Propiedad incidenciaID
        /// </summary>
        public int incidenciaID { get; set; }
        /// <summary>
        /// Propiedad expediente
        /// </summary>
        public int expediente { get; set; }
        /// <summary>
        /// Propiedad tipoIncidencia
        /// </summary>
        public string tipoIncidencia { get; set; }
        /// <summary>
        /// Propiedad fechaInicidencia
        /// </summary>
        public System.DateTime fechaInicidencia { get; set; }
    }
}
