using SIRF.Objetos;
using SIRF.Utilerias;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Reflection;

namespace SIRF.Persistencia
{
    public class DExpedienteCuenta : Instance<DExpedienteCuenta>
    {
        StackTrace _stackTrace;
        StackFrame _stackFrame;
        MethodBase _currentMethodName;
        OLogError _logError;
        /// <summary>
        /// Obtiene las cuentas bancarias del integrate : Author JUVA
        /// </summary>
        /// <param name="numeroExpediente">Numero de expediente</param>
        /// <returns>Cuentas</returns>
        public List<OExpedienteCuenta> ObtenerCuentasIntegrante(int numeroExpediente)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {
                var consulta = (from vwc in db.vwCuentasIntegrante
                                where
                                    vwc.expediente == numeroExpediente &&
                                    vwc.estatusLogico == true
                                select new OExpedienteCuenta
                                {
                                    Expediente = vwc.expediente,
                                    DescripcionCuenta = vwc.descripcionCuenta,
                                    CLABEInterbancaria = vwc.clabeInterbancaria,
                                    DescripcionBanco = vwc.descripcion,
                                    TipoCuentaID = vwc.tipoCuentaID,
                                    DescripcionTipoCuenta = vwc.descripcionTipoCuenta,
                                    EstatusLogico = vwc.estatusLogico,
                                }).ToList();

                return consulta.OrderBy(c => c.TipoCuentaID).ToList();
            }
        }
    }
}
