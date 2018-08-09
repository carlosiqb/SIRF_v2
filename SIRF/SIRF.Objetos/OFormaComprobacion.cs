using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    [Serializable]
    public class OFormaComprobacion
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int idFormaComprobacion { get; set; }
        /// <summary>
        /// Descripcion formas de comprobacion
        /// </summary>
        public string FormaComprobacion { get; set; }
        /// <summary>
        /// Estatus lógica
        /// </summary>
        public bool estatusLogico { get; set; }
    }
}
