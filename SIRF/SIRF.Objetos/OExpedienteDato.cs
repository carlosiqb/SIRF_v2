using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    [Serializable]
    public class OExpedienteDato
    {
        /// <summary>
        /// 
        /// </summary>
        public int Expediente { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Grado { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Cargo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CODAdscripcion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Adscripcion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CODCentroDistribucion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EnlaceID { get; set; }
        /// <summary>
        /// Código estatus del integrante : Author JUVA
        /// </summary>
        public int CODEstatusIntegrante { get; set; }
        /// <summary>
        /// Estatus del integrante : Author JUVA
        /// </summary>
        public string EstatusIntegrante { get; set; }
        /// <summary>
        /// RFC del empleado : Author JUVA
        /// </summary>
        public string RFC { get; set; }
    }
}
