using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SIRF.Mensajes;
using SIRF.Negocio;
using SIRF.Objetos;
using SIRF.Utilerias;

namespace SIRF.Controllers
{
    public class SolicitudController : Controller
    {
        //
        // GET: /Solicitud/
        public ActionResult frmTipoSolicitud()
        {
            return PartialView();
        }

        public ActionResult frmSolicitudViaticos()
        {
            return PartialView();
        }

        [HttpPost]
        public JsonResult RenderTipoSolicitud()
        {
            OLogin loginModelo = (OLogin)Session["Login"];
            var tipoSolicitud = new NTipoSolicitud();
            List<OSelect> lstTipoSolicitudModelo = tipoSolicitud.ObtenerLista(loginModelo.Usuario.RegionID, true);

            lstTipoSolicitudModelo.RemoveAll(ts => ts.Valor == (Int32)TipoSolicitudEnum.PROVEEDORES);
            string ddlTipoSolicitud = ConstruccionSelect.GetSelect(lstTipoSolicitudModelo);
            return Json(ddlTipoSolicitud, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult ddlTipoSolicitud_SelectedIndexChanged(OSelect selector)
        {
            string url = "";
            switch (selector.Valor)
            {
                case 13:// Viaticos Nacionales Anticipados
                case 22:// Viaticos Nacionales Devengados
                case 23:// Viaticos Internacionales Anticipados
                case 24:// Viaticos Internacionales Devengados
                    Session["Seleccion"] = selector.Valor;
                    url = "../Solicitud/frmSolicitudViaticos";
                    break;
                case 25: // Cuotas Diarias Pago a Escoltas
                case 26: // Cuotas Diarias de Apoyo (Operatividad)
                    url = "../Solicitud/frmSolicitudCuotas";
                    break;
            }
            return Json(url, JsonRequestBehavior.AllowGet);
        }
    }
}