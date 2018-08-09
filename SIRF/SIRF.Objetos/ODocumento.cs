using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo ODocumento
    /// </summary>
    [Serializable]
    public class ODocumento
    {
        public ODocumento(ODocumento Docto)
        {
            TipoDocumento = new OTipoDocumento();
            DocumentoID = Docto.DocumentoID;
            Ruta = Docto.Ruta;
            Anexo = Docto.Anexo;
            TipoDocumento.DescripcionTipoDoc = Docto.TipoDocumento.DescripcionTipoDoc;
            TipoDocumento.TipoDocumentoID = Docto.TipoDocumento.TipoDocumentoID;
        }
        /// <summary>
        /// Identificador
        /// </summary>
        public int DocumentoID { get; set; }
        /// <summary>
        /// Catálogo tipo de documento
        /// </summary>
        public OTipoDocumento TipoDocumento { get; set; }
        /// <summary>
        /// Descripción del tipo de documento
        /// </summary>
        public string DescripcionDocumento { get; set; }
        /// <summary>
        /// Nombre del archivo
        /// </summary>
        public string Anexo { get; set; }
        /// <summary>
        /// Directorio del servidor
        /// </summary>
        public string Ruta { get; set; }
        /// <summary>
        /// Equipo del usuario
        /// </summary>
        public string Equipo { get; set; }
        /// <summary>
        /// Fecha de carga de documento
        /// </summary>
        public DateTime? FechaRecepcion { get; set; }
        /// <summary>
        /// Saber si el boton eliminar es de modo edicion o no
        /// </summary>
        public bool Edicion { get; set; }
        /// <summary>
        /// Solicitud
        /// </summary>
        public OSolicitud Solicitud { get; set; }
        /// <summary>
        /// Extensión del archivo
        /// </summary>
        public string Extension { get; set;}
        /// <summary>
        /// Documento
        /// </summary>
        public byte[] DocumentoBase64 { get; set; }
        /// <summary>
        /// Constructor del objeto de tipo ODocumento.
        /// </summary>
        public ODocumento()
        {
            TipoDocumento = new OTipoDocumento();
            Solicitud = new OSolicitud();
        }

    }
}
