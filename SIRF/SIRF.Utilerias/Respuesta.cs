using System;
using System.Collections.Generic;
using System.ComponentModel;
using SIRF.Mensajes;

namespace SIRF.Utilerias
{
    /// <summary>
    /// Clase Respuesta
    /// </summary>
    /// <typeparam name="T">Parametro generico</typeparam>
    public class Respuesta<T> : IDisposable
    {
        /// <summary>
        /// Propiedad de tipo objeto TipoEstatus.
        /// </summary>
        [DefaultValue(TipoEstatus.Ok)]
        public TipoEstatus TipoEstatus { get; set; }

        /// <summary>
        /// Propiedad de tipo lista de cadenas.
        /// </summary>
        public List<String> ListaErrores { get; set; }

        /// <summary>
        /// Propiedad de tipo cadena.
        /// </summary>
        public string MensajeUsuario { get; set; }

        /// <summary>
        /// Propiedad de tipo entero.
        /// </summary>
        public Int32 NumeroRegistros { get; set; }

        /// <summary>
        /// Propiedad de tipo entero.
        /// </summary>
        public Int32 IdEntidad { get; set; }

        /// <summary>
        /// Propiedad de tipo lista generica
        /// </summary>
        public List<T> ListaRegistros { get; set; }

        /// <summary>
        /// Propiedad de tipo entero.
        /// </summary>
        public Int32 EstatusRespuesta { get; set; }

        /// <summary>
        /// Propiedad de tipo generica.
        /// </summary>
        public T TipoRespuesta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private bool disposing;

        /// <summary>
        /// Constructor de Dispose
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }

        /// <summary>
        /// Virtual de Dispose
        /// </summary>
        /// <param name="b"></param>
        protected virtual void Dispose(bool b)
        {
            if (!disposing)
            {
                disposing = true;
                GC.SuppressFinalize(this);
            }
        }

        /// <summary>
        /// Destructor de la clase Respuesta
        /// </summary>
        ~Respuesta()
        {
            Dispose(true);
        }
    }
}