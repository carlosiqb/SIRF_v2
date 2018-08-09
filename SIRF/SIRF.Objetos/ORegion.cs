using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo ORegion
    /// </summary>
    [Serializable]
    public class ORegion
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int RegionID { get; set; }
        /// <summary>
        /// Región
        /// </summary>
        public string DescripcionRegion { get; set; }
        /// <summary>
        /// Estatus lógico
        /// </summary>
        public bool EstatusLogico { get; set; }
    }
}
