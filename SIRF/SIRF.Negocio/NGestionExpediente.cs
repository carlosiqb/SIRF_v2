using SIRF.Persistencia;
using SIRF.Mensajes;
using SIRF.Objetos;
using SIRF.Utilerias;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace SIRF.Negocio
{
    /// <summary>
    /// Clase de la capa de negocio correspondiente a NGestionExpediente.
    /// </summary>
    public class NGestionExpediente : Instance<NGestionExpediente>
    {
        NGestionLogError _logs;
        StackTrace _stackTrace;
        StackFrame _stackFrame;
        MethodBase _currentMethodName;
        OLogError _logError;

        /// <summary>
        /// Método para la obtención del Centro de Distribución.
        /// </summary>
        /// <param name="numeroExpediente">Número de expediente del usuario logueado.</param>
        /// <param name="login">Parametro de tipo OLogin.</param>
        /// <returns>Respuesta genérica de tipo Lista de cadenas</returns>
        public Respuesta<List<string>> ObtenerCentrosDistribucion(int numeroExpediente, OLogin login)
        {
            Respuesta<List<string>> respuesta = new Respuesta<List<string>>();
            try
            {
                if (String.IsNullOrEmpty(numeroExpediente.ToString()))
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, numeroExpediente.ToString());
                }
                respuesta = DGestionExpediente.Instances.ObtenerCentrosDistribucion(numeroExpediente, login);
            }
            catch (Exception ex)
            {
                respuesta.TipoEstatus = TipoEstatus.Error;
                respuesta.ListaErrores = new List<string> { ex.Message };

                _stackTrace = new StackTrace();
                _stackFrame = new StackFrame();
                _stackFrame = _stackTrace.GetFrame(0);
                _currentMethodName = _stackFrame.GetMethod();

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "ObtenerCentrosDistribucion",
                    formulario = "NGestionExpediente"
                };

                _logError.ex = ex;
                _logError.usuarioID = login.Usuario.UsuarioID;
                _logError.ipEquipo = login.Usuario.ip;



                //Revisar por que no se ve el "Guardar"  
                NGestionLogError.Instances.GuardarError(_logError, login);
            }
            return respuesta;
        }
    }
}
