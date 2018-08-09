using SIRF.Persistencia;
using SIRF.Mensajes;
using SIRF.Objetos;
using SIRF.Utilerias;
using System;
using System.Diagnostics;
using System.Reflection;

namespace SIRF.Negocio
{
    /// <summary>
    /// Clase de la capa de negocio correspondiente a NGestionLogError
    /// </summary>
    public class NGestionLogError : Instance<NGestionLogError>
    {
        /// <summary>
        /// Método para el registro del log de errores.
        /// </summary>
        /// <param name="logError">Parametro de tipo OLogError</param>
        /// <param name="login">Parametro de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo string</returns>
        public void GuardarError(OLogError logError, OLogin login)
        {
            if (String.IsNullOrEmpty(logError.error))
            {
                throw new ArgumentException(Constantes.PARAMETROVACIOONULO, logError.error);
            }
            if (String.IsNullOrEmpty(logError.formulario))
            {
                throw new ArgumentException(Constantes.PARAMETROVACIOONULO, logError.formulario);
            }
            if (String.IsNullOrEmpty(logError.evento))
            {
                throw new ArgumentException(Constantes.PARAMETROVACIOONULO, logError.evento);
            }
            if (String.IsNullOrEmpty(logError.codigoError))
            {
                throw new ArgumentException(Constantes.PARAMETROVACIOONULO, logError.codigoError);
            }
            if (String.IsNullOrEmpty(logError.ipEquipo))
            {
                throw new ArgumentException(Constantes.PARAMETROVACIOONULO, logError.ipEquipo);
            }
            DGestionLogError.Instances.GuardarError(logError, login);
        }
    }
}
