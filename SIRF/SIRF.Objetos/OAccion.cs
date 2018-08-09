using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OAccion 
    /// </summary>
    [Serializable]
    public class OAccion
    {
        /// <summary>
        /// Propiedad Identificador
        /// </summary>
        public int AccionID { get; set; }
        /// <summary>
        /// Propiedad Descripción acción
        /// </summary>
        public string DescripcionAccion { get; set; }
        /// <summary>
        /// Propiedad Acción
        /// </summary>
        public string Accion { get; set; }
        /// <summary>
        /// Propiedad controlFormulario
        /// </summary>
        public string controlFormulario { get; set; }
        /// <summary>
        /// Propiedad Estatus lógico
        /// </summary>        
        public bool EstatusLogico { get; set; }
    }
}
