using SIRF.Objetos;
using SIRF.Utilerias;
using System.Collections.Generic;
using System.Linq;
using SIRF.Mensajes;

namespace SIRF.Persistencia
{
    /// <summary>
    /// 
    /// </summary>
    public class DUnidadAdministrativa : Instance<DUnidadAdministrativa>
    {
        /// <summary>
        /// Consulta de unidades administrativas por region
        /// </summary>
        /// <param name="region"></param>
        /// <returns></returns>
        public List<OSelect> ObtenerLista(ORegion region)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {

                var consulta = (from ua
                    in db.CatUnidadAdm
                                where
                                ua.estatusLogico // Esta linea se descomenta en base a las observaciones del 28/02/2017
                                select new OSelect()
                                {
                                    Valor = ua.catUnidadAdmID,
                                    Concepto = ua.descripcion,
                                }).ToList();

                consulta.Add(new OSelect()
                {
                    Valor = -1,
                    Concepto = Constantes.SELECTOPTION
                });
                return consulta.OrderBy(u => u.Valor).ToList();

            }
        }

        /// <summary>
        /// Lista por region
        /// </summary>
        /// <param name="regionId"></param>
        /// <returns></returns>
        public List<OUnidadAdministrativa> ObtenerListaPorRegionId(int regionId)
        {
            using (var db = new SIRFPROD_v2Entities())
            {
                var consulta = (from ua
                    in db.CatUnidadAdm
                                where ua.catRegionID == regionId && ua.estatusLogico
                                select new OUnidadAdministrativa
                                {
                                    CodUA = ua.catUnidadAdmID,
                                    UnidadAdministrativa = ua.descripcion,
                                    CodigoPadre = ua.codigoPadre,
                                    Abreviatura = ua.abreviatura,
                                    Activo = ua.estatusLogico,
                                    Region = new ORegion
                                    {
                                        RegionID = ua.catRegionID
                                    }
                                }).ToList();

                consulta.Add(new OUnidadAdministrativa
                {
                    CodUA = -1,
                    UnidadAdministrativa = Constantes.SELECTOPTION
                });
                return consulta.OrderBy(u => u.CodUA).ToList();

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codUa"></param>
        /// <returns></returns>
        public OUnidadAdministrativa ObtenerPorCodUA(int codUa)
        {
            using (var db = new SIRFPROD_v2Entities())
            {
                var consulta = (from ua
                    in db.CatUnidadAdm
                                where ua.catUnidadAdmID == codUa && ua.estatusLogico
                                select new OUnidadAdministrativa
                                {
                                    CodUA = ua.catUnidadAdmID,
                                    UnidadAdministrativa = ua.descripcion,
                                    CodigoPadre = ua.codigoPadre,
                                    Abreviatura = ua.abreviatura,
                                    Activo = ua.estatusLogico,
                                    Region = new ORegion
                                    {
                                        RegionID = ua.catRegionID
                                    }
                                }).FirstOrDefault();
                return consulta;
            }
        }
    }
}
