using SIRF.Objetos;
using SIRF.Utilerias;
using System.Collections.Generic;
using System.Linq;

namespace SIRF.Persistencia
{
    public class DExpedienteDato : Instance<DExpedienteDato>
    {
        // vjps: 23062017
        public OExpedienteDato ObtenerDatosIntegranteEnBaja(int numeroExpediente)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {
                var consulta = (from vwe in db.vwBajaIntegrante
                                where vwe.expediente == numeroExpediente
                                select new OExpedienteDato
                                {
                                    Expediente = vwe.expediente,
                                    Nombre = vwe.nombre,
                                    EstatusIntegrante = vwe.movimiento,
                                    RFC = vwe.RFC,
                                    Cargo = vwe.cargo,
                                    Grado = vwe.grado,
                                    Adscripcion = vwe.Adscripcion

                                }).FirstOrDefault();

                return consulta;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <update>JUVA</update>
        /// <param name="numeroExpediente"></param>
        /// <returns></returns>
        public OExpedienteDato ObtenerDatosIntegrante(int numeroExpediente)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {
                var consulta = (from vwe in db.vwDatosIntegrante
                                where vwe.expediente == numeroExpediente
                                select new OExpedienteDato
                                {
                                    Expediente = vwe.expediente,
                                    Grado = vwe.grado,
                                    Cargo = vwe.cargo,
                                    Nombre = vwe.nombre,
                                    CODAdscripcion = vwe.codAdscripcion,
                                    Adscripcion = vwe.Adscripcion,
                                    CODCentroDistribucion = vwe.codCentroDistribucion,
                                    EnlaceID = vwe.enlaceID,
                                    RFC = vwe.RFC,
                                    EstatusIntegrante = vwe.descripcionEstatusIntegrante,
                                    CODEstatusIntegrante = vwe.codEstatusIntegrante
                                }).FirstOrDefault();

                return consulta;
            }
        }

        public List<OExpedienteDato> ObtenerDatosIntegrantes(List<int> expedientes)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {
                var consulta = (from vwe in db.vwDatosIntegrante
                                where expedientes.Contains(vwe.expediente)
                                select new OExpedienteDato
                                {
                                    Expediente = vwe.expediente,
                                    Grado = vwe.grado,
                                    Cargo = vwe.cargo,
                                    Nombre = vwe.nombre,
                                    CODAdscripcion = vwe.codAdscripcion,
                                    Adscripcion = vwe.Adscripcion,
                                    CODCentroDistribucion = vwe.codCentroDistribucion,
                                    EnlaceID = vwe.enlaceID,
                                    RFC = vwe.RFC,
                                    EstatusIntegrante = vwe.descripcionEstatusIntegrante,
                                    CODEstatusIntegrante = vwe.codEstatusIntegrante
                                }).ToList();

                return consulta;
            }
        }

        public List<OExpedienteDato> ObtenerDatosIntegrantesEnKardexOBaja(List<int> expedientes)
        {
            using (var db = new SIRFPROD_v2Entities())
            {
                var enKardex = (from vwe in db.vwDatosIntegrante
                                where expedientes.Contains(vwe.expediente)
                                select new OExpedienteDato
                                {
                                    Expediente = vwe.expediente,
                                    Grado = vwe.grado,
                                    Cargo = vwe.cargo,
                                    Nombre = vwe.nombre,
                                    CODAdscripcion = vwe.codAdscripcion,
                                    Adscripcion = vwe.Adscripcion,
                                    CODCentroDistribucion = vwe.codCentroDistribucion,
                                    EnlaceID = vwe.enlaceID,
                                    RFC = vwe.RFC,
                                    EstatusIntegrante = vwe.descripcionEstatusIntegrante,
                                    CODEstatusIntegrante = vwe.codEstatusIntegrante
                                }).ToList();

                var enBaja = (from vwe in db.vwBajaIntegrante
                              where expedientes.Contains(vwe.expediente)
                              select new OExpedienteDato
                              {
                                  Expediente = vwe.expediente,
                                  Grado = vwe.grado,
                                  Cargo = vwe.cargo,
                                  Nombre = vwe.nombre,
                                  Adscripcion = vwe.Adscripcion,
                                  RFC = vwe.RFC,
                                  EstatusIntegrante = vwe.movimiento,
                                  CODEstatusIntegrante = vwe.codEstatusIntegrante
                              }).ToList();


                var listaUnion = enKardex.Union(enBaja);

                return listaUnion.ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <updte>JUVA</updte>
        /// <param name="numeroExpediente"></param>
        /// <returns></returns>
        public OExpedienteCuenta ObtenerCuentaIntegrante(int numeroExpediente)
        {
            using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
            {
                var consulta = (from vwc in db.vwCuentasIntegrante
                                where vwc.expediente == numeroExpediente
                                select new OExpedienteCuenta
                                {
                                    Expediente = vwc.expediente,
                                    DescripcionCuenta = vwc.descripcionCuenta,
                                    CLABEInterbancaria = vwc.clabeInterbancaria,
                                    DescripcionBanco = vwc.descripcion,
                                    DescripcionTipoCuenta = vwc.descripcionTipoCuenta,
                                    EstatusLogico = vwc.estatusLogico,

                                }).FirstOrDefault();

                return consulta;
            }
        }
    }
}
