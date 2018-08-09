using System;
using System.Collections.Generic;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo  OSolicitud
    /// </summary>
    [Serializable]
    public class OSolicitud
    {
        /// <summary>
        /// Constructor
        /// </summary>        
        public OSolicitud()
        {
            //Registrada
            Estatus = new OEstatusSolicitud() { EstatusID = 1 };
            //Normal
            Prioridad = new OPrioridad() { PrioridadID = 1 };
            TipoSolicitud = new OTipoSolicitud();
            UnidadAdministrativa = new OUnidadAdministrativa();
            CargarDetalle = false;
            TipoSolicitudGenerica = new List<ITipoSolicitud>();
            Homologado = new OHomologado() { HomologadoID = 0, ImporteHomologado = 0, NumeroExpediente = String.Empty };
            MotivosRechazo = new List<OEstatusMovimiento>();
            Region = new ORegional();
        }

        /// <summary>
        /// Idetificador de Partida
        /// </summary>
        public string CodPartida { get; set; }
        /// <summary>
        /// Indetificador de solicitud 
        /// </summary>
        public int SolicitudID { get; set; }
        /// <summary>
        /// Listado de Indetificadores de solicitud
        /// </summary>
        public List<int> SolicitudesID { get; set; }
        /// <summary>
        /// Detalle de la solicitud
        /// </summary>
        public List<ITipoSolicitud> TipoSolicitudGenerica { get; set; }
        /// <summary>
        /// Catálogo de tipo de solicitud
        /// </summary>
        public OTipoSolicitud TipoSolicitud { get; set; }
        /// <summary>
        /// Catálogo de prioridad
        /// </summary>
        public OPrioridad Prioridad { get; set; }
        /// <summary>
        /// Catálogo de unidad administrativa
        /// </summary>
        public OUnidadAdministrativa UnidadAdministrativa { get; set; }
        /// <summary>
        /// Catálogo de estatus
        /// "Registrada"
        /// </summary>
        public OEstatusSolicitud Estatus { get; set; }
        /// <summary>
        /// Fecha de negocio
        /// </summary>
        public DateTime? FechaSolicitud { get; set; }
        /// <summary>
        /// Observaciones
        /// </summary>
        public string Observaciones { get; set; }
        /// <summary>
        /// Oficio de solicitud
        /// </summary>
        public string OficioSolicitud { get; set; }
        /// <summary>
        /// Fecha del Sistema
        /// </summary>
        public DateTime FechaControl { get; set; }
        /// <summary>
        /// Folio de solicitud 00000/YYYY
        /// </summary>
        public int Consecutivo { get; set; }
        /// <summary>
        /// Folio de solicitud 00000/YYYY
        /// </summary>
        public int Anio { get; set; }
        /// <summary>
        /// Fecha actualización
        /// </summary>
        public DateTime FechaActualizacion { get; set; }
        /// <summary>
        /// Catálogo Region
        /// </summary>
        public ORegional Region { get; set; }
        /// <summary>
        /// Documentos adjuntos a la solicitud
        /// </summary>
        public List<ODocumento> Documentos { get; set; }
        /// <summary>
        /// Monto total de la solicitud
        /// </summary>
        public decimal Monto { get; set; }
        /// <summary>
        /// Monto pendiente de pago de presupuesto
        /// </summary>
        public decimal MontoPendientePago { get; set; }
        /// <summary>
        /// Numero de folio conformado del consecutivo y el año de regitro
        /// </summary>
        public string NumeroFolio
        {
            get
            {
                return string.Format("{0}/{1}", string.Format("{0:00000}", Consecutivo), string.Format("{0:0000}", Anio));
            }
        }
        /// <summary>
        /// Verdadero en caso de requerir el detalle de la solicitud
        /// </summary>
        public bool CargarDetalle { get; set; }
        /// <summary>
        /// Filtro de negocio, por perfil de usuario
        /// </summary>
        public int PerfilID { get; set; }
        /// <summary>
        /// Homologación de viáticos
        /// </summary>
        public OHomologado Homologado { get; set; }
        /// <summary>
        /// Año - Parte del folio 
        /// </summary>
        public int AnioFolGen { get; set; }
        /// <summary>
        /// Consecutivo - parte del folio
        /// </summary>
        public int ConsecutivoFolGen { get; set; }
        /// <summary>
        /// Mes - Parte del folio
        /// </summary>
        public string MesFolGen { get; set; }
        /// <summary>
        /// Folio de agrupación
        /// </summary>
        public string FolioAgrupacionPoliza { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Rechazada { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? SolFirmaID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? EstatusLogico { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? TipoSolFirmaID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<OEstatusMovimiento> MotivosRechazo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public OEvento Evento { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string titularCuentaBan { get; set; }

        public string FolioSolicitud { get; set; }
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }
    }
}

