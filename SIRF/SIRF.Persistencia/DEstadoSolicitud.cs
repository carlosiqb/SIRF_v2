using SIRF.Objetos;
using SIRF.Utilerias;
using System.Collections.Generic;
using System.Linq;
using SIRF.Mensajes;

namespace SIRF.Persistencia
{
    public class DEstadoSolicitud : Instance<DEstadoSolicitud>
    {
        /// <summary>
        /// Catálogo : Author ?
        /// </summary>
        /// <param name="perfilID">Filtro por perfil</param>
        /// <returns>Estatus correspondientes al perfil</returns>
        public List<OEstatusSolicitud> ObtenerLista(int perfilID, bool estatusLogico)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {

                var consulta = (from es in db.CatEstatusSolicitud
                                join ep in db.EstatusPerfil
                                on es.catEstatusSolicitudID equals ep.catEstatusSolicitudID
                                where
                                ep.catPerfilID == perfilID &&
                                es.estatusLogico == estatusLogico
                                select new OEstatusSolicitud
                    {
                        EstatusID = es.catEstatusSolicitudID,
                        DescripcionEstatus = es.descripcion,
                        DescripcionCorta = es.descripcionCorta,
                        EstatusLogico = es.estatusLogico,
                        EstatusSiguiente = es.estatusSiguiente,
                        EstatusDevolucion = es.estatusDevolucion

                    }).ToList();

                if (consulta.Count != 1)
                {
                    consulta.Add(new OEstatusSolicitud
                    {
                        EstatusID = -1,
                        DescripcionEstatus = Constantes.SELECTOPTION,
                        DescripcionCorta = Constantes.SELECTOPTION,
                        EstatusLogico = true
                    });
                }
                return consulta.OrderBy(es => es.EstatusID).ToList();
            }
        }

        public OEstatusSolicitud ObtenerEstatus(int estatusID)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {
                var consulta = (from es
                    in db.CatEstatusSolicitud
                                where es.catEstatusSolicitudID == estatusID
                                select new OEstatusSolicitud
                    {
                        EstatusID = es.catEstatusSolicitudID,
                        DescripcionEstatus = es.descripcion,
                        EstatusSiguiente = es.estatusSiguiente,
                        EstatusDevolucion = es.estatusDevolucion,
                        EstatusAlternativo = es.estatusAlternativo,
                        EstatusAltDev = es.estatusAltDev,
                        EstatusLogico = es.estatusLogico
                    }).FirstOrDefault();

                return consulta;
            }
        }
    }
}
