using SIRF.Utilerias;
using SIRF.Objetos;
using SIRF.Persistencia;
using System;
using System.Collections.Generic;
using SIRF.Mensajes;

namespace SIRF.Negocio
{
    /// <summary>
    /// Clase de negocio correspondiente a la Gestion de usuarios.
    /// </summary>
    public class NGestionUsuarios : Instance<NGestionUsuarios>
    {
        //NGestionLogError _logs;
        OLogError _logError;

        /// <summary>
        /// Método para la obtención de la información del usuario.
        /// </summary>
        /// <param name="par">Parametros de búsqueda.</param>
        /// <param name="login">Parametros de búsqueda.</param>
        /// <returns>Respuesta genérica de tipo OLogin</returns>        
        public Respuesta<OUsuario> ObtenerUsuario(OBusquedaParametro par, OLogin login)
        {
            Respuesta<OUsuario> respuesta = new Respuesta<OUsuario>();
            try
            {
                if (String.IsNullOrEmpty(par.TipoBusqueda.ToString()))
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, par.TipoBusqueda.ToString());
                }
                if (String.IsNullOrEmpty(par.Descripcion))
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, par.Descripcion);
                }
                respuesta = DGestionUsuarios.Instances.ObtenerUsuario(par, login);
            }
            catch (Exception ex)
            {
                respuesta.TipoEstatus = TipoEstatus.Error;
                respuesta.ListaErrores = new List<string> { ex.Message };

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "ObtenerUsuario",
                    formulario = "NGestionUsuarios",
                    ex = ex,
                    usuarioID = login.Usuario.UsuarioID,
                    ipEquipo = login.Usuario.ip
                };




                //Revisar por que no se ve el "Guardar"  
                NGestionLogError.Instances.GuardarError(_logError, login);
            }
            return respuesta;
        }
        /// <summary>
        /// Método para la obtención de la(s) IP(s) registrada(s) al usuario logueado.
        /// </summary>
        /// <param name="par">Parametros de búsqueda.</param>
        /// <param name="login">Parametros de tipo OLogin.</param>
        /// <returns>Respuesta genérica de tipo OIpv4</returns>       
        public Respuesta<OIpv4> ObtenerIPs(OBusquedaParametro par, OLogin login)
        {
            Respuesta<OIpv4> respuesta = new Respuesta<OIpv4>();
            try
            {
                if (String.IsNullOrEmpty(par.TipoBusqueda.ToString()))
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, par.TipoBusqueda.ToString());
                }
                if (String.IsNullOrEmpty(par.Descripcion))
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, par.Descripcion);
                }
                if (String.IsNullOrEmpty(par.UsuarioID.ToString()))
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, par.UsuarioID.ToString());
                }
            }
            catch (Exception ex)
            {
                respuesta.TipoEstatus = TipoEstatus.Error;
                respuesta.ListaErrores = new List<string> { ex.Message };
                
                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "ObtenerIPs",
                    formulario = "NGestionUsuarios",
                    ex = ex,
                    usuarioID = login.Usuario.UsuarioID,
                    ipEquipo = login.Usuario.ip
                };




                //Revisar por que no se ve el "Guardar"  
                NGestionLogError.Instances.GuardarError(_logError, login);
            }
            return respuesta;
        }

        public OUsuario GetUsuarioKardex(Int32 numeroExpediente)
        {
            DGestionUsuarios gestion = new DGestionUsuarios();
            return gestion.GetUsuarioKardex(numeroExpediente);
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
                if (String.IsNullOrEmpty(par.TipoBusqueda.ToString()))
                {
                    throw new ArgumentException(Constantes.PARAMETROVACIOONULO, par.TipoBusqueda.ToString());
                }
                respuesta = DGestionUsuarios.Instances.ObtenerPermisos(par, login);
            }
            catch (Exception ex)
            {
                respuesta.TipoEstatus = TipoEstatus.Error;
                respuesta.ListaErrores = new List<string> { ex.Message };

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "ObtenerPermisos",
                    formulario = "NGestionUsuarios",
                    ex = ex,
                    usuarioID = login.Usuario.UsuarioID,
                    ipEquipo = login.Usuario.ip
                };



                //Revisar por que no se ve el "Guardar"  
                NGestionLogError.Instances.GuardarError(_logError, login);
            }
            return respuesta;
        }
    }
}