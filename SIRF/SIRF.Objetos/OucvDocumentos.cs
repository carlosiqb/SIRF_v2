using System;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo ucvDocumentos
    /// </summary>
    [Serializable]
    public class OucvDocumentos
    {
        /// <summary>
        /// Propiedad Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Propiedad TipoDocumento
        /// </summary>
        public string TipoDocumento { get; set; }
        /// <summary>
        /// Propiedad FechaAdjunto
        /// </summary>
        public DateTime? FechaAdjunto { get; set; }
        /// <summary>
        /// Propiedad NombreArchivo
        /// </summary>
        public string NombreArchivo { get; set; }
        /// <summary>
        /// Propiedad TipoDocumentoId
        /// </summary>
        public int TipoDocumentoId { get; set; }
        /// <summary>
        /// Propiedad prefijo
        /// </summary>
        public string prefijo { get; set; }
        /// <summary>
        /// Propiedad EstatusSolicitudID
        /// </summary>
        public int EstatusSolicitudID { get; set; }
    }
}
