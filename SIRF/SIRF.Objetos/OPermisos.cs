using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo  OPermisos
    /// </summary>
    [Serializable]
    public class OPermisos
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<OModulo> Modulos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<OSubModulo> SubModulos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<OAccion> Acciones { get; set; }
    }
}
