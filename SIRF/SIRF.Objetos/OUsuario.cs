using System;
using System.Collections.Generic;

namespace SIRF.Objetos
{
    /// <summary>
    /// Objeto de tipo OUsuario
    /// </summary>
    [Serializable]
    public class OUsuario
    {
        /// <summary>
        /// Propiedad UsuarioID
        /// </summary>
        public int UsuarioID { get; set; }
        /// <summary>
        /// Propiedad Usuario
        /// </summary>
        public string Usuario { get; set; }
        /// <summary>
        /// Propiedad Nombre
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Propiedad PrimerApellido
        /// </summary>
        public string PrimerApellido { get; set; }
        /// <summary>
        /// Propiedad SegundoApellido
        /// </summary>
        public string SegundoApellido { get; set; }
        /// <summary>
        /// Propiedad Correo
        /// </summary>
        public string Correo { get; set; }
        /// <summary>
        /// Propiedad CodUA
        /// </summary>
        public int CodUA { get; set; }
        /// <summary>
        /// Propiedad UnidadAdministrativa
        /// </summary>
        public string UnidadAdministrativa { get; set; }
        /// <summary>
        /// Propiedad PerfilID
        /// </summary>
        public int PerfilID { get; set; }
        /// <summary>
        /// Propiedad DescripcionPerfil
        /// </summary>
        public string DescripcionPerfil { get; set; }
        /// <summary>
        /// Propiedad Expediente
        /// </summary>
        public int Expediente { get; set; }
        /// <summary>
        /// Propiedad ip
        /// </summary>
        public string ip { get; set; }
        /// <summary>
        /// Propiedad EstatusLogico
        /// </summary>
        public bool EstatusLogico { get; set; }
        /// <summary>
        /// Propiedad Proceso
        /// </summary>
        public string Proceso { get; set; }
        /// <summary>
        /// Propiedad RegionID
        /// </summary>
        public int RegionID { get; set; }
        /// <summary>
        /// Propiedad codCentroDistribucion
        /// </summary>
        public List<string> codCentroDistribucion { get; set; }
        /// <summary>
        /// Propiedad AreaId
        /// </summary>
        public int AreaId { get; set; }
        /// <summary>
        /// Propiedad DescripcionArea
        /// </summary>
        public string DescripcionArea { get; set; }
        /// <summary>
        /// Propiedad rolId
        /// </summary>
        public int RolId { get; set; }
        /// <summary>
        /// Propiedad DescripcionRol
        /// </summary>
        public String DescripcionRol { get; set; }

        public string NumeroExpediente { get; set; }
    }
}
