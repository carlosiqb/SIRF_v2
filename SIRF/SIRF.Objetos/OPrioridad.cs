using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OPrioridad
    /// </summary>
    [Serializable]
    public class OPrioridad
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int PrioridadID { get; set; }
        /// <summary>
        /// Prioridad
        /// </summary>
        public string DescripcionPrioridad { get; set; }
        /// <summary>
        /// Estatus lógico
        /// </summary>
        public bool EstatusLogico { get; set; }
    }
}
