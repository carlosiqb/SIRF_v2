using SIRF.Objetos;
using System.Collections.Generic;
using System.Linq;
using SIRF.Mensajes;

namespace SIRF.Persistencia
{
    public class DRegion
    {
        public List<ORegion> ObtenerListaTodas()
        {
            using (var db = new SIRFPROD_v2Entities())
            {
                var consulta = (from cs
                    in db.CatRegion
                                where cs.estatusLogico //MM Agrega quitar los inactivos
                                select new ORegion
                    {
                        RegionID = cs.regionID,
                        DescripcionRegion = cs.descripcion.Trim(),
                        EstatusLogico = cs.estatusLogico
                    }).ToList();

                consulta.Add(new ORegion
                {
                    RegionID = -1,
                    DescripcionRegion = Constantes.SELECTOPTION
                });

                return consulta.OrderBy(ts => ts.RegionID).ToList();

            }
        }
    }
}
