using SIRF.Mensajes;
using SIRF.Objetos;
using SIRF.Utilerias;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace SIRF.Datos
{
    /// <summary>
    /// Capa de negocio correspondiente a DGestionarCuotasDiarias
    /// </summary>
    public class DGestionarCuotasDiarias : Instance<DGestionarCuotasDiarias>
    {
        StackTrace _stackTrace;
        StackFrame _stackFrame;
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
                using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
                {
                    var consulta = (from cm
                                 in db.CatConceptoPago           
                                    //where cm.tipoSolicitudID == soliciutd.SolicitudID ---> REVISAR ESTA CONDICIÓN, ESTA DE LA PATADA
                                    select new OConceptoGastos
                                    {
                                        conceptoGastosID = cm.catConceptoPagoID,
                                        descripcionConceptoGasto = cm.descripcion,
                                        //tipoSolicitudID = cm.tipoSolicitudID,
                                        estatusLogico = cm.estatusLogico
                                    }).ToList();

                    if (consulta.Count > 0)
                    {
                        respuesta.TipoEstatus = TipoEstatus.Ok;
                        respuesta.MensajeUsuario = Constantes.CONINFORMACION;
                        consulta.Add(new OConceptoGastos() { conceptoGastosID = -1, descripcionConceptoGasto = Constantes.SELECTOPTION });
                        respuesta.ListaRegistros = consulta;
                    }
                    else
                    {
                        respuesta.TipoEstatus = TipoEstatus.Error;
                        respuesta.MensajeUsuario = Constantes.SININFORMACION;
                        consulta.Add(new OConceptoGastos() { conceptoGastosID = -1, descripcionConceptoGasto = Constantes.SELECTOPTION });
                        respuesta.ListaRegistros = consulta;
                    }

                }
            }
            catch (Exception ex)
            {
                _stackTrace = new StackTrace();
                _stackFrame = new StackFrame();
                _stackFrame = _stackTrace.GetFrame(0);

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "ObtenerConceptosPago",
                    formulario = "DGestionarCuotasDiarias",
                    ex = ex,
                    usuarioID = login.Usuario.UsuarioID,
                    ipEquipo = login.Usuario.ip
                };


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
                using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
                {
                    var consulta = (from cp in db.CatPartida
                                    where
                                    // cp.tipoSolicitudID == soliciutd.SolicitudID && ---> ESTO ESTA DE LA PATADA, REVISAR
                                        cp.estatusLogico == (soliciutd.EstatusLogico  == false || cp.estatusLogico)
                                        && (
                                        (zonaPartidas == "Mexico" && (cp.catPartidaID == 37502 || cp.catPartidaID == 37504))
                                        || (zonaPartidas == "Extranjero" && (cp.catPartidaID == 37601 || cp.catPartidaID == 37602))
                                        || zonaPartidas == "Todo")
                                    select new OPartida
                                    {
                                        CodPartida = cp.catPartidaID,
                                        ConceptoGtoCorriente = cp.denominacion,
                                        DescripcionPartida = cp.descripcion,
                                        Capitulo = cp.capitulo,
                                        Concepto = cp.concepto,
                                        Denominacion = cp.denominacion,
                                        EstatusLogico = cp.estatusLogico
                                    }).ToList();

                    if (consulta.Count > 0)
                    {
                        respuesta.TipoEstatus = TipoEstatus.Ok;
                        respuesta.MensajeUsuario = Constantes.CONINFORMACION;
                        consulta.Add(new OPartida() { CodPartida = -1, DescripcionPartida = Constantes.SELECTOPTION });
                        respuesta.ListaRegistros = consulta;
                    }
                    else
                    {
                        respuesta.TipoEstatus = TipoEstatus.Error;
                        respuesta.MensajeUsuario = Constantes.SININFORMACION;
                        consulta.Add(new OPartida() { CodPartida = -1, DescripcionPartida = Constantes.SELECTOPTION });
                        respuesta.ListaRegistros = consulta;
                    }

                }
            }
            catch (Exception ex)
            {
                _stackTrace = new StackTrace();
                _stackFrame = new StackFrame();
                _stackFrame = _stackTrace.GetFrame(0);

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "ObtenerPartidas",
                    formulario = "DGestionarCuotasDiarias",
                    ex = ex,
                    usuarioID = login.Usuario.UsuarioID,
                    ipEquipo = login.Usuario.ip
                };



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
                using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
                {
                    var consulta = (from vwc in db.vwCuentasIntegrante
                                    where
                                        vwc.expediente == numeroExpediente &&
                                        vwc.estatusLogico == true
                                    select new OExpedienteCuenta
                                    {
                                        Expediente = vwc.expediente,
                                        DescripcionCuenta = vwc.descripcionCuenta,
                                        CLABEInterbancaria = vwc.clabeInterbancaria,
                                        DescripcionBanco = vwc.descripcion,
                                        TipoCuentaID = vwc.tipoCuentaID,
                                        DescripcionTipoCuenta = vwc.descripcionTipoCuenta,
                                        EstatusLogico = vwc.estatusLogico,
                                    }).ToList();



                    if (consulta.Count > 0)
                    {
                        respuesta.TipoEstatus = TipoEstatus.Ok;
                        respuesta.MensajeUsuario = Constantes.CONINFORMACION;
                        consulta.Add(new OExpedienteCuenta()
                        {
                            Expediente = numeroExpediente,
                            TipoCuentaID = -1,
                            DescripcionTipoCuenta = "OTRA",
                            EstatusLogico = true,
                        });
                        respuesta.ListaRegistros = consulta;
                    }
                    else
                    {
                        respuesta.TipoEstatus = TipoEstatus.Error;
                        respuesta.MensajeUsuario = Constantes.SININFORMACION;
                        consulta.Add(new OExpedienteCuenta()
                        {
                            Expediente = numeroExpediente,
                            TipoCuentaID = -1,
                            DescripcionTipoCuenta = "OTRA",
                            EstatusLogico = true,
                        });
                        respuesta.ListaRegistros = consulta;
                    }
                }
            }
            catch (Exception ex)
            {
                _stackTrace = new StackTrace();
                _stackFrame = new StackFrame();
                _stackFrame = _stackTrace.GetFrame(0);

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "ObtenerCuentasIntegrante",
                    formulario = "DGestionarCuotasDiarias",
                    ex = ex,
                    usuarioID = login.Usuario.UsuarioID,
                    ipEquipo = login.Usuario.ip
                };


                //Revisar por que no se ve el "Guardar"  
               DGestionLogError.Instances.GuardarError(_logError, login);

                respuesta.MensajeUsuario = ex.Message;
                respuesta.TipoEstatus = TipoEstatus.Error;
            }
            return respuesta;
        }
    }
}
