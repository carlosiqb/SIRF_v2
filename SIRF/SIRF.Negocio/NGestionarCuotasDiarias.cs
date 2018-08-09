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
    /// Capa de negocio correspondiente a NGestionarCuotasDiarias
    /// </summary>
    public class NGestionarCuotasDiarias : Instance<NGestionarCuotasDiarias>
    {
        StackTrace _stackTrace;
        StackFrame _stackFrame;
        MethodBase _currentMethodName;
        OLogError _logError;
        /// <summary>
        /// Método para obtener la información correspondiente a los concepto de pago
        /// </summary>
        /// <param name="soliciutd">Objeto de tipo OSolicitud</param>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo OTipoCuota</returns>
        public Respuesta<OConceptoGastos> ObtenerConceptosPago(OSolicitud soliciutd, OLogin login)
        {
            Respuesta<OConceptoGastos> respuesta = new Respuesta<OConceptoGastos>();
            try
            {
                if (soliciutd == null)
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, "soliciutd");
                }

                respuesta = DGestionarCuotasDiarias.Instances.ObtenerConceptosPago(soliciutd, login);
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
                    evento = "ObtenerConceptosPago",
                    formulario = "NGestionarCuotasDiarias"
                };

                _logError.ex = ex;
                _logError.usuarioID = login.Usuario.UsuarioID;
                _logError.ipEquipo = login.Usuario.ip;



                //Revisar por que no se ve el "Guardar"  
                DGestionLogError.Instances.GuardarError(_logError, login);

                respuesta.MensajeUsuario = ex.Message;
                respuesta.TipoEstatus = TipoEstatus.Error;
            }
            return respuesta;
        }
        /// <summary>
        /// Método para obtener la información correspondiente a las partidas
        /// </summary>
        /// <param name="soliciutd">Objeto de tipo OSolicitud</param>
        /// <param name="zonaPartidas">Zona de la partida</param>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo OTipoCuota</returns>
        public Respuesta<OPartida> ObtenerPartidas(OSolicitud soliciutd, string zonaPartidas, OLogin login)
        {
            Respuesta<OPartida> respuesta = new Respuesta<OPartida>();
            try
            {
                if (soliciutd == null)
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, "soliciutd");
                }

                respuesta = DGestionarCuotasDiarias.Instances.ObtenerPartidas(soliciutd, zonaPartidas, login);
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
                    evento = "ObtenerPartidas",
                    formulario = "NGestionarCuotasDiarias"
                };

                _logError.ex = ex;
                _logError.usuarioID = login.Usuario.UsuarioID;
                _logError.ipEquipo = login.Usuario.ip;



                //Revisar por que no se ve el "Guardar"  
                DGestionLogError.Instances.GuardarError(_logError, login);

                respuesta.MensajeUsuario = ex.Message;
                respuesta.TipoEstatus = TipoEstatus.Error;
            }
            return respuesta;
        }
        /// <summary>
        /// Obtiene las cuentas bancarias del integrate : Author JUVA
        /// </summary>
        /// <param name="numeroExpediente">Numero de expediente</param>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <returns>Cuentas</returns>
        public Respuesta<OExpedienteCuenta> ObtenerCuentasIntegrante(int numeroExpediente, OLogin login)
        {
            Respuesta<OExpedienteCuenta> respuesta = new Respuesta<OExpedienteCuenta>();
            try
            {
                if (numeroExpediente == 0)
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, "soliciutd");
                }
                respuesta = DGestionarCuotasDiarias.Instances.ObtenerCuentasIntegrante(numeroExpediente, login);
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
                    evento = "ObtenerPartidas",
                    formulario = "NGestionarCuotasDiarias"
                };

                _logError.ex = ex;
                _logError.usuarioID = login.Usuario.UsuarioID;
                _logError.ipEquipo = login.Usuario.ip;



                //Revisar por que no se ve el "Guardar"  
                DGestionLogError.Instances.GuardarError(_logError, login);

                respuesta.MensajeUsuario = ex.Message;
                respuesta.TipoEstatus = TipoEstatus.Error;
            }
            return respuesta;
        }
    }
}
