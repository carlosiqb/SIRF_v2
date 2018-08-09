using SIRF.Objetos;
using SIRF.Mensajes;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Reflection;

namespace SIRF.Datos
{
    public class DMunicipioLocalidad
    {
        StackTrace _stackTrace;
        StackFrame _stackFrame;
        MethodBase _currentMethodName;
        OLogError _logError;

        public List<OMunicipioLocalidad> ObtenerLista()
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {

                var consulta = (from ml
                             in db.CatMunicipio
                                select new OMunicipioLocalidad
                                {
                                    MunicipioLocalidadID = ml.catMunicipioID,
                                    Entidad = new OEntidadFederativa() { EntidadFederativaID = ml.catEntidadFederativaID },
                                    DescripcionMunicipioLocalidad = ml.descripcion,
                                    MasEconomico = ml.masEconomico, //== false ? true : false, //MM CORRIGE masEconomico INVERTIDO //SE DEJA COMO ESTABA
                                    EstatusLogico = ml.estatusLogico
                                }).ToList();

                consulta.Add(new OMunicipioLocalidad()
                {
                    MunicipioLocalidadID = -1,
                    DescripcionMunicipioLocalidad = Constantes.SELECTOPTION,
                    Entidad = new OEntidadFederativa() { EntidadFederativaID = -1 },
                    MasEconomico = true
                });

                return consulta.OrderBy(ml => ml.MunicipioLocalidadID).ToList();
                ;
            }
        }
    }
}
