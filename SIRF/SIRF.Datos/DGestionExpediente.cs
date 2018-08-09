using SIRF.Objetos;
using SIRF.Utilerias;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SIRF.Datos
{
    /// <summary>
    /// Clase de la capa de Datos correspondiente a DGestionExpediente
    /// </summary>
    public class DGestionExpediente : Instance<DGestionExpediente>
    {
        OLogError _logError;

        /// <summary>
        /// Método para la obtención del Centro de Distribución.
        /// </summary>
        /// <param name="numeroExpediente">Número de expediente del usuario logueado.</param>
        /// <param name="login">Parametro de tipo OLogin</param>
        /// <returns>Respuesta genérica de tipo lista de cadenas.</returns>
        public Respuesta<List<string>> ObtenerCentrosDistribucion(int numeroExpediente, OLogin login)
        {
            Respuesta<List<string>> respuesta = new Respuesta<List<string>>();
            try
            {
                var consulta = ObtenerCodCentroDistribucion(numeroExpediente);

                if (!String.IsNullOrEmpty(consulta.ToString()))
                {
                    respuesta.MensajeUsuario = Mensajes.Constantes.CONINFORMACION;
                    respuesta.TipoEstatus = Mensajes.TipoEstatus.Ok;
                    respuesta.TipoRespuesta = consulta;
                }
                else
                {
                    respuesta.MensajeUsuario = Mensajes.Constantes.SININFORMACION;
                    respuesta.TipoEstatus = Mensajes.TipoEstatus.Ok;
                }
            }
            catch (Exception ex)
            {
                _logError = new OLogError
                {
                    codigoError = ex.HResult.ToString(),
                    error = ex.Message,
                    evento = "ObtenerCentrosDistribucion",
                    formulario = "DGestionExpediente",
                    ex = ex,
                    usuarioID = login.Usuario.UsuarioID,
                    ipEquipo = login.Usuario.ip
                };



                //Revisar por que no se ve el "Guardar"  
                DGestionLogError.Instances.GuardarError(_logError, login);
            }
            return respuesta;
        }

        public List<string> ObtenerCodCentroDistribucion(Int32 numeroExpediente)
        {
            List<string> respuesta = new List<string>();
            try
            {
                using (SIRFPROD_v2Entities db = new SIRFPROD_v2Entities())
                {
                    respuesta = (from vae in db.vwAsistentesEnlace
                                 join vcd in db.vwCentrosDeDistribucion
                                 on vae.enlaceID equals vcd.enlaceID
                                 where vae.expediente == numeroExpediente
                                 select vcd.codCentroDistribucion).ToList();
                }
            }
            catch (Exception)
            {
                // ignored
            }
            return respuesta;
        }
    }
}
