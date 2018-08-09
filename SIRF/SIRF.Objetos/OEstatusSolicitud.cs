using System;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OEstatusSolicitud
    /// </summary>
    [Serializable]
    public class OEstatusSolicitud
    {
        /// <summary>
        /// Propiedad Identificador
        /// </summary>
        public short EstatusID { get; set; }
        /// <summary>
        /// Propiedad Descripción
        /// </summary>
        public string DescripcionEstatus { get; set; }
        /// <summary>
        /// Propiedad Descripción corta
        /// </summary>
        public string DescripcionCorta { get; set; }
        /// <summary>
        /// Propiedad Estatus lógico
        /// </summary>
        public bool EstatusLogico { get; set; }
        /// <summary>
        /// Propiedad estatusSiguiente
        /// </summary>
        public int? EstatusSiguiente { get; set; }
        /// <summary>
        /// Propiedad estatusDevolucion
        /// </summary>
        public int? EstatusDevolucion { get; set; }
        /// <summary>
        /// Propiedad estatusAlternativo
        /// </summary>
        public int? EstatusAlternativo { get; set; }
        /// <summary>
        /// Propiedad estatusAltDev
        /// </summary>
        public int? EstatusAltDev { get; set; }
    }
}
