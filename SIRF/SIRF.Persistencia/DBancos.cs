using SIRF.Objetos;
using SIRF.Utilerias;
using SIRF.Mensajes;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Reflection;

namespace SIRF.Persistencia
{
    public class DBancos : Instance<DBancos>
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
        public List<OBancos> ObtenerLista(bool soloActivos = false)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {

                var consulta = (from cb in db.CatBanco
                                where cb.estatusLogico == (soloActivos || cb.estatusLogico)
                                select new OBancos
                                {
                                    bancoID = cb.catBancoID,
                                    cveBanco = cb.cveBanco,
                                    descripcionBanco = cb.descripcion,
                                }).ToList();

                consulta.Add(new OBancos() { bancoID = -1, descripcionBanco = Constantes.SELECTOPTION});

                return consulta.OrderBy(p => p.bancoID).ToList();
            }
        }

        public int ObtenerBanco(string claveBanco)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {

                return (from cb in db.CatBanco
                    where cb.cveBanco == claveBanco
                    select cb.catBancoID).FirstOrDefault();
            }
        }
    }
}
