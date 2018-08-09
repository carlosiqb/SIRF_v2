using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OMoneda
    /// </summary>
    [Serializable]
    public class OMoneda
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int MonedaID { get; set; }
        /// <summary>
        /// Moneda
        /// </summary>
        public string DescripcionMoneda { get; set; }
        /// <summary>
        /// Código
        /// </summary>
        public string Codigo { get; set; }
        /// <summary>
        /// Estatus lógico
        /// </summary>
        public bool EstatusLogico { get; set; }
    }
}
