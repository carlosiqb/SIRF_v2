using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIRF.Mensajes;
using SIRF.Negocio;
using SIRF.Objetos;
using SIRF.Utilerias;

namespace SIRF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Método para obtener la IP o las IP's (en el ambiente de desarrollo) del usuario logueado.
        /// </summary>
        /// <returns></returns>
        private static string GetDesarrollo_IP()
        {
            try
            {
                //string name = Dns.GetHostName();
                string myHost = Dns.GetHostName();

                for (int i = 0; i <= Dns.GetHostEntry(myHost).AddressList.Length - 1; i++)
                {
                    if (Dns.GetHostEntry(myHost).AddressList[i].IsIPv6LinkLocal == false)
                    {
                        return Dns.GetHostEntry(myHost).AddressList[i].ToString();
                    }
                }
            }
            catch (Exception)
            {
                return "";
            }
            return "";
        }

        [HttpPost]
        public JsonResult ConstruccionMenu(OLogin modelo)
        {
            //MM: Obtenemos la variable de session en un objeto tipo LoginModelo
            OLogin login = (OLogin)Session["Login"];
            OMenu menu = new OMenu
            {
                lblNomUsuario = login.Usuario.Nombre.Trim(),
                lblUnidadAdm = login.Usuario.UnidadAdministrativa.Trim()
            };

            menu.lblUnidadAdm += " <br/> " + login.Usuario.DescripcionArea.Trim();
            menu.lblDescripcionPerfil = login.Usuario.DescripcionPerfil.Trim();
            menu.lblTipoRolUsuario = " <br/> " + login.Usuario.DescripcionRol.Trim();
            menu.hdfIPv4 = login.Usuario.ip;

            //MM: Ponemos en la master el menu completo
            string menuCadena = "";

            //MM: Recorremos los Modulos en busca de las opciones principales
            foreach (var mod in login.Modulos)
            {
                var i = 0;
                //MM: Creamos el LI del Modulo (menu principal), este LI se cierra despues del foreach de los submodulos
                menuCadena = menuCadena + "<li class='active'><a data-toggle='collapse' data-parent='#accordion1' href='#firstLink' >&nbsp;" + mod.DescripcionModulo + "</a>";
                foreach (var submod in login.SubModulos)
                {
                    //MM: Si el modulo del Submodulo es del mismo modulo que estamos recorriendo en el FOREACH principal (de Modulos)
                    if (mod.ModuloID == submod.ModuloID)
                    {
                        //MM: Agregamos la opcion del menú con su URL
                        if (i == 0)
                        {//MM: En el primer registro de submod creamos la UL y hacemos que sea igual su ID que el ID de su LI padre. (esta UL se cierra saliendo de este foreach de submod)
                            menuCadena = menuCadena + "<ul id = '" + submod.DescripcionSubModulo.Replace(" ", "") + "' style='background-color:white' class='collapse nav nav-stacked'>";
                            menuCadena = menuCadena.Replace("firstLink", submod.DescripcionSubModulo.Replace(" ", ""));
                        }
                        //MM: Para todos los submenus agregamos su link
                        string menuHost = "../";
                        menuCadena = menuCadena + "<li><a onclick=\"redirect('" + submod.Url.Replace("../", menuHost) + "')\"><span class='glyphicon glyphicon-ok'></span>&nbsp;" + submod.DescripcionSubModulo + "</a></li>";
                        i++;
                    }
                }
                menuCadena = menuCadena + "</ul></li>";
            }
            //MM: Agregamos todo el menu al div accordion1
            menu.accordion1 = menuCadena;
            return Json(menu, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Evento del boton Entrar
        /// </summary>
        [HttpPost]
        public JsonResult btnEntrar_Click(OLogin modelo)
        {
            OLogin login = (OLogin)Session["Login"];

            modelo.Cuenta = "ceenlace.puebla";
            modelo.Password = "123456";

            if (login == null)
            {
                login = new OLogin();
            }
            login.Cuenta = modelo.Cuenta;
            login.Password = modelo.Password;

            Respuesta<string> respuestaLogin =
                NGestionAutenticacion.Instances.AutenticarUsuario(modelo);

            if (respuestaLogin.TipoEstatus == TipoEstatus.Ok)
            {
                //Validar que el usuario logueado exista
                OBusquedaParametro par = new OBusquedaParametro
                {
                    TipoBusqueda = (int)TipoBusquedaEnum.Usuario,
                    Descripcion = modelo.Cuenta
                };
                Respuesta<OUsuario> respuestaUsuario = NGestionUsuarios.Instances.ObtenerUsuario(par, login);

                if (respuestaUsuario.TipoRespuesta == null || respuestaUsuario.TipoEstatus != TipoEstatus.Ok)
                    return Json(respuestaUsuario.MensajeUsuario, JsonRequestBehavior.AllowGet);

                OBusquedaParametro parModulos =
                    new OBusquedaParametro
                    {
                        TipoBusqueda = (int)TipoBusquedaEnum.Perfil,
                        PerfilID = respuestaUsuario.TipoRespuesta.PerfilID
                    };
                Respuesta<OPermisos> respuestPermisos = NGestionUsuarios.Instances.ObtenerPermisos(parModulos, login);

                //Cargar los accesos del usuario logueado
                login = new OLogin { Usuario = respuestaUsuario.TipoRespuesta };

                if (respuestPermisos.TipoRespuesta != null)
                {
                    login.Modulos = respuestPermisos.TipoRespuesta.Modulos.ToList();
                    login.SubModulos = respuestPermisos.TipoRespuesta.SubModulos.ToList();
                    login.Acciones = null; // respuestPermisos.TipoRespuesta.Acciones.ToList(); revisar pa que sirve
                    login.Usuario.ip = GetDesarrollo_IP();
                }

                //Asignamos la variable de session Login con los objetos previamente cargados
                Session["Login"] = login;

                //si todo esta bien avanzar
                return Json("", JsonRequestBehavior.AllowGet);

                //En la pantalla SIRF.aspx se seteará el lblNomUsuario
                //En la pantalla SIRF.aspx se cargara el Menu                                
                //No se cuenta con información de usuario capturado.
            }
            return Json(respuestaLogin.MensajeUsuario, JsonRequestBehavior.AllowGet);
        }
    }
}