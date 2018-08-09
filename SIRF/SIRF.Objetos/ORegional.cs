using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo ORegional
    /// </summary>
    [Serializable]
    public class ORegional : ITipoSolicitud
    {
        /// <summary>
        /// Propiedad RegionalID
        /// </summary>
        public int RegionalID { get; set; }

        /// <summary>
        /// Propiedad SET
        /// </summary>
        /// <returns></returns>
        public ITipoSolicitud Set()
        {
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        public static implicit operator ORegional(ORegion v)
        {
            throw new NotImplementedException();
        }
    }
}
