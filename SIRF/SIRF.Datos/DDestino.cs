using SIRF.Objetos;
using SIRF.Mensajes;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Reflection;

namespace SIRF.Datos
{
    public class DDestino
    {
        StackTrace _stackTrace;
        StackFrame _stackFrame;
        MethodBase _currentMethodName;
        OLogError _logError;
        public List<ODestino> ObtenerLista(int? entidadFederativaID)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {
                //vjps 13/06/2017  21062017
                List<ODestino> consulta;
                if (entidadFederativaID != -1)
                {
                    consulta = (from cd
                             in db.CatDestino
                                where (cd.catEntidadFederativaID == entidadFederativaID)
                                select new ODestino
                                {
                                    DestinoID = cd.catDestinoID,
                                    DescripcionDestino = cd.descripcion,
                                    EstatusLogico = cd.estatusLogico,
                                    Orden = cd.orden,
                                    EntidadFederativa = new OEntidadFederativa() { EntidadFederativaID = cd.catEntidadFederativaID }
                                }).ToList();
                }
                else
                {
                    consulta = (from cd
                             in db.CatDestino
                                select new ODestino
                                {
                                    DestinoID = cd.catDestinoID,
                                    DescripcionDestino = cd.descripcion,
                                    EstatusLogico = cd.estatusLogico,
                                    Orden = cd.orden,
                                    EntidadFederativa = new OEntidadFederativa() { EntidadFederativaID = cd.catEntidadFederativaID }
                                }).ToList();
                }
                //consulta.Add(new DestinoModelo() { DestinoID = -1, DescripcionDestino = "Destino"});
                consulta = consulta.OrderBy(d => d.Orden).ToList();
                consulta.Insert(0, new ODestino() { DestinoID = -1, DescripcionDestino = Constantes.SELECTOPTION });
                return consulta;
            }
        }
        public ODestino ObtenerDestino(int? destinoID)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {

                var consulta = (from cd
                             in db.CatDestino
                                where (cd.catDestinoID == destinoID)
                                select new ODestino
                                {
                                    DestinoID = cd.catDestinoID,
                                    DescripcionDestino = cd.descripcion,
                                    EstatusLogico = cd.estatusLogico,
                                    EntidadFederativa = new OEntidadFederativa() { EntidadFederativaID = cd.catEntidadFederativaID }
                                }).FirstOrDefault();

                return consulta;
            }
        }

        public List<ODestino> ObtenerTodos()
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {
                var consulta = (from cd
                    in db.CatDestino
                    select new ODestino
                    {
                        DestinoID = cd.catDestinoID,
                        DescripcionDestino = cd.descripcion,
                        EstatusLogico = cd.estatusLogico,
                        EntidadFederativa = new OEntidadFederativa() { EntidadFederativaID = cd.catEntidadFederativaID }
                    }).ToList();
                return consulta;
            }
        }
    }
}
