using SIRF.Mensajes;
using SIRF.Objetos;
using SIRF.Utilerias;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SIRF.Persistencia
{
    /// <summary>
    /// Capa correspondein
    /// </summary>
    public class DDocumento : Instance<DDocumento>
    {
        StackTrace _stackTrace;
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
                using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
                {
                    Documento nuevoDocumento = new Documento()
                    {
                        solicitudRecursoID = documento.Solicitud.SolicitudID,
                        catDocumentoID = documento.TipoDocumento.TipoDocumentoID,
                        descripcionDocumento = documento.TipoDocumento.DescripcionTipoDoc,
                        anexo = documento.Anexo,
                        fechaRecepcion = documento.FechaRecepcion,
                        estatus = true,
                        extensionDocumento = documento.Extension,
                        contenido = documento.DocumentoBase64
                    };

                    db.Documento.Add(nuevoDocumento);
                    db.SaveChanges();

                    documento.DocumentoID = nuevoDocumento.documentoID;

                }
            }
            catch (Exception ex)
            {
                _stackTrace = new StackTrace();

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "Guardar",
                    formulario = "DDocumento",
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
                using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
                {

                    SolicitudRecurso actualizarDocumento = db.SolicitudRecurso.FirstOrDefault(a => a.solicitudRecursoID == documentos.solicitudID);

                    if (actualizarDocumento != null)
                    {
                        actualizarDocumento.oficioSolicitud = documentos.oficioSolicitud;
                        actualizarDocumento.observaciones = documentos.observaciones;

                        int respuestabd = db.SaveChanges();

                        if (respuestabd == 1)
                        {
                            respuesta.TipoEstatus = TipoEstatus.Ok;
                            respuesta.MensajeUsuario = ConstantesArchivos.DOCUMENTOGUARDADO;
                        }
                        else
                        {
                            respuesta.TipoEstatus = TipoEstatus.Error;
                            respuesta.MensajeUsuario = ConstantesArchivos.DOCUMENTONOGUARDADO;
                        }
                    }
                    else
                    {
                        respuesta.TipoEstatus = TipoEstatus.Error;
                    }
                }

            }
            catch (Exception ex)
            {
                _stackTrace = new StackTrace();

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "ActualizarSolicitud",
                    formulario = "DDocumento",
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
        /// Consultar documentos de la solicitud
        /// </summary>
        /// <param name="solicitudId">Identificador de la slicitud</param>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo ODocumento</returns>
        public Respuesta<ODocumento> ObtenerLista(int solicitudId, OLogin login)
        {
            Respuesta<ODocumento> respuesta = new Respuesta<ODocumento>();
            try
            {
                using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
                {

                    var documentos = (from cp in db.Documento
                                      join td in db.CatDocumento
                                          on cp.catDocumentoID equals td.catDocumentoID
                                      where (cp.solicitudRecursoID == solicitudId
                                             && cp.estatus)
                                      select new ODocumento
                                      {
                                          DocumentoID = cp.documentoID,
                                          TipoDocumento = new OTipoDocumento()
                                          {
                                              TipoDocumentoID = td.catDocumentoID,
                                              DescripcionTipoDoc = td.descripcion
                                          },
                                          DescripcionDocumento = td.descripcion,
                                          Anexo = cp.anexo,
                                          FechaRecepcion = cp.fechaRecepcion,
                                          //Edicion = false
                                          Edicion = true,
                                          Extension = cp.extensionDocumento,
                                          DocumentoBase64 = cp.contenido
                                      }).ToList();

                    documentos = documentos.OrderBy(d => d.DocumentoID).ToList();

                    respuesta.ListaRegistros = new List<ODocumento>();

                    if (documentos.Count > 0)
                    {
                        respuesta.ListaRegistros = documentos;
                        respuesta.MensajeUsuario = Constantes.CONINFORMACION;
                        respuesta.TipoEstatus = TipoEstatus.Ok;
                    }
                    else
                    {
                        respuesta.MensajeUsuario = Constantes.SININFORMACION;
                        respuesta.TipoEstatus = TipoEstatus.Error;
                    }
                }
            }
            catch (Exception ex)
            {
                _stackTrace = new StackTrace();

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "Eliminar",
                    formulario = "DDocumento",
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
        /// Eliminar documentos de solicitud
        /// </summary>
        /// <param name="documento"></param>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <returns>Respuesta de transacción</returns>
        //public Respuesta<int> Eliminar(List<ODocumento> documentos, int solicitudID, OLogin login)
        public Respuesta<int> Eliminar(ODocumento documento, OLogin login)
        {
            Respuesta<int> respuesta = new Respuesta<int>();

            try
            {
                using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
                {

                    var consulta = db.Documento.Single(d => d.documentoID == documento.DocumentoID);
                    consulta.estatus = false;

                    int respuestabd = db.SaveChanges();

                    if (respuestabd == 1)
                    {
                        respuesta.TipoEstatus = TipoEstatus.Ok;
                        respuesta.MensajeUsuario = ConstantesArchivos.DOCUMENTOELIMINADO;
                    }
                    else
                    {
                        respuesta.TipoEstatus = TipoEstatus.Error;
                        respuesta.MensajeUsuario = ConstantesArchivos.DOCUMENTONOELIMINADO;
                    }
                }
            }
            catch (Exception ex)
            {
                _stackTrace = new StackTrace();

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "Eliminar",
                    formulario = "DDocumento",
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
        /// Consulta tipo de documetos
        /// </summary>
        /// <param name="tipoSolicitudID">Filtro</param>
        /// <param name="soloActivos">Filtro opciona</param>
        /// <returns>Tipos de documento</returns>
        public List<OTipoDocumento> ObtenerListaV(int tipoSolicitudID, bool soloActivos)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {

                var consulta = (from td in db.CatDocumento
                                where td.catSolicitudID == tipoSolicitudID &&
                                    td.estatusLogico == (soloActivos || td.estatusLogico)
                                select new OTipoDocumento
                                {
                                    TipoDocumentoID = td.catDocumentoID,
                                    DescripcionTipoDoc = td.descripcion,
                                    EstatusLogico = td.estatusLogico,
                                    Prefijo = td.prefijo
                                }).ToList();

                consulta.Add(new OTipoDocumento() { TipoDocumentoID = -1, DescripcionTipoDoc = Constantes.SELECTOPTION, Prefijo = "NA" });

                return consulta.OrderBy(td => td.TipoDocumentoID).ToList();
            }
        }
    }
}
