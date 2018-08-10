using SIRF.Objetos;
using System.Collections.Generic;
using System.Linq;
using SIRF.Mensajes;

namespace SIRF.Persistencia
{
    public class DRegion
    {
        public List<OSelect> ObtenerListaTodas()
        {
            using (var db = new SIRFPROD_v2Entities())
            {
                var consulta = (from cs
                    in db.CatRegion
                                where cs.estatusLogico //MM Agrega quitar los inactivos
                                select new OSelect()
                    {
                        Valor = cs.regionID,
                        Concepto = cs.descripcion.Trim(),
                    }).ToList();

                consulta.Add(new OSelect()
                {
                    Valor = -1,
                    Concepto = Constantes.SELECTOPTION
                });

                return consulta.OrderBy(ts => ts.Valor).ToList();

            }
        }
    }
}
