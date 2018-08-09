using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo Ipv4
    /// </summary>
    [Serializable]
    public class OIpv4
    {
        /// <summary>
        /// Propiedad Ipv4ID.
        /// </summary>
        public int Ipv4ID { get; set; }
        /// <summary>
        /// Propiedad usuarioID.
        /// </summary>
        public int usuarioID { get; set; }
        /// <summary> 
        /// Propiedad IP
        /// </summary>
        public string ip { get; set; }
        /// <summary>
        /// Propiedad EstatusLogico.
        /// </summary>
        public bool EstatusLogico { get; set; }
    }
}
