using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OEvento
    /// </summary>
    [Serializable]
    public class OEvento
    {
        /// <summary>
        /// Propiedad  EventoId
        /// </summary>
        public int? EventoId { get; set; }
        /// <summary>
        /// Propiedad  CveEvento
        /// </summary>
        public string CveEvento { get; set; }
        /// <summary>
        /// Propiedad DescEvento
        /// </summary>
        public string DescEvento { get; set; }
        /// <summary>
        /// Propiedad DescLargaEvento
        /// </summary>
        public string DescLargaEvento { get; set; }
        /// <summary>
        /// Propiedad ModuloId
        /// </summary>
        public int? ModuloId { get; set; }
        /// <summary>
        /// Propiedad PerfilId
        /// </summary>
        public int? PerfilId { get; set; }
        /// <summary>
        /// Propiedad EstatusLogico
        /// </summary>
        public bool? EstatusLogico { get; set; }
    } 
}
