using System;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OTipoSolicitud
    /// </summary>
    [Serializable]
    public class OTipoSolicitud
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int TipoSolicitudID { get; set; }
        /// <summary>
        /// Catálogo región
        /// </summary>
        public ORegion Region { get; set; }
        /// <summary>
        /// Tipo solicitud
        /// </summary>
        public string DescripcionTipoSolicitud { get; set; }
        /// <summary>
        /// Control COD
        /// </summary>
        public int TipoSolicitudControlCod { get; set; }
        /// <summary>
        /// Estatus lógico
        /// </summary>
        public bool EstatusLogico { get; set; }
        /// <summary>
        /// Aare de pago
        /// </summary>
        public string AreaPago { get; set; }



        /// <summary>
        /// Constructor
        /// </summary>
        public OTipoSolicitud()
        {
            Region = new ORegion();
        }
    }
}
