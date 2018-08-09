using SIRF.Objetos;
using SIRF.Utilerias;
using SIRF.Mensajes;
using System.Collections.Generic;
using System.Linq;

namespace SIRF.Datos
{
    public class DTipoSolicitud : Instance<DTipoSolicitud>
    {
        /// <summary>
        /// Consulta los tipos de solicitud : Authos JUVA
        /// </summary>
        /// <param name="regionID">Filtro</param>
        /// <param name="soloActivas">Filtro opcional</param>
        /// <returns></returns>
        public List<OTipoSolicitud> ObtenerLista(int regionID, bool soloActivas)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {

                var consulta = (from cs in db.CatSolicitud
                                join a in db.SolicitudCatUnidadAdm on cs.catSolicitudID equals a.catSolicitudID
                                where
                                    //// (cs.catRegionID == regionID && ---> ESTO QUE???
                                    cs.estatusLogico == (soloActivas == false ? cs.estatusLogico : soloActivas)
                                select new OTipoSolicitud
                                {
                                    TipoSolicitudID = cs.catSolicitudID,
                                    DescripcionTipoSolicitud = cs.descripcion.Trim(),
                                    TipoSolicitudControlCod = cs.tipoSolicitudControlCod,
                                    EstatusLogico = cs.estatusLogico,
                                    Region = new ORegion
                                    {
                                        RegionID = 1 // --->>> ES POR UNIDAD_ADM Y NO POR REGION
                                    }
                                }).ToList();

                consulta.Add(new OTipoSolicitud
                {
                    TipoSolicitudID = -1,
                    DescripcionTipoSolicitud = Constantes.SELECTOPTION,
                    EstatusLogico = true
                });

                return consulta.OrderBy(ts => ts.TipoSolicitudID).ToList();

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<OTipoSolicitud> ObtenerLista()
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {

                var consulta = (from cs
                             in db.CatSolicitud
                                //join cr in db.CatRegion
                                //on cs.regionID equals cr.regionID
                                //where ((cs.regionID == regionID)
                                //        && (cs.estatusLogico == true))
                                where cs.estatusLogico //MM Agrega quitar los inactivos
                                select new OTipoSolicitud
                                {
                                    TipoSolicitudID = cs.catSolicitudID,
                                    DescripcionTipoSolicitud = cs.descripcion.Trim(),
                                    TipoSolicitudControlCod = cs.tipoSolicitudControlCod,
                                    EstatusLogico = cs.estatusLogico,
                                    AreaPago = cs.areaPago,
                                    Region = new ORegion
                                    {
                                        //EstatusLogico = cr.estatusLogico,
                                        RegionID = 1 // --->>> ES POR UA, NO POR CAT_REGION
                                        //DescripcionRegion = cr.descripcionRegion
                                    }
                                }).ToList();

                consulta.Add(new OTipoSolicitud
                {
                    TipoSolicitudID = -1,
                    DescripcionTipoSolicitud = Constantes.SELECTOPTION
                });

                return consulta.OrderBy(ts => ts.TipoSolicitudID).ToList();

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="regionID"></param>
        /// <param name="codUa"></param>
        /// <param name="soloActivas"></param>
        /// <returns></returns>
        public List<OTipoSolicitud> ObtenerLista(int regionID, int codUa, bool soloActivas)
        {
            using (var db = new SIRFPROD_v2Entities())
            {
                var consulta = (
                                from rel in db.TipoSolicitudPorUA
                                join cs in db.CatSolicitud on rel.catSolicitudID equals cs.catSolicitudID
                                where
                                    // cs.catRegionID == regionID &&--->>> ES POR REGION Y NO POR UA
                                        rel.catUnidadAdmID == codUa
                                        && cs.estatusLogico == (soloActivas == false ? cs.estatusLogico : soloActivas)

                                select new OTipoSolicitud
                                {
                                    TipoSolicitudID = cs.catSolicitudID,
                                    DescripcionTipoSolicitud = cs.descripcion,
                                    TipoSolicitudControlCod = cs.tipoSolicitudControlCod,
                                    EstatusLogico = cs.estatusLogico,
                                    Region = new ORegion
                                    {
                                        RegionID = 1 // cs.catRegionID ES POR UA
                                    }
                                }).ToList();

                consulta.Add(new OTipoSolicitud
                {
                    TipoSolicitudID = -1,
                    DescripcionTipoSolicitud = Constantes.SELECTOPTION,
                    EstatusLogico = true
                });

                return consulta.OrderBy(ts => ts.TipoSolicitudID).ToList();

            }
        }
    }
}
