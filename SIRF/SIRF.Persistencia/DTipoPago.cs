using SIRF.Objetos;
using SIRF.Utilerias;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Reflection;
using SIRF.Mensajes;

namespace SIRF.Persistencia
{
    public class DTipoPago : Instance<DTipoPago>
    {
        StackTrace _stackTrace;
        StackFrame _stackFrame;
        MethodBase _currentMethodName;
        OLogError _logError;
        /// <summary>
        /// Consulta catálogo de bancos
        /// </summary>
        /// <param name="soloActivos">Filtro opcional</param>
        /// <param name="TipoSolControlCod">Filtro</param>
        /// <returns></returns>
        public List<OTipoPago> ObtenerLista(bool soloActivos = false, int TipoSolControlCod = 0)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {
                // var tiposSolicitudes = db.CatSolicitud.Where(s => s.catSolicitudID == TipoSolControlCod).Select(s=>s.tipoSolicitudControlCod).ToList();

                var consulta = (from tp in db.CatPago
                                where tp.estatusLogico == (soloActivos || tp.estatusLogico)
                                // && tiposSolicitudes.Contains(tp.tipoSolicitudControlCod) --> REVISAR ESTE WHERE
                                select new OTipoPago
                                {
                                    TipoPagoID = tp.catPagoID,
                                    DescripcionTipoPago = tp.descripcion,
                                    EstatusLogico = tp.estatusLogico
                                }).ToList();


                consulta.Add(new OTipoPago() { TipoPagoID = -1, DescripcionTipoPago = Constantes.SELECTOPTION });
                return consulta.OrderBy(p => p.TipoPagoID).ToList();
            }
        }
    }
}
