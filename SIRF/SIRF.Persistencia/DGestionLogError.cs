using SIRF.Objetos;
using SIRF.Utilerias;
using System;
using System.Data.Entity.Validation;
using System.Linq;

namespace SIRF.Persistencia
{
    /// <summary>
    /// Clase de la capa de negocio correspondiente a DGestionLogError
    /// </summary>
    public class DGestionLogError : Instance<DGestionLogError>
    {
        public string WriteEntry(Exception exception)
        {
            if (exception == null) return "";
            var logMessage = exception.InnerException + "_" + exception.Message + "_" + exception.StackTrace;            
            try
            {
                if (exception is DbEntityValidationException)
                {
                    logMessage += "Mensaje: \n";
                    logMessage +=
                        String.Concat(
                            (exception as DbEntityValidationException).EntityValidationErrors.SelectMany(
                                ev => ev.ValidationErrors).Select(ve => ve.ErrorMessage + "\n"));
                    logMessage += "\nStackTrace: \n";
                    logMessage += exception.StackTrace;
                }
            }
            catch (Exception)
            {
                logMessage = exception.StackTrace;
            }
            if (logMessage.Length > 500) logMessage=logMessage.Substring(0, 488);
            return logMessage;
        }

        /// <summary>
        /// Método para el registro del log de errores.
        /// </summary>
        /// <param name="logError">Parametro de tipo OLogError</param>
        /// <param name="login">Parametro de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo string</returns>
        public void GuardarError(OLogError logError, OLogin login)
        {
            try
            {
                if (!string.IsNullOrEmpty(logError.error) && logError.error.Length>100)
                {
                    logError.error = logError.error.Substring(0, 97);
                }
                if (logError.usuarioID == 0) logError.usuarioID=null;
                using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
                {
                    var nuevoError = new LogError
                    {
                        usuarioID = logError.usuarioID,
                        error = logError.error,
                        formulario = logError.formulario,
                        evento = logError.evento,
                        fecha = DateTime.Now,
                        codigoError = logError.codigoError,
                        ipEquipo = logError.ipEquipo,
                        stacktrace = WriteEntry(logError.ex)
                    };

                    db.LogError.Add(nuevoError);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                var det = WriteEntry(ex);
                // ignored
            }
        }
    }
}
