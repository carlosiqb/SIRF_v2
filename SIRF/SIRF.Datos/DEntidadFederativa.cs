using SIRF.Objetos;
using SIRF.Utilerias;
using SIRF.Mensajes;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Reflection;

namespace SIRF.Datos
{
    public class DEntidadFederativa : Instance<DEntidadFederativa>
    {
        StackTrace _stackTrace;
        StackFrame _stackFrame;
        MethodBase _currentMethodName;
        OLogError _logError;

        public List<OEntidadFederativa> ObtenerLista(int codUA = 0)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {

                var consulta = (from ef
                             in db.CatEntidadFederativa
                                //where ef.catUnidadAdmID == (codUA == 0 ? ef.catUnidadAdmID : codUA) ---> ESTO QUE
                                select new OEntidadFederativa
                                {
                                    EntidadFederativaID = ef.catEntidadFederativaID,
                                    DescripcionEntidadFederativa = ef.descripcion.ToUpper(),
                                    EstatusLogico = ef.estatusLogico,
                                    Pais = new OPaises() { PaisID = ef.catPaisID }
                                }).ToList();

                consulta.Add(new OEntidadFederativa()
                {
                    EntidadFederativaID = -1,
                    DescripcionEntidadFederativa = Constantes.SELECTOPTION,
                    Pais = new OPaises() { PaisID = -1 }
                });
                return consulta.OrderBy(p => p.EntidadFederativaID).ToList();
            }
        }
    }
}
