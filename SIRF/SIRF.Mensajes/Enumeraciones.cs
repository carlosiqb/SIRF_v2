namespace SIRF.Mensajes
{
    /// <summary>
    /// Enumeracion para el Tipo de búsqueda 
    /// </summary>
    public enum TipoBusquedaEnum
    {
        /// <summary>
        /// Expediente
        /// </summary>
        Expediente,
        /// <summary>
        /// Folio
        /// </summary>
        Folio,
        /// <summary>
        /// RangoFecha
        /// </summary>
        RangoFecha,
        /// <summary>
        /// Estatus
        /// </summary>
        Estatus,
        /// <summary>
        /// Usuario
        /// </summary>
        Usuario,
        /// <summary>
        /// Nombre
        /// </summary>
        Nombre,
        /// <summary>
        /// Perfil
        /// </summary>
        Perfil,
        /// <summary>
        /// ip
        /// </summary>
        ip,
        /// <summary>
        /// UsuarioID
        /// </summary>
        UsuarioID,
        /// <summary>
        /// TipoSolicitud
        /// </summary>
        TipoSolicitud,
        /// <summary>
        /// Todo
        /// </summary>
        Todo,
        /// <summary>
        /// NoAplica
        /// </summary>
        NoAplica,
        /// <summary>
        /// ListaSolicitudID
        /// </summary>
        ListaSolicitudID,
        /// <summary>
        /// Modulo
        /// </summary>
        Modulo,
        /// <summary>
        /// UnidadAdministrativa
        /// </summary>
        UnidadAdministrativa,
        /// <summary>
        /// Region
        /// </summary>
        Region,
        /// <summary>
        /// TipoFirma
        /// </summary>
        TipoFirma
    };
    /// <summary>
    /// Enumeración para el tipo de mensaje.
    /// </summary>
    public enum TipoMensajeEnum
    {
        /// <summary>
        /// Exitoso
        /// </summary>
        Exitoso, //Success
        /// <summary>
        /// Error
        /// </summary>
        Error, //Validacion
        /// <summary>
        /// Informacion
        /// </summary>
        Informacion, //Info
        /// <summary>
        /// Alerta
        /// </summary>
        Alerta //Warning
    };
    /// <summary>
    /// Enumeracion para el tipo de solicitud
    /// </summary>
    public enum TipoSolicitudEnum
    {
        /// <summary>
        /// No aplica
        /// </summary>
        NOAPLICA = -1,
        /// <summary>
        /// Agregaduría
        /// </summary>
        AGREGADURIA = 1,
        /// <summary>
        /// Becas Cadetes
        /// </summary>
        BECASCADETES = 2,
        /// <summary>
        /// Gastos Corriente
        /// </summary>
        GASTOCORRIENTE = 3,
        /// <summary>
        /// Gastos Funerarios
        /// </summary>
        GASTOSFUNERARIOS = 4,
        /// <summary>
        /// Impuestos Aduanales
        /// </summary>
        IMPUESTOADUANALES = 5,
        /// <summary>
        /// Impuestos Nómina
        /// </summary>
        IMPUESTONOMINA = 6,
        /// <summary>
        /// Laudos
        /// </summary>
        LAUDO = 7,
        /// <summary>
        /// Cuotas Diarias
        /// </summary>
        CUOTASDIARIAS = 8,
        /// <summary>
        /// Bécalos
        /// </summary>
        BECALOS = 9,
        /// <summary>
        /// Proveedores
        /// </summary>
        PROVEEDORES = 10,
        /// <summary>
        /// Viáticos
        /// </summary>
        VIATICOS = 11,
    };
	/// <summary>
    /// Enumeración para el tipo de procesos.
    /// </summary>
    public enum ProcesoEnum
    {
        /// <summary>
        /// BajaLogica
        /// </summary>
        BajaLogica,
        /// <summary>
        /// Alta
        /// </summary>
        Alta
    };
    /// <summary>
    ///  Enumeración para el tipo de modulo.
    /// </summary>
    public enum ModuloEnum
    {
        /// <summary>
        /// Enlace = 1
        /// </summary>
        Enlace = 1,
        /// <summary>
        /// VentanillaUnica = 2
        /// </summary>
        VentanillaUnica = 2,
        /// <summary>
        /// Fiscalización = 3
        /// </summary>
        Fiscalización = 3,
        /// <summary>
        /// Presupuestos = 4
        /// </summary>
        Presupuestos = 4,
        /// <summary>
        /// Bancos = 5
        /// </summary>
        Bancos = 5,
        /// <summary>
        /// Contabilidad = 6
        /// </summary>
        Contabilidad = 6,
        /// <summary>
        /// Seguridad = 7
        /// </summary>
        Seguridad = 7
    }

    /// <summary>
    /// 
    /// </summary>
    public static class CONCEPTO_GASTO
    {
        public static string OPERATIVIDAD = "OPERATIVIDAD";
        public static string ESCOLTAS = "ESCOLTAS";
    }

    public static class CONCEPTO_GASTO_ID
    {
        public static int OPERATIVIDAD = 3;
        public static int ESCOLTAS = 4;
    }

    public static class CONCEPTO_PARTIDA_ID
    {
        public static int PERSONAL_FEDERAL = 37701;
        public static int PRODUCTOS_ALIMENTICIOS = 22106;
    }

    public static class CONCEPTO_PAGO_ID
    {
        public static int TARJETA_EMPRESARIAL = 3;
        public static int TARJETA_NOMINA = 4;
    }

}
