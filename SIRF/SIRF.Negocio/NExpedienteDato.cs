using SIRF.Utilerias;
using SIRF.Objetos;
using SIRF.Persistencia;
using System;
using System.Collections.Generic;
using SIRF.Mensajes;
using System.Diagnostics;
using System.Reflection;

namespace SIRF.Negocio
{
    /// <summary>
    /// Clase de negocio correspondiente al numero de expediente.
    /// </summary>
    public class NExpedienteDato : Instance<NExpedienteDato>
    {
        public OExpedienteDato ObtenerDatosIntegranteEnBaja(int numeroExpediente)
        {
            DExpedienteDato expedienteDatos = new DExpedienteDato();
            return expedienteDatos.ObtenerDatosIntegranteEnBaja(numeroExpediente);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <update>JUVA</update>
        /// <param name="numeroExpediente"></param>
        /// <returns></returns>
        public OExpedienteDato ObtenerDatosIntegrante(int numeroExpediente)
        {
            DExpedienteDato expedienteDatos = new DExpedienteDato();
            return expedienteDatos.ObtenerDatosIntegrante(numeroExpediente);
        }

        public List<OExpedienteDato> ObtenerDatosIntegrantes(List<int> expedientes)
        {
            DExpedienteDato expedienteDatos = new DExpedienteDato();
            return expedienteDatos.ObtenerDatosIntegrantes(expedientes);
        }

        public List<OExpedienteDato> ObtenerDatosIntegrantesEnKardexOBaja(List<int> expedientes)
        {
            DExpedienteDato expedienteDatos = new DExpedienteDato();
            return expedienteDatos.ObtenerDatosIntegrantesEnKardexOBaja(expedientes);
        }

        /// <summary>
        /// Obtiene las cuentas bancarias del integrate : Author JUVA
        /// </summary>
        /// <param name="numeroExpediente">Numero de expediente</param>
        /// <returns>Cuentas</returns>
        public List<OExpedienteCuenta> ObtenerCuentasIntegrante(int numeroExpediente)
        {
            DExpedienteCuenta expedienteDatos = new DExpedienteCuenta();
            return expedienteDatos.ObtenerCuentasIntegrante(numeroExpediente);
        }

    }
}
