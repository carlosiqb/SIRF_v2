using SIRF.Objetos;
using System.Collections.Generic;
using System.Linq;
using SIRF.Mensajes;

namespace SIRF.Persistencia
{
    public class DFirma
    {
        public List<OSelect> ObtenerListaTodas()
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {

                var consulta = (from cs
                    in db.CatFirma
                                where cs.EstadoLogico == true //MM Agrega quitar los inactivos
                                select new OSelect()
                                {
                                    Valor = cs.catFirmaID,
                                    Concepto= cs.Descripcion.Trim(),
                                }).ToList();

                consulta.Add(new OSelect()
                {
                    Valor = -1,
                    Concepto= Constantes.SELECTOPTION
                });

                return consulta.OrderBy(ts => ts.Valor).ToList();

            }
        }
    }
}
