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
    /// 
    /// </summary>
    public class NDocumento : Instance<NDocumento>
    {
        StackTrace _stackTrace;
        StackFrame _stackFrame;
        MethodBase _currentMethodName;
        OLogError _logError;

        /// <summary>
        /// Registrar documentos de solicitud : Author JUVA
        /// </summary>
        /// ///
        /// <param name="documento"></param>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo Int</returns>
        //public Respuesta<int> Guardar(List<ODocumento> documentos, int solicitudID, OLogin login)
        public Respuesta<int> Guardar(ODocumento documento, OLogin login)
        {
            Respuesta<int> respuesta = new Respuesta<int>();

            try
            {
                if (documento == null)
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, "documentos");
                }
                respuesta = DDocumento.Instances.Guardar(documento, login);
            }
            catch (Exception ex)
            {
                _stackTrace = new StackTrace();
                _stackFrame = new StackFrame();
                _stackFrame = _stackTrace.GetFrame(0);
                _currentMethodName = _stackFrame.GetMethod();

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "Guardar",
                    formulario = "NDocumento"
                };
                _logError.ex = ex;
                _logError.usuarioID = login.Usuario.UsuarioID;
                _logError.ipEquipo = login.Usuario.ip;



                //Revisar por que no se ve el "Guardar"  
                DGestionLogError.Instances.GuardarError(_logError, login);
            }
            return respuesta;
        }
        /// <summary>
        /// Registrar documentos de solicitud
        /// </summary>
        /// <param name="documentos">Documento</param>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo Int</returns>
        public Respuesta<int> ActualizarSolicitud(OSolicitudRecursos documentos, OLogin login)
        {
            Respuesta<int> respuesta = new Respuesta<int>();
            try
            {
                if (documentos == null)
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, "documentos");
                }

                respuesta = DDocumento.Instances.ActualizarSolicitud(documentos, login);
            }
            catch (Exception ex)
            {
                _stackTrace = new StackTrace();
                _stackFrame = new StackFrame();
                _stackFrame = _stackTrace.GetFrame(0);
                _currentMethodName = _stackFrame.GetMethod();

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "ActualizarSolicitud",
                    formulario = "NDocumento"
                };

                _logError.ex = ex;
                _logError.usuarioID = login.Usuario.UsuarioID;
                _logError.ipEquipo = login.Usuario.ip;


                //Revisar por que no se ve el "Guardar"  
                DGestionLogError.Instances.GuardarError(_logError, login);
            }
            return respuesta;
        }

        /// <summary>
        /// Consultar documentos de la solicitud
        /// </summary>
        /// <param name="tipoSolicitudID">Identificador de la slicitud</param>
        /// <param name="soloActivos">Objeto de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo ODocumento</returns>
        public List<OTipoDocumento> ObtenerListaV(int tipoSolicitudID = 1, bool soloActivos = false)
        {
            DDocumento tipoDocumento = new DDocumento();
            return tipoDocumento.ObtenerListaV(tipoSolicitudID, soloActivos);
        }
        /// <summary>
        /// Consultar documentos de la solicitud
        /// </summary>
        /// <param name="solicitudID">Identificador de la slicitud</param>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo ODocumento</returns>
        public Respuesta<ODocumento> ObtenerLista(int solicitudID, OLogin login)
        {
            Respuesta<ODocumento> respuesta = new Respuesta<ODocumento>();
            try
            {
                if (solicitudID == 0)
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, "solicitudID");
                }
                respuesta = DDocumento.Instances.ObtenerLista(solicitudID, login);
            }
            catch (Exception ex)
            {
                _stackTrace = new StackTrace();
                _stackFrame = new StackFrame();
                _stackFrame = _stackTrace.GetFrame(0);
                _currentMethodName = _stackFrame.GetMethod();

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "Eliminar",
                    formulario = "NDocumento"
                };

                _logError.ex = ex;
                _logError.usuarioID = login.Usuario.UsuarioID;
                _logError.ipEquipo = login.Usuario.ip;



                //Revisar por que no se ve el "Guardar"  
                DGestionLogError.Instances.GuardarError(_logError, login);
            }

            return respuesta;
        }

        /// <summary>
        /// Eliminar documentos de solicitud
        /// </summary>
        /// <param name="documentos"></param>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <returns>Respuesta de transacción</returns>
        //public Respuesta<int> Eliminar(List<ODocumento> documentos, int solicitudID, OLogin login)
        public Respuesta<int> Eliminar(ODocumento documentos, OLogin login)
        {
            Respuesta<int> respuesta = new Respuesta<int>();
            try
            {
                if (documentos == null)
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, "documentos");
                }
                //else if (solicitudID == 0)
                //{
                //    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, "solicitudID");
                //}
                //respuesta = DDocumento.Instances.Eliminar(documentos, solicitudID, login);
                respuesta = DDocumento.Instances.Eliminar(documentos, login);
            }
            catch (Exception ex)
            {
                _stackTrace = new StackTrace();
                _stackFrame = new StackFrame();
                _stackFrame = _stackTrace.GetFrame(0);
                _currentMethodName = _stackFrame.GetMethod();

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "Eliminar",
                    formulario = "NDocumento"
                };

                _logError.ex = ex;
                _logError.usuarioID = login.Usuario.UsuarioID;
                _logError.ipEquipo = login.Usuario.ip;


                //Revisar por que no se ve el "Guardar"  
                DGestionLogError.Instances.GuardarError(_logError, login);
            }
            return respuesta;
        }
    }
}
