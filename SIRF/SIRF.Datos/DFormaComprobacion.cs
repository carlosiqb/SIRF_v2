using SIRF.Objetos;
using SIRF.Utilerias;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Reflection;

namespace SIRF.Datos
{
    public class DFormaComprobacion : Instance<DFormaComprobacion>
    {
        StackTrace _stackTrace;
        StackFrame _stackFrame;
        MethodBase _currentMethodName;
        OLogError _logError;
        /// <summary>
        /// Consulta catálogo de bancos
        /// </summary>
        /// <param name="soloActivos">Filtro opcional</param>
        /// <returns></returns>
        public List<OFormaComprobacion> ObtenerLista(bool soloActivos = false)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {

                var consulta = (from fc in db.CatFormaComprobacion
                                where fc.estatusLogico == (soloActivos || fc.estatusLogico)
                                select new OFormaComprobacion
                                {
                                    idFormaComprobacion = fc.catFormaComprobacionID,
                                    FormaComprobacion = fc.FormaComprobacion,
                                    estatusLogico = fc.estatusLogico
                                }).ToList();


                consulta.Add(new OFormaComprobacion() { idFormaComprobacion = -1, FormaComprobacion = "Seleccione el tipo de pago..." });
                return consulta.OrderBy(p => p.idFormaComprobacion).ToList();
            }
        }
    }
}
