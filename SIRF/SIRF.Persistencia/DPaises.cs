using SIRF.Objetos;
using SIRF.Utilerias;
using SIRF.Mensajes;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Reflection;

namespace SIRF.Persistencia
{
    public class DPaises : Instance<DPaises>
    {
        StackTrace _stackTrace;
        StackFrame _stackFrame;
        MethodBase _currentMethodName;
        OLogError _logError;
        /// <summary>
        /// Consulta catálogo de partida
        /// </summary>
        /// <param name="soloActivos">Filtro opcional</param>
        /// <param name="zonaPais">Filtro</param>
        /// <returns></returns>
        public List<OPaises> ObtenerLista(bool soloActivos = false, string zonaPais = "Todos")
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {

                var consulta = (from cp in db.CatPais
                                where cp.estatusLogico == (soloActivos || cp.estatusLogico) && (
                                (zonaPais == "Extranjero" && (cp.catPaisID != 141)
                                || zonaPais != "Extranjero"))
                                select new OPaises
                                {
                                    PaisID = cp.catPaisID,
                                    DescripcionPais = cp.descripcion,
                                    EstatusLogico = cp.estatusLogico,
                                    TipoControl = cp.tipoControl
                                }).ToList();

                consulta.Add(new OPaises() { PaisID = -1, DescripcionPais = Constantes.SELECTOPTION, TipoControl = 1 });

                return consulta.OrderBy(p => p.PaisID).ToList();
            }
        }
    }
}
