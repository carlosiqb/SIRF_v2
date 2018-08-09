using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OSubModulo 
    /// </summary>
    [Serializable]
    public class OSubModulo
    {
        /// <summary>
        /// Propiedad SubmoduloID
        /// </summary>
        public int SubmoduloID { get; set; }
        /// <summary>
        /// Propiedad Submodulo
        /// </summary>
        public string DescripcionSubModulo { get; set; }
        /// <summary>
        /// Propiedad EstatusLogico
        /// </summary>
        public bool EstatusLogico { get; set; }
        /// <summary>
        /// Propiedad URL
        /// </summary>
        public string Url { get; set; }
        //Se requiere para el MENU para saber cual submenu corresponde a cada menu 
        /// <summary>
        /// Propiedad ModuloID
        /// </summary>
        public int ModuloID { get; set; }
    }
}
