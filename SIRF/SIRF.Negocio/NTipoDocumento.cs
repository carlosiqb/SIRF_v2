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
    /// Método de la capa de negocio correspondiente a NTipoDocumento
    /// </summary>
    public class NTipoDocumento : Instance<NTipoDocumento>
    {
        NGestionLogError _logs;
        StackTrace _stackTrace;
        StackFrame _stackFrame;
        MethodBase _currentMethodName;
        OLogError _logError;

        /// <summary>
        /// Método para obtener la lista de tipos de documentos.
        /// </summary>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <param name="tipoSolicitudID">Tipo de solicitud = 1</param>
        /// <param name="soloActivos">Tipo de solicitud activos.</param>
        /// <returns>Respuesta genérica de tipo OTipoDocumento</returns>
        public Respuesta<OTipoDocumento> ObtenerLista(OLogin login, int tipoSolicitudID = 1, bool soloActivos = false)
        {
            Respuesta<OTipoDocumento> respuesta = new Respuesta<OTipoDocumento>();
            try
            {
                if (tipoSolicitudID == 0)
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, tipoSolicitudID.ToString());
                }
                respuesta = DTipoDocumento.Instances.ObtenerLista(tipoSolicitudID, soloActivos, login);
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
        /// Método para obtener la lista de tipos de documentos.
        /// </summary>
        /// <param name="tipoSolicitudID">Tipo de solicitud</param>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo OTipoDocumento</returns>
        public Respuesta<OTipoDocumento> ObtenerLista(int tipoSolicitudID, OLogin login)
        {
            Respuesta<OTipoDocumento> respuesta = new Respuesta<OTipoDocumento>();
            try
            {
                if (tipoSolicitudID == 0)
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, tipoSolicitudID.ToString());
                }
                respuesta = DTipoDocumento.Instances.ObtenerLista(tipoSolicitudID, login);
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
        /// Consulta de catálogo : Author JUVA
        /// </summary>
        /// <param name="tipoSolicitudID">Filtro</param>
        /// <param name="soloActivos">Filtro opcional</param>
        /// <returns>Tipos de documentos</returns>
        public List<OTipoDocumento> ObtenerListaV(int tipoSolicitudID = 1, bool soloActivos = false)
        {
            DTipoDocumento tipoDocumento = new DTipoDocumento();
            return tipoDocumento.ObtenerListaV(tipoSolicitudID, soloActivos);
        }

        public List<DTipoDocumento> ObtenerListaV(int tipoSolicitudID)
        {
            NTipoDocumento tipoDocumento = new NTipoDocumento();
            return tipoDocumento.ObtenerListaV(tipoSolicitudID);
        }

    }
}