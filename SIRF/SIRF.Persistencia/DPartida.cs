using SIRF.Objetos;
using SIRF.Utilerias;
using SIRF.Mensajes;
using System.Collections.Generic;
using System.Linq;

namespace SIRF.Persistencia
{
    /// <summary>
    /// Clase de la capa de datos correspondiente al catalogo de Patidas
    /// </summary>
    public class DPartida : Instance<DPartida>
    {
        /// <summary>
        /// Consulta catálogo de partida
        /// </summary>
        /// <param name="tipoSolicitudID">Filtro</param>
        /// <param name="soloActivos">Filtro opcional</param>
        /// <param name="zonaPartidas">Filtro opcional</param>
        /// <returns></returns>
        public List<OPartida> ObtenerLista(int tipoSolicitudID, bool soloActivos, string zonaPartidas)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {
                var consulta = (from cp in db.CatPartida
                                where cp.catSolicitudID == tipoSolicitudID && cp.concepto == 3700 &&
                                    cp.estatusLogico == (soloActivos == false || cp.estatusLogico)
                                    && (
                                    (zonaPartidas == "Mexico" && (cp.catPartidaID == 37502 || cp.catPartidaID == 37504))
                                    || (zonaPartidas == "Extranjero" && (cp.catPartidaID == 37601 || cp.catPartidaID == 37602))
                                    || zonaPartidas == "Todo") && cp.estatusLogico
                                select new OPartida
                                {
                                    CodPartida = cp.catPartidaID,
                                    ConceptoGtoCorriente = cp.denominacion,
                                    DescripcionPartida = cp.descripcion,
                                    Capitulo = cp.capitulo,
                                    Concepto = cp.concepto,
                                    Denominacion = cp.denominacion,
                                    EstatusLogico = cp.estatusLogico
                                }).ToList();

                consulta.Add(new OPartida() { CodPartida = -1, Denominacion = Constantes.SELECTOPTION });
                return consulta.OrderBy(p => p.CodPartida).ToList();
            }
        }

        /// <summary>
        /// Consulta catálogo de partida
        /// </summary>
        /// <param name="tipoSolicitudID">Filtro</param>
        /// <param name="soloActivos">Filtro opcional</param>
        /// <param name="zonaPasajes">Filtro opcional</param>
        /// <returns></returns>
        public List<OPartida> ObtenerListaPasajes(int tipoSolicitudID, bool soloActivos, string zonaPasajes)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {
                var consulta = (from cp in db.CatPartida
                                where cp.catSolicitudID == tipoSolicitudID && cp.concepto == 3701 &&
                                    cp.estatusLogico == (soloActivos == false || cp.estatusLogico)
                                    && (
                                    (zonaPasajes == "Mexico" && (cp.catPartidaID != 37105))
                                    || (zonaPasajes == "Extranjero" && (cp.catPartidaID == 37105))
                                    || zonaPasajes == "Todo") && cp.estatusLogico
                                select new OPartida
                                {
                                    CodPartida = cp.catPartidaID,
                                    ConceptoGtoCorriente = cp.denominacion,
                                    DescripcionPartida = cp.descripcion,
                                    Capitulo = cp.capitulo,
                                    Concepto = cp.concepto,
                                    Denominacion = cp.denominacion,
                                    EstatusLogico = cp.estatusLogico
                                }).ToList();

                consulta.Add(new OPartida() { CodPartida = -1, Denominacion = Constantes.SELECTOPTION });
                return consulta.OrderBy(p => p.CodPartida).ToList();
            }
        }

        public string getPartidabyId(int PartidaId)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {
                var consulta = (from cp in db.CatPartida
                                where cp.catPartidaID == PartidaId
                                select cp.denominacion);

                return consulta.First();
            }
        }

    }
}
