using SIRF.Mensajes;
using SIRF.Objetos;
using SIRF.Utilerias;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SIRF.Persistencia
{
    /// <summary>
    /// Clase correspondiente a la capa de datos de tipo DucvDocumentos.
    /// </summary>
    public class DucvDocumentos : Instance<DucvDocumentos>
    {
        OLogError _logError;
        /// <summary>
        /// Método para obtener EstatusSolicitudDocumentos
        /// </summary>
        /// <param name="listaDocumentos">Lista de documentos</param>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo OucvDocumentos</returns>
        public Respuesta<OucvDocumentos> GetEstatusSolicitudDocumentos(List<OucvDocumentos> listaDocumentos, OLogin login)
        {
            Respuesta<OucvDocumentos> respuesta = new Respuesta<OucvDocumentos>();
            try
            {
                using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
                {
                    IEnumerable<int> listaIds = listaDocumentos.Select(x => x.Id).Distinct();

                    var consulta = (from cl
                                    in db.SolicitudRecurso
                                    join doc in db.Documento
                                         on cl.solicitudRecursoID equals doc.solicitudRecursoID
                                    where listaIds.Contains(doc.documentoID)
                                    select new OucvDocumentos
                                    {
                                        Id = doc.documentoID,
                                        EstatusSolicitudID = cl.catEstatusSolicitudID,
                                        TipoDocumento = "",
                                        FechaAdjunto = doc.fechaRecepcion,
                                        NombreArchivo = "",
                                        prefijo = "",
                                    }).ToList();

                    if (consulta.Count > 0)
                    {
                        respuesta.TipoEstatus = TipoEstatus.Ok;
                        respuesta.MensajeUsuario = Constantes.CONINFORMACION;
                        respuesta.ListaRegistros = new List<OucvDocumentos>();
                        respuesta.ListaRegistros = consulta;
                    }
                    else
                    {
                        respuesta.TipoEstatus = TipoEstatus.Ok;
                        respuesta.MensajeUsuario = Constantes.SININFORMACION;
                    }
                }
            }
            catch (Exception ex)
            {
                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "GetEstatusSolicitudDocumentos",
                    formulario = "DucvDocumentos",
                    ex = ex,
                    usuarioID = login.Usuario.UsuarioID,
                    ipEquipo = login.Usuario.ip
                };



                //Revisar por que no se ve el "Guardar"  
                DGestionLogError.Instances.GuardarError(_logError, login);
            }
            return respuesta;
        }
        /// <summary>
        /// Método para guardar el o los documentos cargados
        /// </summary>
        /// <param name="documentos">Lista de documentos cargados</param>
        /// <param name="solicitudId">Identificador unico de la solicitud</param>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo OucvDocumentos</returns>
        public Respuesta<OucvDocumentos> Guardar(List<ODocumento> documentos, int solicitudId, OLogin login)
        {
            Respuesta<OucvDocumentos> respuesta = new Respuesta<OucvDocumentos>();
            try
            {

            }
            catch (Exception ex)
            {
                respuesta.TipoEstatus = TipoEstatus.Error;
                respuesta.ListaErrores = new List<string> { ex.Message };

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "Guardar",
                    formulario = "DucvDocumentos",
                    ex = ex,
                    usuarioID = login.Usuario.UsuarioID,
                    ipEquipo = login.Usuario.ip
                };




                //Revisar por que no se ve el "Guardar"  
                DGestionLogError.Instances.GuardarError(_logError, login);
            }

            return respuesta;
        }
        /// <summary>
        /// Método para eliminar el o los documentos cargados
        /// </summary>
        /// <param name="documentos">Lista de documentos cargados</param>
        /// <param name="solicitudId">Identificador unico de la solicitud</param>
        /// <param name="login">Objeto de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo OucvDocumentos</returns>
        public Respuesta<OucvDocumentos> Eliminar(List<ODocumento> documentos, int solicitudId, OLogin login)
        {
            Respuesta<OucvDocumentos> respuesta = new Respuesta<OucvDocumentos>();
            try
            {
                if (documentos.Count == 0)
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, "documentos");
                }
                else if (solicitudId == 0)
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, "solicitudId");
                }
                //respuesta = "";
            }
            catch (Exception ex)
            {
                respuesta.TipoEstatus = TipoEstatus.Error;
                respuesta.ListaErrores = new List<string> { ex.Message };

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "Eliminar",
                    formulario = "DucvDocumentos",
                    ex = ex,
                    usuarioID = login.Usuario.UsuarioID,
                    ipEquipo = login.Usuario.ip
                };




                //Revisar por que no se ve el "Guardar"  
                DGestionLogError.Instances.GuardarError(_logError, login);
            }

            return respuesta;
        }
    }
}