using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OConceptoGastos
    /// </summary>
    [Serializable]
    public class OConceptoGastos
    {
        /// <summary>
        /// Porpiedad conceptoGastosID
        /// </summary>
        public int conceptoGastosID { get; set; }
        /// <summary>
        /// Propiedad descripcionConceptoGasto
        /// </summary>
        public string descripcionConceptoGasto { get; set; }
        /// <summary>
        ///  propiedad tipoSolicitudID
        /// </summary>
        public int tipoSolicitudID { get; set; }
        /// <summary>
        /// propiedad estatusLogico
        /// </summary> 
        public bool estatusLogico { get; set; }
    }
}
