using System;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OLogError
    /// </summary>
    [Serializable]
    public class OLogError
    {
        /// <summary>
        /// Propiedad logErrorID
        /// </summary>
        public int logErrorID { get; set; }
        /// <summary>
        /// Propiedad usuarioID
        /// </summary>
        public int? usuarioID { get; set; }
        /// <summary>
        /// Propiedad error
        /// </summary>
        public string error { get; set; }
        /// <summary>
        /// Propiedad formulario
        /// </summary>
        public string formulario { get; set; }
        /// <summary>
        /// Propiedad evento
        /// </summary>
        public string evento { get; set; }
        /// <summary>
        /// Propiedad fecha
        /// </summary>
        public System.DateTime fecha { get; set; }
        /// <summary>
        /// Propiedad codigoError
        /// </summary>
        public string codigoError { get; set; }
        /// <summary>
        /// Propiedad ipEquipo
        /// </summary>
        public string ipEquipo { get; set; }
        /// <summary>
        /// Propiedad Usuarios
        /// </summary>
        public virtual OUsuario Usuarios { get; set; }

        public Exception ex { get; set; }
    }
}
