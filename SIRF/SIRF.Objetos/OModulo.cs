using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    ///  Objeto de tipo OModulo.
    /// </summary>
    [Serializable]
    public class OModulo
    {
        /// <summary>
        /// Propiedad ModuloID.
        /// </summary>
        public int ModuloID { get; set; }
        /// <summary>
        /// Propiedad DescripcionModulo.
        /// </summary>
        public string DescripcionModulo { get; set; }
        /// <summary>
        /// Propiedad EstatusLogico.
        /// </summary>
        public bool EstatusLogico { get; set; }
    }
}
