using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OIncidenciasIntegrante
    /// </summary>
    public class OIncidenciasIntegrante
    {
        /// <summary>
        /// Propiedad expediente
        /// </summary>
        public Nullable<int> expediente { get; set; }
        /// <summary>
        /// Propiedad tipoIncidencia
        /// </summary>
        public string tipoIncidencia { get; set; }
        /// <summary>
        /// Propiedad fechaInicial
        /// </summary>
        public Nullable<System.DateTime> fechaInicial { get; set; }
        /// <summary>
        /// Propiedad fechaFinal
        /// </summary>
        public Nullable<System.DateTime> fechaFinal { get; set; }
    }
}
