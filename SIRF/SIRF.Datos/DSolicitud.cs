using SIRF.Objetos;
using SIRF.Utilerias;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SIRF.Datos
{
    public class DSolicitud : Instance<DSolicitud>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<OSolicitud> ObtenerSolicitudesVentanillaUnica(OSolicitud filtro)
        {
            List<OSolicitud> listaSolicitudes;

            filtro.FolioSolicitud = string.IsNullOrEmpty(filtro.FolioSolicitud) ? "" : filtro.FolioSolicitud;

            using (var modelo = new SIRFPROD_v2Entities())
            {
                var consultaEdos = (from es in modelo.CatEstatusSolicitud
                                    join ep in modelo.EstatusPerfil on es.catEstatusSolicitudID equals ep.catEstatusSolicitudID
                                    where
                                    ep.catPerfilID == filtro.PerfilID &&
                                    es.estatusLogico
                                    select es.catEstatusSolicitudID).ToList();

                listaSolicitudes = (from sol in modelo.SolicitudRecurso.Where(s => s.solicitudRecursoID != 0 && consultaEdos.Contains(s.catEstatusSolicitudID))
                                    join sofi in modelo.SolicitudFirma.Where(s => s.EstatusLogico != null) on sol.solicitudRecursoID equals sofi.solicitudRecursoID
                                    join oReg in modelo.RegistroContable on sol.solicitudRecursoID equals oReg.solicitudRecursoID into oRegLeft
                                    from oR in oRegLeft.DefaultIfEmpty()
                                    join cfi in modelo.CatFirma on sofi.catFirmaID equals cfi.catFirmaID into cfiLeft
                                    from cF in cfiLeft.DefaultIfEmpty()
                                    join em in modelo.EstatusMovimiento on sol.solicitudRecursoID equals em.solicitudRecursoID into emLeft
                                    from eM in emLeft.DefaultIfEmpty()
                                    where
                                    (filtro.Estatus.EstatusID == -1 || sol.catEstatusSolicitudID == filtro.Estatus.EstatusID) &&
                                    (filtro.Region.RegionalID == -1 || sol.CatUnidadAdm.catRegionID == filtro.Region.RegionalID) &&
                                    (filtro.SolFirmaID == -1 || sofi.catFirmaID == filtro.SolFirmaID) &&
                                    (filtro.UnidadAdministrativa.CodUA == -1 || sol.catUnidadAdmID == filtro.UnidadAdministrativa.CodUA) &&
                                    (filtro.TipoSolicitud.TipoSolicitudID == -1 || sol.catSolicitudID == filtro.TipoSolicitud.TipoSolicitudID) &&
                                    (filtro.FolioSolicitud == "" || sol.folioSolicitud.Contains(filtro.FolioSolicitud)) &&
                                    (filtro.FechaInicial == null && filtro.FechaFinal == null || (filtro.FechaFinal != null && filtro.FechaInicial != null ?
                                         sofi.FechaFirma >= filtro.FechaInicial && sofi.FechaFirma <= filtro.FechaFinal :
                                         (filtro.FechaFinal != null ? sofi.FechaFirma <= filtro.FechaFinal :
                                             sofi.FechaFirma >= filtro.FechaInicial
                                         )
                                     )
                                    )
                                    select new OSolicitud
                                    {
                                        SolicitudID = sol.solicitudRecursoID,
                                        FolioSolicitud = sol.folioSolicitud,
                                        TipoSolicitud = new OTipoSolicitud
                                        {
                                            TipoSolicitudID = sol.catSolicitudID,
                                            DescripcionTipoSolicitud = sol.CatSolicitud.descripcion
                                        },
                                        ConsecutivoFolGen = oR == null ? 0 : oR.consecutivo,
                                        Prioridad = new OPrioridad
                                        {
                                            PrioridadID = sol.catPrioridadID,
                                            DescripcionPrioridad = sol.CatPrioridad.descripcion
                                        },
                                        UnidadAdministrativa = new OUnidadAdministrativa
                                        {
                                            CodUA = sol.CatUnidadAdm.catUnidadAdmID,
                                            UnidadAdministrativa = sol.CatUnidadAdm.descripcion,
                                            Abreviatura = sol.CatUnidadAdm.abreviatura
                                        },
                                        FechaSolicitud = sofi.FechaFirma,
                                        Observaciones = sol.observaciones,
                                        OficioSolicitud = sol.oficioSolicitud,
                                        FechaControl = sol.fechaControl,
                                        FechaActualizacion = sol.fechaActualizacion,
                                        SolFirmaID = sofi.catFirmaID,
                                        Descripcion = cF == null ? "" : cF.Descripcion,
                                        EstatusLogico = sofi.EstatusLogico,
                                        Estatus = new OEstatusSolicitud
                                        {
                                            EstatusID = sol.catEstatusSolicitudID,
                                            DescripcionCorta = sol.CatEstatusSolicitud.descripcionCorta,
                                            DescripcionEstatus = sol.CatEstatusSolicitud.descripcion
                                        },
                                        Rechazada = eM == null
                                    }
                    ).Where(s => s.SolicitudID != 0)
                    .ToList().GroupBy(p => p.SolicitudID).Select(grp => grp.First()).ToList()
                    .OrderByDescending(x => x.Rechazada)
                    .ToList();

                listaSolicitudes.ForEach(s =>
                    {
                        s.Monto = CalculoMonto(s.TipoSolicitud.TipoSolicitudID, s.SolicitudID, modelo);
                    }
                );
            }
            return listaSolicitudes;
        }

        private static decimal CalculoMonto(int tipoSolicitud, int solicitudId, SIRFPROD_v2Entities modelo)
        {
            decimal? monto = 0;
            switch (tipoSolicitud)
            {
                case 1: monto = modelo.Agregaduria.Where(s => s.solicitudRecursoID == solicitudId).Sum(s => s.montoSolicitado); break;
                case 2: monto = modelo.Beca.Where(s => s.solicitudRecursoID == solicitudId && s.estatusLogico).Sum(s => s.montoDepositar); break;
                case 3: monto = modelo.GastoCorriente.Where(s => s.solicitudRecursoID == solicitudId).Sum(s => s.montoSolicitado); break;
                case 4: monto = modelo.GastoFunerario.Where(s => s.solicitudRecursoID == solicitudId).Sum(s => s.monto); break;
                case 5: monto = modelo.GastoAduana.Where(s => s.solicitudRecursoID == solicitudId).Sum(s => s.importeSolicitado); break;
                case 6: monto = modelo.ImpuestoSobreNomina.Where(s => s.solicitudRecursoID == solicitudId).Sum(s => s.importe); break;
                case 7: monto = modelo.Laudo.Where(s => s.solicitudRecursoID == solicitudId && s.estatusLogico == true).Sum(s => s.importe); break;
                case 8: monto = (from v in modelo.LugarSolicitudRecurso
                                 join a in modelo.DetalleSolicitudRecurso on v.detalleSolicitudRecursoID equals a.detalleSolicitudRecursoID
                                 where a.solicitudRecursoID == solicitudId && a.estatusLogico
                                 select v.importeOtorgado
                ).Sum(); break;
                case 9: monto = modelo.Becalos.Where(s => s.solicitudRecursoID == solicitudId).Sum(s => s.montoOtorgado); break;
                case 10: monto = modelo.Proveedor.Where(s => s.solicitudRecursoID == solicitudId).Sum(s => s.total); break;
                case 11: monto = (from v in modelo.LugarSolicitudRecurso
                                  join a in modelo.DetalleSolicitudRecurso on v.detalleSolicitudRecursoID equals a.detalleSolicitudRecursoID
                                  where a.solicitudRecursoID == solicitudId && a.estatusLogico
                                  select v.importeOtorgado
                ).Sum(); break;
                case 12: monto = modelo.GastoCorriente.Where(s => s.solicitudRecursoID == solicitudId).Sum(s => s.montoSolicitado); break;
                case 13: monto = (from v in modelo.LugarSolicitudRecurso
                                  join a in modelo.DetalleSolicitudRecurso on v.detalleSolicitudRecursoID equals a.detalleSolicitudRecursoID
                                  where a.solicitudRecursoID == solicitudId && a.estatusLogico
                                  select v.importeOtorgado
                ).Sum(); break;
            }
            if (monto == null) monto = 0;
            decimal montoFinal = (Decimal)monto;
            return montoFinal;
        }
    }
}
