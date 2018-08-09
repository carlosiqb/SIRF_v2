using SIRF.Objetos;
using SIRF.Utilerias;
using SIRF.Mensajes;
using System;
using System.Linq;

namespace SIRF.Datos
{
    /// <summary>
    /// Clase de la capa de datos correspondiente a la Gestión de usuarios
    /// </summary>
    public class DGestionUsuarios : Instance<DGestionUsuarios>
    {
        OLogError _logError;

        /// <summary>
        /// Método para la obtención de la información del usuario.
        /// </summary>
        /// <param name="par">Parametros de búsqueda.</param>
        /// <param name="login">Parametros de tipo OLogin.</param>
        /// <returns>Respuesta genérica de tipo ObjetoUsuario.</returns>        
        public Respuesta<OUsuario> ObtenerUsuario(OBusquedaParametro par, OLogin login)
        {
            Respuesta<OUsuario> respuesta = new Respuesta<OUsuario>();
            try
            {
                using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
                {
                    var lsUsuario = (from us in db.Usuario.Where(s => s.cuenta == par.Descripcion || s.numeroExpediente == par.NumeroExpediente)
                                     where (int)TipoBusquedaEnum.Usuario == par.TipoBusqueda || (int)TipoBusquedaEnum.Expediente == par.TipoBusqueda
                                     select new OUsuario
                                     {
                                         UsuarioID = us.usuarioID,
                                         Usuario = us.cuenta,
                                         Correo = us.correo,
                                         UnidadAdministrativa = us.CatUnidadAdm.descripcion,
                                         PerfilID = us.catPerfilID,
                                         DescripcionPerfil = us.CatPerfil.descripcion,
                                         Expediente = us.numeroExpediente,
                                         EstatusLogico = us.estatusLogico,
                                         RegionID = us.CatUnidadAdm.catRegionID,
                                         CodUA = us.catUnidadAdmID,

                                         Proceso = "",
                                         DescripcionRol = ""
                                         //RolId = us.RolId,

                                     }).FirstOrDefault();

                    respuesta.MensajeUsuario = Constantes.CONINFORMACION;
                    respuesta.TipoEstatus = TipoEstatus.Ok;

                    if (lsUsuario != null)
                    {

                        lsUsuario.DescripcionArea = (from us in db.Usuario.Where(u => u.usuarioID == lsUsuario.UsuarioID)
                                                     join c in db.AreaUnidadAdm on us.catUnidadAdmID equals c.catUnidadAdmID
                                                     join d in db.CatArea on c.catAreaID equals d.catAreaID
                                                     select d.descripcion).FirstOrDefault();

                        lsUsuario.AreaId = (from us in db.Usuario.Where(u => u.usuarioID == lsUsuario.UsuarioID)
                                            join c in db.AreaUnidadAdm on us.catUnidadAdmID equals c.catUnidadAdmID
                                            join d in db.CatArea on c.catAreaID equals d.catAreaID
                                            select d.catAreaID).FirstOrDefault();

                        lsUsuario.Nombre = GetUsuarioKardex(lsUsuario.Expediente).Nombre;

                        DGestionExpediente exp = new DGestionExpediente();
                        lsUsuario.codCentroDistribucion = exp.ObtenerCodCentroDistribucion(lsUsuario.Expediente);


                        respuesta.NumeroRegistros = 1;
                    }
                    else
                    {
                        respuesta.TipoEstatus = TipoEstatus.Ok;
                        respuesta.MensajeUsuario = Constantes.SININFORMACION;
                    }
                    respuesta.TipoRespuesta = lsUsuario;

                }
            }
            catch (Exception ex)
            {
                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "ObtenerUsuario",
                    formulario = "DGestionUsuarios",
                    ex = ex,
                    usuarioID = login.Usuario.UsuarioID,
                    ipEquipo = login.Usuario.ip
                };



                DGestionLogError.Instances.GuardarError(_logError, login);
            }
            return respuesta;
        }

        public OUsuario GetUsuarioKardex(Int32 numeroExpediente)
        {
            OUsuario user = new OUsuario
            {
                Nombre = ""
            };
            try
            {
                using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
                {

                    user = (from uV in db.vwDatosIntegrante
                        where uV.expediente == numeroExpediente
                        select new OUsuario
                        {
                            Nombre = uV.nombre
                        }).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                // ignored
            }
            return user;
        }

        /// <summary>
        /// Método para la obtención de los permisos del usuario logueado.
        /// </summary>
        /// <param name="par">Parametros de búsqueda.</param>
        /// <param name="login">Parametros de tipo OLogin.</param>
        /// <returns>Respuesta genérica de tipo OPermisos</returns> 
        public Respuesta<OPermisos> ObtenerPermisos(OBusquedaParametro par, OLogin login)
        {
            Respuesta<OPermisos> respuesta = new Respuesta<OPermisos>();
            try
            {
                using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
                {
                    var modulosDelUsuario = (from pm in db.PerfilModulo
                                             where ((int)TipoBusquedaEnum.Perfil == par.TipoBusqueda && pm.catPerfilID == par.PerfilID)
                                             select new OModulo
                                             {
                                                 ModuloID = pm.CatModulo.catModuloID,
                                                 DescripcionModulo = pm.CatModulo.descripcion,
                                                 EstatusLogico = pm.CatModulo.estatusLogico
                                             }).ToList();

                    var subModulosDelUsuario = (from pm in db.PerfilModulo
                                                join ms in db.ModuloSubmodulo on pm.catModuloID equals ms.catModuloID
                                                where ((int)TipoBusquedaEnum.Perfil == par.TipoBusqueda && pm.catPerfilID == par.PerfilID)
                                                select new OSubModulo
                                                {
                                                    SubmoduloID = ms.CatSubmodulo.catSubmoduloID,
                                                    DescripcionSubModulo = ms.CatSubmodulo.descripcion,
                                                    EstatusLogico = ms.CatSubmodulo.estatusLogico,
                                                    ModuloID = ms.CatModulo.catModuloID,
                                                    Url = ms.CatSubmodulo.url
                                                }).ToList();

                    // ESTO PA QUE INGADOS SE OCUPA?????
                    /*var accionesDelUsuario = (from ea in db.EstatusAccion
                                              join pm in db.EstatusPerfil on ea.estatusAccionID equals pm.estatusAccionID
                                              where ((int)TipoBusquedaEnum.Perfil == par.TipoBusqueda && pm.perfilID == par.PerfilID)
                                              select new OAccion
                                              {
                                                  AccionID = ea.CatAcciones.accionesID,
                                                  Accion = ea.CatAcciones.accion,
                                                  DescripcionAccion = ea.CatAcciones.descripcionAccion,
                                                  EstatusLogico = ea.CatAcciones.estatusLogico
                                              }).ToList(); */

                    var permisos = new OPermisos
                    {
                        Modulos = modulosDelUsuario,
                        SubModulos = subModulosDelUsuario,
                        //Acciones = accionesDelUsuario
                    };

                    respuesta.TipoRespuesta = new OPermisos();
                    respuesta.TipoRespuesta = permisos;
                    respuesta.MensajeUsuario = Constantes.CONINFORMACION;
                }
            }
            catch (Exception ex)
            {
                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "ObtenerPermisos",
                    formulario = "DGestionUsuarios",
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