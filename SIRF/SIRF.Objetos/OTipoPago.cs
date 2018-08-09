using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    [Serializable]
    public class OTipoPago
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int TipoPagoID { get; set; }
        /// <summary>
        /// Tipo pago
        /// </summary>
        public string DescripcionTipoPago { get; set; }
        /// <summary>
        /// Estatus lógica
        /// </summary>
        public bool EstatusLogico { get; set; }

    }
}
