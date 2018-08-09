using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OLogin
    /// </summary>
    [Serializable]
    public class OLogin
    {
        /// <summary>
        /// 
        /// </summary>
        public OUsuario Usuario { get; set; }
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

        public string Cuenta { get; set; }

        public string Password { get; set; }
    }
}
