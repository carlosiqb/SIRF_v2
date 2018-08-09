using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OEstatusMovimiento
    /// </summary>
    [Serializable]
    public class OEstatusMovimiento
    {
        /// <summary>
        /// Propiedad estatusMovimientoID
        /// </summary>
        public int EstatusMovimientoID { get; set; }
        /// <summary>
        /// Propiedad solicitudID
        /// </summary>
        public int SolicitudID { get; set; }
        /// <summary>
        /// Propiedad usuarioID
        /// </summary>
        public int UsuarioID { get; set; }
        /// <summary>
        /// Propiedad fechaMovimiento
        /// </summary>
        public DateTime FechaMovimiento { get; set; }
        /// <summary>
        /// Propiedad observaciones
        /// </summary>
        public string Observaciones { get; set; }
        /// <summary>
        /// Propiedad movimiento
        /// </summary>
        public string Movimiento { get; set; }
        /// <summary>
        /// Propiedad usuario
        /// </summary>
        public string Usuario { get; set; }
        /// <summary>
        /// Propiedad fecha
        /// </summary>
        public string Fecha { get { return FechaMovimiento.ToString("dd/MM/yyyy"); } }
        /// <summary>
        /// Propiedad Modulo
        /// </summary>
        public string Modulo { get; set; }
    }
}