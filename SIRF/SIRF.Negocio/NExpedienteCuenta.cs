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
    /// Clase de negocio correspondiente a la consulta de las cuentas por expediente.
    /// </summary>
    public class NExpedienteCuenta : Instance<NExpedienteCuenta>
    {
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
