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
    /// Clase correspondiente a la capa de negocio de tipo NucvDocumentos
    /// </summary>
    public class NucvDocumentos : Instance<NucvDocumentos>
    {
        NGestionLogError _logs;
        StackTrace _stackTrace;
        StackFrame _stackFrame;
        MethodBase _currentMethodName;
        OLogError _logError;
        /// <summary>
        /// Método para obtener la lista de documentos.
        /// </summary>
        /// <param name="listaDocumentos">Lista de documentos.</param>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo OucvDocumentos</returns>
        public Respuesta<OucvDocumentos> GetEstatusSolicitudDocumentos(List<OucvDocumentos> listaDocumentos, OLogin login)
        {
            Respuesta<OucvDocumentos> respuesta = new Respuesta<OucvDocumentos>();
            try
            {
                if (listaDocumentos.Count == 0)
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, "listaDocumentos");
                }
                respuesta = DucvDocumentos.Instances.GetEstatusSolicitudDocumentos(listaDocumentos, login);
                
            }
            catch (Exception ex)
            {
                respuesta.TipoEstatus = TipoEstatus.Error;
                respuesta.ListaErrores = new List<string>();
                respuesta.ListaErrores.Add(ex.Message);

                _stackTrace = new StackTrace();
                _stackFrame = new StackFrame();
                _stackFrame = _stackTrace.GetFrame(0);
                _currentMethodName = _stackFrame.GetMethod();

                _logError = new OLogError();
                _logError.codigoError = ex.HResult.ToString();
                _logError.error = ex.Message;
                _logError.evento = "ObtenerLista";
                _logError.formulario = "NTipoDocumento";

                _logError.ex = ex;
                _logError.usuarioID = login.Usuario.UsuarioID;
                _logError.ipEquipo = login.Usuario.ip;



                //Revisar por que no se ve el "Guardar"  
                NGestionLogError.Instances.GuardarError(_logError, login);
            }
            return respuesta;
        }
        /// <summary>
        /// Método para guardar el o los documentos cargados
        /// </summary>
        /// <param name="documentos">Lista de documentos cargados</param>
        /// <param name="solicitudID">Identificador unico de la solicitud</param>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo OucvDocumentos</returns>
        public Respuesta<OucvDocumentos> Guardar(List<ODocumento> documentos, int solicitudID, OLogin login)
        {
            Respuesta<OucvDocumentos> respuesta = new Respuesta<OucvDocumentos>();
            try
            {
                if (documentos.Count == 0)
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, "documentos");
                }
                else if (solicitudID == 0)
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, "solicitudID");
                }
                //respuesta = "";
            }
            catch (Exception ex)
            {
                respuesta.TipoEstatus = TipoEstatus.Error;
                respuesta.ListaErrores = new List<string>();
                respuesta.ListaErrores.Add(ex.Message);

                _stackTrace = new StackTrace();
                _stackFrame = new StackFrame();
                _stackFrame = _stackTrace.GetFrame(0);
                _currentMethodName = _stackFrame.GetMethod();

                _logError = new OLogError();
                _logError.codigoError = ex.HResult.ToString();
                _logError.error = ex.Message;
                _logError.evento = "Guardar";
                _logError.formulario = "NTipoDocumento";

                _logError.ex = ex;
                _logError.usuarioID = login.Usuario.UsuarioID;
                _logError.ipEquipo = login.Usuario.ip;


                //Revisar por que no se ve el "Guardar"  
                NGestionLogError.Instances.GuardarError(_logError, login);
            }

            return respuesta;
        }
        /// <summary>
        /// Método para eliminar el o los documentos cargados
        /// </summary>
        /// <param name="documentos">Lista de documentos cargados</param>
        /// <param name="solicitudID">Identificador unico de la solicitud</param>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo OucvDocumentos</returns>
        public Respuesta<OucvDocumentos> Eliminar(List<ODocumento> documentos, int solicitudID, OLogin login)
        {
            Respuesta<OucvDocumentos> respuesta = new Respuesta<OucvDocumentos>();
            try
            {
                if (documentos.Count == 0)
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, "documentos");
                }
                else if (solicitudID == 0)
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, "solicitudID");
                }
                //respuesta = "";
            }
            catch (Exception ex)
            {
                respuesta.TipoEstatus = TipoEstatus.Error;
                respuesta.ListaErrores = new List<string>();
                respuesta.ListaErrores.Add(ex.Message);

                _stackTrace = new StackTrace();
                _stackFrame = new StackFrame();
                _stackFrame = _stackTrace.GetFrame(0);
                _currentMethodName = _stackFrame.GetMethod();

                _logError = new OLogError();
                _logError.codigoError = ex.HResult.ToString();
                _logError.error = ex.Message;
                _logError.evento = "Eliminar";
                _logError.formulario = "NucvDocumentos";

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
