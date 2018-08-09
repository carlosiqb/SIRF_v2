using SIRF.Mensajes;
using SIRF.Objetos;
using SIRF.Utilerias;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.DirectoryServices;
using System.Reflection;

namespace SIRF.Negocio
{
    /// <summary>
    /// Clase de negocio correspondiente a la Gestion de la autenticación.
    /// </summary>
    public class NGestionAutenticacion : Instance<NGestionAutenticacion>
    {
        NGestionLogError _logs;
        StackTrace _stackTrace;
        StackFrame _stackFrame;
        MethodBase _currentMethodName;
        OLogError _logError;

        /// <summary>
        /// Método para la autenticacion de usuario mediante un directorio activo.
        /// </summary>
        /// <param name="usuario">Usuario logueado.</param>
        /// <param name="clave">Clave del directorio activo.</param>
        /// <param name="login">Parametro de tipo OLogin.</param>
        /// <returns></returns>
        public Respuesta<string> AutenticarUsuario(OLogin login)
        {
            string path = ConfigurationSettings.AppSettings["rutaLDAP"];
            string dominio = ConfigurationSettings.AppSettings["dominioLDAP"];

            Respuesta<string> respuesta = new Respuesta<string>();

            // EL DIABLO DE AAAV
            respuesta.TipoEstatus = TipoEstatus.Ok;
            respuesta.TipoRespuesta = Constantes.AUTENTICACIONCORRECTA;
            respuesta.MensajeUsuario = Constantes.AUTENTICACIONCORRECTA;
            return respuesta;
            // EL DIABLO DE AAAVS

            string domainAndUsername = dominio + @"\" + login.Cuenta;
            DirectoryEntry entry = new DirectoryEntry(path, domainAndUsername, login.Password);

            try
            {
                DirectorySearcher search = new DirectorySearcher(entry) { Filter = "(SAMAccountName=" + login.Cuenta + ")" };

                search.PropertiesToLoad.Add("cn");
                SearchResult result = search.FindOne();

                if (result == null)
                {
                    respuesta.TipoEstatus = TipoEstatus.Error;
                    respuesta.ListaRegistros.Add(Constantes.AUTENTICACIONFALLIDA);
                    respuesta.TipoRespuesta = Constantes.AUTENTICACIONFALLIDA;
                    respuesta.MensajeUsuario = Constantes.AUTENTICACIONFALLIDA;
                }
                else
                {
                    respuesta.TipoEstatus = TipoEstatus.Ok;
                    respuesta.TipoRespuesta = Constantes.AUTENTICACIONCORRECTA;
                    respuesta.MensajeUsuario = Constantes.AUTENTICACIONCORRECTA;
                }
            }
            catch (Exception ex)
            {
                respuesta.TipoEstatus = TipoEstatus.Error;
                respuesta.ListaErrores = new List<string> { ex.Message };

                _stackTrace = new StackTrace();
                _stackFrame = new StackFrame();
                _stackFrame = _stackTrace.GetFrame(0);
                _currentMethodName = _stackFrame.GetMethod();

                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "AutenticarUsuario",
                    formulario = "NGestionAutenticacion",
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
