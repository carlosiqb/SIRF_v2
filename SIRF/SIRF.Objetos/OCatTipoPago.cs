using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OCatTipoPago
    /// </summary>
    public class OCatTipoPago
    {
        /// <summary>
        /// Propiedad tipoPagoID
        /// </summary>
        public int tipoPagoID { get; set; }
        /// <summary>
        /// Propiedad descripcionTipoPago
        /// </summary>
        public string descripcionTipoPago { get; set; }
        /// <summary>
        /// Propiedad tipoSolicitudControlCod
        /// </summary>
        public int tipoSolicitudControlCod { get; set; }
        /// <summary>
        /// Propiedad estatusLogico
        /// </summary>
        public bool estatusLogico { get; set; }
    }
}
