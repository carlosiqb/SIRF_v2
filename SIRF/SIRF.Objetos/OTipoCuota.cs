using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OTipoCuota
    /// </summary>
    [Serializable]
    public class OTipoCuota
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int TipoCuotaID { get; set; }
        /// <summary>
        /// Tipos cuota
        /// </summary>
        public string DescripcionTipoCuota { get; set; }
        /// <summary>
        /// Estatus lógico
        /// </summary>
        public bool EstatusLogico { get; set; }
    }
}
