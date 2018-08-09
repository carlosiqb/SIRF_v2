using System;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo ObjetoBusquedaParametro.
    /// </summary>
    [Serializable]
    public class OBusquedaParametro
    {
        /// <summary>
        /// Propiedad TipoBusqueda.
        /// </summary>
        public int TipoBusqueda { get; set; }
        /// <summary>
        /// Propiedad TipoSolicitudID
        /// </summary>
        public int TipoSolicitudID { get; set; }
        /// <summary>
        /// Propiedad ExpedienteID
        /// </summary>
        public int ExpedienteID { get; set; }
        /// <summary>
        /// Propiedad UsuarioID
        /// </summary>
        public int UsuarioID { get; set; }
        /// <summary>
        /// Propiedad PerfilID
        /// </summary>
        public int? PerfilID { get; set; }
        /// <summary>
        /// Propiedad Descripcion
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Propiedad NumeroExpediente
        /// </summary>
        public int NumeroExpediente { get; set; }
        /// <summary>
        /// Propiedad FechaInicio
        /// </summary>
        public DateTime FechaInicio { get; set; }
        /// <summary>
        /// Propiedad FechaFin
        /// </summary>
        public DateTime FechaFin { get; set; }
    }
}
