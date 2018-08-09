using System;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OSolicitudRecursos
    /// </summary>
    [Serializable]
    public class OSolicitudRecursos
    {
        /// <summary>
        /// Propiedad solicitudID
        /// </summary>
        public int solicitudID { get; set; }
        /// <summary>
        /// Propiedad anio
        /// </summary>
        public int anio { get; set; }
        /// <summary>
        /// Propiedad tipoSolicitudID
        /// </summary>
        public int tipoSolicitudID { get; set; }
        /// <summary>
        /// Propiedad prioridadID
        /// </summary>
        public int prioridadID { get; set; }
        /// <summary>
        /// Propiedad codUA
        /// </summary>
        public int codUA { get; set; }
        /// <summary>
        /// Propiedad estatusID
        /// </summary>
        public short estatusID { get; set; }
        /// <summary>
        /// Propiedad fechaSolicitud
        /// </summary>
        public DateTime fechaSolicitud { get; set; }
        /// <summary>
        /// Propiedad observaciones
        /// </summary>
        public string observaciones { get; set; }
        /// <summary>
        /// Propiedad oficioSolicitud
        /// </summary>
        public string oficioSolicitud { get; set; }
        /// <summary>
        /// Propiedad fechaControl
        /// </summary>
        public DateTime fechaControl { get; set; }
        /// <summary>
        /// Propiedad consecutivo
        /// </summary>
        public int consecutivo { get; set; }
        /// <summary>
        /// Propiedad fechaActualizacion
        /// </summary>
        public DateTime fechaActualizacion { get; set; }
        /// <summary>
        /// Propiedad eventoId
        /// </summary>
        public Nullable<int> eventoId { get; set; }
    }
}
