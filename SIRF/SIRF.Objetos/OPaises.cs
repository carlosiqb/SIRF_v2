using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    [Serializable]
    public class OPaises
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int PaisID { get; set; }
        /// <summary>
        /// Pais
        /// </summary>
        public string DescripcionPais { get; set; }
        /// <summary>
        /// Tipo control
        /// </summary>
        public int? TipoControl { get; set; }
        /// <summary>
        /// Estatus lógico
        /// </summary>
        public bool EstatusLogico { get; set; }
    }
}
