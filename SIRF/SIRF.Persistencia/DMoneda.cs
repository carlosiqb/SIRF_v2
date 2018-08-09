using SIRF.Objetos;
using SIRF.Utilerias;
using SIRF.Mensajes;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Reflection;

namespace SIRF.Persistencia
{
    /// <summary>
    /// Clase de la capa de datos correspondiente al catalogo de Patidas
    /// </summary>
    public class DMoneda : Instance<DMoneda>
    {
        StackTrace _stackTrace;
        StackFrame _stackFrame;
        MethodBase _currentMethodName;
        OLogError _logError;
        public List<OMoneda> ObtenerLista(string zonaMoneda)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {
                var consulta = (from cm
                              in db.CatMoneda
                                where cm.estatusLogico && (
                                (zonaMoneda == "Mexico" && (cm.codigo == "MXN"))
                                || (zonaMoneda == "Extranjero" && (cm.codigo != "MXN"))
                                || zonaMoneda == "Todo")
                                select new OMoneda
                                {
                                    MonedaID = cm.catMonedaID,
                                    DescripcionMoneda = cm.descripcion,
                                    Codigo = cm.codigo,
                                    EstatusLogico = cm.estatusLogico
                                }).ToList();

                consulta.Add(new OMoneda() { MonedaID = -1, DescripcionMoneda = Constantes.SELECTOPTION });
                return consulta.OrderBy(m => m.MonedaID).ToList();
            }
        }

        public string getMonedaById(int monedaId)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {
                var consulta = (from cm
                             in db.CatMoneda
                                where cm.catMonedaID == monedaId

                                select cm.descripcion);


                return consulta.First();
            }
        }
    }
}
