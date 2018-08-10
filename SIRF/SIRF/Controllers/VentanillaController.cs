using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;
using SIRF.Negocio;
using SIRF.Objetos;
using SIRF.Utilerias;

namespace SIRF.Controllers
{
    public class VentanillaController : Controller
    {
        //
        // GET: /Ventanilla/
        public ActionResult frmBandejaVentanillaUnica()
        {
            return PartialView();
        }

        [HttpPost]
        public JsonResult CargaSolicitud(OSelect modelo)
        {
            OLogin loginModelo = (OLogin)Session["Login"];
            var servicio = new NTipoSolicitud();
            List<OSelect> lista = servicio.ObtenerLista(loginModelo.Usuario.RegionID, true);
            string ddlTipoSolicitud = ConstruccionSelect.GetSelect(lista);
            return Json(ddlTipoSolicitud, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult CargaRegion(OSelect modelo)
        {
            var servicio = new NRegion();
            List<OSelect> lista = servicio.ObtenerListaTodas();
            string ddlTipoSolicitud = ConstruccionSelect.GetSelect(lista);
            return Json(ddlTipoSolicitud, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult CargaEstatus(OSelect modelo)
        {
            OLogin loginModelo = (OLogin)Session["Login"];
            var servicio = new NEstadoSolicitud();
            List<OSelect> lista = servicio.ObtenerLista(loginModelo.Usuario.PerfilID, true);
            string ddlTipoSolicitud = ConstruccionSelect.GetSelect(lista);
            return Json(ddlTipoSolicitud, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult CargaUnidadAdm(OSelect modelo)
        {
            var servicio = new NUnidadAdministrativa();
            List<OSelect> lista = servicio.ObtenerLista(
                new ORegion { RegionID = 1, DescripcionRegion = string.Empty });
            string ddlTipoSolicitud = ConstruccionSelect.GetSelect(lista);
            return Json(ddlTipoSolicitud, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult CargaFirma(OSelect modelo)
        {
            var servicio = new NFirma();
            List<OSelect> lista = servicio.ObtenerListaTodas();
            string ddlTipoSolicitud = ConstruccionSelect.GetSelect(lista);
            return Json(ddlTipoSolicitud, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult frmCargarSolicitudes(OSolicitud modelo)
        {
            OLogin loginModelo = (OLogin)Session["Login"];

            //*** REVISAR
            DateTime? fechaInicial = null;
            DateTime? fechaFinal = null;
            modelo.periodo = modelo.periodo == null ? "" : modelo.periodo;
            var fechas = modelo.periodo.Split(' ');
            if (fechas.Length == 2)
            {
                fechaFinal = ConvertTime(fechas[1], " 23:59:59");
            }
            fechaInicial = ConvertTime(fechas[0], " 00:00:00");
            
            var filtro = new OSolicitud
            {
                PerfilID = loginModelo.Usuario.PerfilID,
                FolioSolicitud = modelo.FolioSolicitud,
                SolFirmaID = modelo.tipoFirma_int,
                FechaInicial = fechaInicial,
                FechaFinal = fechaFinal,
                UnidadAdministrativa = { CodUA = modelo.uniAdministrativa_int },
                Region = { RegionalID = modelo.region_int },
                TipoSolicitud = { TipoSolicitudID = modelo.tipoSolicitud_int },
                Estatus = { EstatusID = modelo.estatus_int },
            };

            var solicitudControl = new NSolicitud();
            var lstSolicitudModeloRepetidos = solicitudControl.ObtenerSolicitudesVentanillaUnica(filtro);

            return PartialView(lstSolicitudModeloRepetidos);
        }

        private DateTime? ConvertTime(string auxIni, string time)
        {
            if (string.IsNullOrEmpty(auxIni)) return null;
            var indices = auxIni.Split('/').Length;
            if (indices != 3) return null;
            var strDate = auxIni + time;
            return DateTime.ParseExact(strDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }
    }
}