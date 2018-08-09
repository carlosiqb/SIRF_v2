using SIRF.Objetos;
using System.Collections.Generic;
using System.Linq;
using SIRF.Mensajes;

namespace SIRF.Persistencia
{
    public class DFirma
    {
        public List<OFirma> ObtenerListaTodas()
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {

                var consulta = (from cs
                    in db.CatFirma
                                where cs.EstadoLogico == true //MM Agrega quitar los inactivos
                                select new OFirma
                                {
                                    FirmaID = cs.catFirmaID,
                                    Descripcion = cs.Descripcion.Trim(),
                                    EstadoLogico = cs.EstadoLogico
                                }).ToList();

                consulta.Add(new OFirma
                {
                    FirmaID = -1,
                    Descripcion = Constantes.SELECTOPTION
                });

                return consulta.OrderBy(ts => ts.FirmaID).ToList();

            }
        }
    }
}
