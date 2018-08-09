using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OHomologado
    /// </summary>
    [Serializable]
    public class OHomologado
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int? HomologadoID { get; set; }
        /// <summary>
        /// Importe homologado
        /// </summary>
        public decimal ImporteHomologado { get; set; }
        /// <summary>
        /// Número de expediente
        /// </summary>
        public string NumeroExpediente { get; set; }
    }
}
