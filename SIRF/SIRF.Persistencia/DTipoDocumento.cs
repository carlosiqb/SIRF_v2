using SIRF.Objetos;
using SIRF.Utilerias;
using SIRF.Mensajes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SIRF.Persistencia
{
    /// <summary>
    /// Clase de la capa de datos de tipo DTipoDocumento
    /// </summary>
    public class DTipoDocumento : Instance<DTipoDocumento>
    {
        OLogError _logError;

        /// <summary>
        /// Consulta tipo de documetos
        /// </summary>
        /// <param name="tipoSolicitudID">Filtro</param>
        /// <param name="soloActivos">Filtro opciona.</param>
        /// <param name="login">Objeto de tipo OLogin.</param>
        /// <returns>Tipos de documento</returns>
        public Respuesta<OTipoDocumento> ObtenerLista(int tipoSolicitudID, bool soloActivos, OLogin login)
        {
            Respuesta<OTipoDocumento> respuesta = new Respuesta<OTipoDocumento>();
            try
            {
                using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
                {
                    var consulta = (from td in db.CatDocumento
                                    where td.catSolicitudID == tipoSolicitudID 
                                    && td.estatusLogico == (soloActivos || td.estatusLogico)
                                    select new OTipoDocumento
                                    {
                                        TipoDocumentoID = td.catDocumentoID,
                                        DescripcionTipoDoc = td.descripcion,
                                        EstatusLogico = td.estatusLogico,
                                        Prefijo = td.prefijo
                                    }).ToList();
                    
                    if (consulta.Count > 0)
                    {                                                                                   
                        consulta.Add(new OTipoDocumento() { TipoDocumentoID = -1, DescripcionTipoDoc = ConstantesArchivos.SELECCIONETIPODOCUMENTO, Prefijo = "NA" });
                        consulta=consulta.OrderBy(td => td.TipoDocumentoID).ToList();
                        respuesta.ListaRegistros = new List<OTipoDocumento>();
                        respuesta.ListaRegistros = consulta;
                        respuesta.TipoEstatus = TipoEstatus.Ok;
                        respuesta.MensajeUsuario = Constantes.CONINFORMACION;
                    }
                    else
                    {
                        respuesta.TipoEstatus = TipoEstatus.Ok;
                        respuesta.MensajeUsuario = Constantes.SININFORMACION;
                        consulta.Add(new OTipoDocumento() { TipoDocumentoID = -1, DescripcionTipoDoc = ConstantesArchivos.SELECCIONETIPODOCUMENTO, Prefijo = "NA" });
                        respuesta.ListaRegistros = new List<OTipoDocumento>();
                        respuesta.ListaRegistros = consulta;
                    }
                }
            }
            catch (Exception ex)
            {
                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "ObtenerLista",
                    formulario = "DTipoDocumento",
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
        /// Consulta tipo de documetos
        /// </summary>
        /// <param name="tipoSolicitudID">Filtro</param>
        /// <param name="login">Objeto de tipo OLogin.</param>
        /// <returns>Tipos de documento</returns>
        public Respuesta<OTipoDocumento> ObtenerLista(int tipoSolicitudID, OLogin login)
        {
            Respuesta<OTipoDocumento> respuesta = new Respuesta<OTipoDocumento>();
            try
            {
                using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
                {
                    var consulta = (from td
                                 in db.CatDocumento
                                    where td.catSolicitudID == tipoSolicitudID
                                    select new OTipoDocumento
                                    {
                                        TipoDocumentoID = td.catDocumentoID,
                                        DescripcionTipoDoc = td.descripcion,
                                        EstatusLogico = td.estatusLogico,
                                        Prefijo = td.prefijo
                                    }).ToList();

                    if (consulta.Count > 0)
                    {
                        consulta.Add(new OTipoDocumento() { TipoDocumentoID = -1, DescripcionTipoDoc = ConstantesArchivos.SELECCIONETIPODOCUMENTO, Prefijo = "NA" });
                        consulta=consulta.OrderBy(td => td.TipoDocumentoID).ToList();
                        respuesta.ListaRegistros = new List<OTipoDocumento>();
                        respuesta.ListaRegistros = consulta;
                        respuesta.TipoEstatus = TipoEstatus.Ok;
                        respuesta.MensajeUsuario = Constantes.CONINFORMACION;
                    }
                    else
                    {
                        respuesta.TipoEstatus = TipoEstatus.Ok;
                        respuesta.MensajeUsuario = Constantes.SININFORMACION;
                        consulta.Add(new OTipoDocumento() { TipoDocumentoID = -1, DescripcionTipoDoc = ConstantesArchivos.SELECCIONETIPODOCUMENTO, Prefijo = "NA" });
                        respuesta.ListaRegistros = new List<OTipoDocumento>();
                        respuesta.ListaRegistros = consulta;
                    }
                }
            }
            catch (Exception ex)
            {
                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "ObtenerLista",
                    formulario = "DTipoDocumento",
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
                                    TipoDocumentoID = td.catSolicitudID,
                                    DescripcionTipoDoc = td.descripcion,
                                    EstatusLogico = td.estatusLogico,
                                    Prefijo = td.prefijo
                                }).ToList();

                consulta.Add(new OTipoDocumento() { TipoDocumentoID = -1, DescripcionTipoDoc = Constantes.SELECTOPTION, Prefijo = "NA" });

                return consulta.OrderBy(td => td.TipoDocumentoID).ToList();
            }
        }

        public List<OTipoDocumento> ObtenerListaV(int tipoSolicitudID)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {
                var consulta = (from td
                             in db.CatDocumento
                                //// where td.tipoSolicitudID == tipoSolicitudID  ---> ESTA CONDICION ESTA DE LA PATADA, REVISAR
                                select new OTipoDocumento
                                {
                                    TipoDocumentoID = td.catDocumentoID,
                                    DescripcionTipoDoc = td.descripcion,
                                    EstatusLogico = td.estatusLogico,
                                    Prefijo = td.prefijo
                                }).ToList();

                return consulta.OrderBy(td => td.TipoDocumentoID).ToList();
            }
        }

    }
}