using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OUnidadAdministrativa
    /// </summary>
    [Serializable]
    public class OUnidadAdministrativa
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int CodUA { get; set; }
        /// <summary>
        /// Catálogo región
        /// </summary>
        public ORegion Region { get; set; }
        /// <summary>
        /// Unidad administrativa
        /// </summary>
        public string UnidadAdministrativa { get; set; }
        /// <summary>
        /// Codigo padre
        /// </summary>
        public int? CodigoPadre { get; set; }
        /// <summary>
        /// Abreviatura
        /// </summary>
        public string Abreviatura { get; set; }
        /// <summary>
        /// Activo
        /// </summary>
        public bool Activo { get; set; }
    }
}