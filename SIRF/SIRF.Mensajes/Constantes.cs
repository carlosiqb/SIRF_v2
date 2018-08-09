using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Mensajes
{
    /// <summary>
    /// Clase correspondiente a las constantes del sistema.
    /// </summary>
    public class Constantes
    {
        /// <summary>
        /// Constante para el mensaje de obtener informacion.
        /// </summary>
        public const String CONINFORMACION = "Se obtuvo correctamente la información.";
        /// <summary>
        /// Constante para el mensaje de no obtener información.
        /// </summary>
        public const String SININFORMACION = "No se cuenta con información.";
        /// <summary>
        /// Constante para el mensaje de parametro vacio o nulo.
        /// </summary>
        public const String PARAMETROVACIOONULO = "El parametro o propiedad se encuentra vacío o nulo.";
        /// <summary>
        /// Constante para el mensaje de parametro errConfiguracionIP.
        /// </summary>
        public const String TitSolicitudRecursos = "REGISTRO PARA SOLICITUDES DE RECURSOS";
        /// <summary>
        /// 
        /// </summary>
        public const String ERRCONFIGURACIONIP = "Error al tratar de obtener la configuración de la IP de la PC del usuario.";
        /// <summary>
        /// Constante para el mensaje de autenticaciónCorrecta.
        /// </summary>
        public const String AUTENTICACIONCORRECTA = "La autenticación se realizó correctamente.";
        /// <summary>
        /// Constante para el mensaje de autenticaciónFallida.
        /// </summary>
        public const String AUTENTICACIONFALLIDA = "La autenticación no se realizó correctamente.";
        /// <summary>
        /// 
        /// </summary>
        public const String lblTipoSolicitud = "Tipo de solicitud :";
        /// <summary>
        /// Clave del tipo de solicitud
        /// </summary>
        public const String CVETIPOSOLICITUD = "TipoSolicitudID";
        /// <summary>
        /// Descripcion del tipo de solicitud
        /// </summary>
        public const String DESTIPOSOLICITUD = "DescripcionTipoSolicitud";
        /// <summary>
        /// Descripcion para cualquier modulo, para el rango de fechas
        /// </summary>
        public const String A = " A ";
        /// <summary>
        /// Descripcion para academia
        /// </summary>
        public const String ACADEMIA = "Academia:";
        /// <summary>
        /// Descripcion para botones de aceptacion
        /// </summary>
        public const String ACEPTADO = "Aceptado";
        /// <summary>
        /// Descripcion indicar la actividad
        /// </summary>
        public const String ACTIVIDAD = "Actividad:";
        /// <summary>
        /// Descripcion para indicar la adsquipcion
        /// </summary>
        public const String ADSCRIPCION = "Adscripción:";
        /// <summary>
        /// Descripcion para indicar la agencia aduanal
        /// </summary>
        public const String AGENCIAADUANAL = "Agencia aduanal:";
        /// <summary>
        /// Descripcion para seleccionar el analista
        /// </summary>
        public const String ANALISTA = "Seleccionar analista:";
        /// <summary>
        /// Descripcion para el año servicio
        /// </summary>
        public const String ANIOSERVICIO = "Año de servicio:";
        /// <summary>
        /// Descripcion para seleccion de acticipo
        /// </summary>
        public const String ANTICIPO = "Anticipo:";
        /// <summary>
        /// Descripcion para campo o etiqueta de apellido materno
        /// </summary>
        public const String APELLIDOMATERNO = "Apellido materno:";
        /// <summary>
        /// Descripcion para campo o etiqueta de apellido paterno
        /// </summary>
        public const String APELLIDOPATERNO = "Apellido paterno:";
        /// <summary>
        /// Descripcion para campo de area
        /// </summary>
        public const String AREA = "Area";
        /// <summary>
        /// Descripcion para aviso de reintegacion
        /// </summary>
        public const String AVISOREINTEGROCLC = "Aviso de reintegro CLC:";
        /// <summary>
        /// Descripcion para campo beneficiario
        /// </summary>
        public const String BENEFICIARIO = "Beneficiario:";
        /// <summary>
        /// Descripcion para boton de busqueda
        /// </summary>
        public const String BUSQUEDA = "Búsqueda:";
        /// <summary>
        /// Descripcion para campo cargo
        /// </summary>
        public const String CARGO = "Cargo:";
        /// <summary>
        /// Descripcion para campo clabe interbancaria
        /// </summary>
        public const String CLABEINTERBANCARIA = "CLABE interbancaria:";
        /// <summary>
        /// Descripcion para campo concepto de pago
        /// </summary>
        public const String CONCEPTOPAGO = "Concepto de pago:";
        /// <summary>
        /// Descripcion para campo contrato
        /// </summary>
        public const String CONTRATO = "Contrato:";
        /// <summary>
        /// Descripcion para indicar si se quiere o no "{copia para}"
        /// </summary>
        public const String COPIAPARA = "Copia para";
        /// <summary>
        /// Descripcion para campo email
        /// </summary>
        public const String CORREOELECTRONICO = "Correo electrónico:";
        /// <summary>
        /// Descripcion para campo cuenta bancaria
        /// </summary>
        public const String CUENTABANCARIA = "Cuenta bancaria:";
        /// <summary>
        /// Descripcion para modulo de cuotas darias
        /// </summary>
        public const String CUOTASDIARIAS = "Cuotas diarias:";
        /// <summary>
        /// Descripcion para campo destino de email
        /// </summary>
        public const String DESTINO = "Destino:";
        /// <summary>
        /// Descripcion para campo y funcion de dias completos
        /// </summary>
        public const String DIASCOMPLETOS = "Días completos:";
        /// <summary>
        /// Descripcion para campo y funcion de dias medios
        /// </summary>
        public const String DIASMEDIOS = "Días medios:";
        /// <summary>
        /// Descripcion para ejercicio contable
        /// </summary>
        public const String EJERCICIOCLC = "Ejercicio CLC(Total<br />CLC-ARCLC):";
        /// <summary>
        /// Descripcion para ejercicio fiscal
        /// </summary>
        public const String EJERCICIOFISCAL = "Ejercicio fiscal:";
        /// <summary>
        /// Descripcion para campo de quien elaboro
        /// </summary>
        public const String ELABORO = "Elaboro:";
        /// <summary>
        /// Descripcion para campo entidad federativa
        /// </summary>
        public const String ENTIDADFEDERATIVA = "Entidad federativa:";
        /// <summary>
        /// Descripcion para estatus
        /// </summary>
        public const String ESTATUS = "Estatus:";
        /// <summary>
        /// Descripcion para expediente
        /// </summary>
        public const String EXPEDIENTE = "Expediente:";
        /// <summary>
        /// Descripcion para campo fecha de pago
        /// </summary>
        public const String FECHAPAGO = "Fecha de pago:";
        /// <summary>
        /// Descripcion para campo fecha de poliza
        /// </summary>
        public const String FECHAPOLIZA = "Fecha póliza COI:";
        /// <summary>
        /// Descripcion para campo fecha de solicitud
        /// </summary>
        public const String FECHASOLICITUD = "Fecha de solicitud:";
        /// <summary>
        /// Descripcion para campo fideicomiso
        /// </summary>
        public const String FIDEICOMISO = "Acuerdo de solicitud de pago (fideicomiso):";
        /// <summary>
        /// Descripcion para campo filtro de estatus
        /// </summary>
        public const String FILTROESTATUS = "Estatus";
        /// <summary>
        /// Descripcion para campo filtro de fechas
        /// </summary>
        public const String FILTROFECHAS = "Rango de fechas";
        /// <summary>
        /// Descripcion para campo filtro de folio
        /// </summary>
        public const String FILTROFOLIO = "Folio de solicitud";
        /// <summary>
        /// Descripcion para campo filtro de modulo
        /// </summary>
        public const String FILTROMODULO = "Modulo";
        /// <summary>
        /// Descripcion para campo filtro mostrar todos
        /// </summary>
        public const String FILTROMOSTRARTODOS = "Mostrar todos";
        /// <summary>
        /// Descripcion para campo filtro de nombre
        /// </summary>
        public const String FILTRONOMBRE = "Nombre";
        /// <summary>
        /// Descripcion para campo filtro de num expediente
        /// </summary>
        public const String FILTRONUMEROEXPEDIENTE = "Número de expediente";
        /// <summary>
        /// Descripcion para campo filtro de perfil
        /// </summary>
        public const String FILTROPERFIL = "Perfil";
        /// <summary>
        /// Descripcion para campo filtro de region
        /// </summary>
        public const String FILTROREGION = "Región";
        /// <summary>
        /// Descripcion para campo filtro tipo firma
        /// </summary>
        public const String FILTROTIPOFIRMA = "Tipo Firma";
        /// <summary>
        /// Descripcion para campo filtro de tipo de solicitud
        /// </summary>
        public const String FILTROTIPOSOLICITUD = "Tipo de solicitud";
        /// <summary>
        /// Descripcion para campo filtro de unidad administrativa
        /// </summary>
        public const String FILTROUNIADMINISTRATIVA = "Unidad Administrativa";
        /// <summary>
        /// Descripcion para campo filtro de usuario
        /// </summary>
        public const String FILTROUSUARIOS = "Usuario";
        /// <summary>
        /// Descripcion para campo  firmar solicitud
        /// </summary>
        public const String FIRMARSOLICITUD = "Firmar solicitud";
        /// <summary>
        /// Descripcion para campo Firmar con firma fiel
        /// </summary>
        public const String FIRMARFIEL = "Firmar - Firma FIEL";
        /// <summary>
        /// Descripcion para campo fiscales
        /// </summary>
        public const String FISCALES = "Número de suficiencia presupuestal (Fiscales):";
        /// <summary>
        /// Descripcion para campo folio
        /// </summary>
        public const String FOLIO = "Folio de solicitud:";
        /// <summary>
        /// Descripcion para campo folio poliza
        /// </summary>
        public const String FOLIOPOLIZA = "Póliza COI:";
        /// <summary>
        /// Descripcion para campo generacion
        /// </summary>
        public const String GENERACION = "Bloque:";
        /// <summary>
        /// Descripcion para campo grado
        /// </summary>
        public const String GRADO = "Grado:";
        /// <summary>
        /// Descripcion para campo unidad administrativa
        /// </summary>
        public const String HEADER_GRID_UNIDAD_ADMINISTRATIVA = "Unidad Administrativa";
        /// <summary>
        /// Descripcion para campo homologar expediente
        /// </summary>
        public const String HOMOLOGAREXPEDIENTE = "Homologar expediente:";
        /// <summary>
        /// Descripcion para campo relacion de info
        /// </summary>
        public const String IDENTIFICADORRELACION = "Identificador relación:";
        /// <summary>
        /// Descripcion para campo importe
        /// </summary>
        public const String IMPORTE = "Importe:";
        /// <summary>
        /// Descripcion para campo importe a otorgar
        /// </summary>
        public const String IMPORTEAOTORGAR = "Importe a otorgar:";
        /// <summary>
        /// Descripcion para campo ingresos y egresos
        /// </summary>
        public const String INGRESOSEGRESOS = "Ingresos/Egresos:";
        /// <summary>
        /// Descripcion para campo inst bancaria
        /// </summary>
        public const String INSTITUCIONBANCARIA = "Institución bancaria:";
        /// <summary>
        /// Descripcion para campo integrante
        /// </summary>
        public const String INTEGRANTE = "Integrante:";
        /// <summary>
        /// Descripcion para campo ip
        /// </summary>
        public const String IP = "IP:";
        /// <summary>
        /// Descripcion para campo leyenda
        /// </summary>
        public const String LEYENDA = "Leyenda (Por Autorización)";
        /// <summary>
        /// Descripcion para campo modulo
        /// </summary>
        public const String MODULO = "Modulo:";
        /// <summary>
        /// Descripcion para campo moneda
        /// </summary>
        public const String MONEDA = "Moneda:";
        /// <summary>
        /// Descripcion para campo monto a pagar
        /// </summary>
        public const String MONTOAPAGAR = "Monto a pagar:";
        /// <summary>
        /// Descripcion para campo monto a depositar
        /// </summary>
        public const String MONTODEPOSITAR = "Monto a depositar:";
        /// <summary>
        /// Descripcion para campo monto otorgado
        /// </summary>
        public const String MONTOOTORGADO = "Monto otorgado:";
        /// <summary>
        /// Descripcion para campo monto solicitado
        /// </summary>
        public const String MONTOSOLICITADO = "Monto solicitado:";
        /// <summary>
        /// Descripcion para campo monto total solicitado
        /// </summary>
        public const String MONTOTOTALSOLICITADO = "Monto total solicitado:";
        /// <summary>
        /// Descripcion para campo motivo devolucion
        /// </summary>
        public const String MOTIVO_DEVOLUCION = "Motivo de Devolución:";
        /// <summary>
        /// Descripcion para campo motivo conciliacion
        /// </summary>
        public const String MOTIVOCONCILIACION = "Motivo de conciliación:";
        /// <summary>
        /// Descripcion para campo municipio localidad
        /// </summary>
        public const String MUNICIPIOLOCALIDAD = "Municipio o localidad:";
        /// <summary>
        /// Descripcion para campo nombre
        /// </summary>
        public const String NOMBRE = "Nombre:";
        /// <summary>
        /// Descripcion para campo nombre beneficiario
        /// </summary>
        public const String NOMBREBENEFICIARIO = "Nombre del beneficiario:";
        /// <summary>
        /// Descripcion para campo nombre operativo
        /// </summary>
        public const String NOMBREDELOPERATIVO = "Nombre del operativo:";
        /// <summary>
        /// Descripcion para campo nombre firmante
        /// </summary>
        public const String NOMBREFIRMANTE = "Nombre Firmante";
        /// <summary>
        /// Descripcion para campo numero clc
        /// </summary>
        public const String NUMEROCLC = "Número CLC:";
        /// <summary>
        /// Descripcion para numero de elentos
        /// </summary>
        public const String NUMERODEELEMENTOS = "Número de elementos:";
        /// <summary>
        /// Descripcion para campo numero de dias efectivos
        /// </summary>
        public const String NUMERODIASEFECTIVOS = "Número de días efectivos:";
        /// <summary>
        /// Descripcion para numero de expediente
        /// </summary>
        public const String NUMEROEXPEDIENTE = "Número de expediente:";
        /// <summary>
        /// Descripcion para campo numero de faltas
        /// </summary>
        public const String NUMEROFALTAS = "Número de faltas:";
        /// <summary>
        /// Descripcion para campo numero de recibo de pago
        /// </summary>
        public const String NUMERORECIBOPAGO = "Número de recibo de pago:";
        /// <summary>
        /// Descripcion para campo objetivo de la comision
        /// </summary>
        public const String OBJETIVODELACOMISION = "Objetivo de la comisión:";
        /// <summary>
        /// Descripcion para campo objeto de contrato
        /// </summary>
        public const String OBJETODECONTRATO = "Objeto de contrato:";
        /// <summary>
        /// Descripcion para campo observaciones
        /// </summary>
        public const String OBSERVACIONES = "Observaciones:";
        /// <summary>
        /// Descripcion para campo libre inversion
        /// </summary>
        public const String OFICIOLIBINVERSION = "Oficio de liberación de inversión:";
        /// <summary>
        /// Descripcion para campo oficio solicitud
        /// </summary>
        public const String OFICIOSOLICITUD = "Oficio de solicitud:";
        /// <summary>
        /// Descripcion para campo operaciones especificas
        /// </summary>
        public const String OPERACIONESESPECIFICAS = "Operaciones específicas:";
        /// <summary>
        /// Descripcion para campo opago moneda extranjera
        /// </summary>
        public const String PAGOMONEDAEXTRANJERA = "Pago en moneda extranjera:";
        /// <summary>
        /// Descripcion para campo pago en pesos
        /// </summary>
        public const String PAGOPESOS = "Pago en pesos:";
        /// <summary>
        /// Descripcion para campo pais
        /// </summary>
        public const String PAIS = "País:";
        /// <summary>
        /// Descripcion para campo partida
        /// </summary>
        public const String PARTIDA = "Partida:";
        /// <summary>
        /// Descripcion para campo penalizaciones
        /// </summary>
        public const String PENALIZACIONES = "Penalizaciones:";
        /// <summary>
        /// Descripcion para campo perfil
        /// </summary>
        public const String PERFIL = "Perfil:";
        /// <summary>
        /// Descripcion para campo periodo
        /// </summary>
        public const String PERIODO = "Periodo:";
        /// <summary>
        /// Descripcion para campo periodo comision
        /// </summary>
        public const String PERIODOCOMISION = "Periodo de comisión:";
        /// <summary>
        /// Descripcion para campo periodo pago
        /// </summary>
        public const String PERIODOPAGO = "Periodo de pago:";
        /// <summary>
        /// Descripcion para campo prioridad
        /// </summary>
        public const String PRIORIDAD = "Prioridad:";
        /// <summary>
        /// Descripcion para campo provedor
        /// </summary>
        public const String PROVEEDOR = "Proveedor:";
        /// <summary>
        /// Descripcion para campo puesto
        /// </summary>
        public const String PUESTO = "Puesto:";
        /// <summary>
        /// Descripcion para campo rechazo
        /// </summary>
        public const String RECHAZO = "Rechazado";
        /// <summary>
        /// Descripcion para campo Region
        /// </summary>
        public const String REGION = "Región:";
        /// <summary>
        /// Descripcion para campo R.F.C.
        /// </summary>
        public const String RFC = "RFC:";
        /// <summary>
        /// Descripcion para campo saldo final
        /// </summary>
        public const String SALDOFINAL = "Saldo final:";
        /// <summary>
        /// Descripcion para campo sentido autorizacion
        /// </summary>
        public const String SENTIDOAUTORIZACION = "Sentido autorización";
        /// <summary>
        /// Descripcion para campo suficiencia presupuestal
        /// </summary>
        public const String SUFICIENCIAPRESUPUESTARIA = "Suficiencia presupuestaria:";
        /// <summary>
        /// Descripcion para campo tipo de busqueda
        /// </summary>
        public const String TIPOBUSQUEDA = "Tipo de búsqueda:";
        /// <summary>
        /// Descripcion para campo tipo de cambio al pago
        /// </summary>
        public const String TIPOCAMBIOPAGO = "Tipo de cambio al pago:";
        /// <summary>
        /// Descripcion para campo tipo cambio preferencial
        /// </summary>
        public const String TIPOCAMBIOREFERENCIAL = "Tipo de cambio referencial:";
        /// <summary>
        /// Descripcion para campo tipo de cuenta bancaria
        /// </summary>
        public const String TIPOCUENTABANCARIA = "Tipo de cuenta bancaria:";
        /// <summary>
        /// Descripcion para campo tipo de contrato
        /// </summary>
        public const String TIPODECONTRATO = "Tipo de contrato:";
        /// <summary>
        /// Descripcion para campo tipo de firma
        /// </summary>
        public const String TIPOFIRMA = "Tipo Firma:";
        /// <summary>
        /// Descripcion para campo tipo de moneda
        /// </summary>
        public const String TIPOMONEDA = "Tipo de moneda:";
        /// <summary>
        /// Descripcion para campo tipo de solicitud
        /// </summary>
        public const String TIPOSOLICITUD = "Tipo de solicitud:";
        /// <summary>
        /// Descripcion para campo titular cuenta bancaria
        /// </summary>
        public const String TITULARCUENTABANCARIA = "Titular de cuenta bancaria:";
        /// <summary>
        /// Descripcion para campo Titulo
        /// </summary>
        public const String TITULO = "Titulo:";
        /// <summary>
        /// Descripcion para campo total contabilidad
        /// </summary>
        public const String TOTALCLC = "Total CLC:";
        /// <summary>
        /// Descripcion para la unidad administrativa
        /// </summary>
        public const String UNIDADADMIN = "Unidad administrativa:";
        /// <summary>
        /// Descripcion para campo de usuario
        /// </summary>
        public const String USUARIO = "Usuario:";
        /// <summary>
        /// Descripcion para campo vigencia del contrato
        /// </summary>
        public const String VIGENCIADELCONTRATO = "Vigencia del contrato:";
        /// <summary>
        /// Para los Dropdownlist, seleccione una opción...
        /// </summary>
        public const String SELECTOPTION = "Seleccione una opción...";
        /// <summary>
        /// Error para los días completos seleccionados por viáticos
        /// </summary>
        public const String ErrorRangoFechasViaticos = "No tiene disponibles la cantidad de días seleccionados";
        /// <summary>
        /// Descripción para el drop de pasajes
        /// </summary>
        public const String PASAJES = "Pasajes:";
        /// <summary>
        /// Cantidad para los pasajes
        /// </summary>
        public const String CANTIDAD = "Cantidad:";
        /// <summary>
        /// Descripcion de comprobacion con el numeral
        /// </summary>
        public const String COMPROBACIONNUMERAL = "Forma de comprobación:";
        /// <summary>
        /// Numero de tarjeta nomina o crédito
        /// </summary>
        public const String NUMEROTARJETA = "Número de tarjeta:";
        /// <summary>
        /// Numero de tarjeta nomina o crédito
        /// </summary>
        public const String COMPROBANTECUENTA = "Comprobante otra cuenta:";

    }

    /// <summary>
    /// Clase correspondiente a las constantes para los títulos que se utilizarán en el sistmea.
    /// </summary>
    public class ConstantesTitulos
    {
        /// <summary>
        /// Constante correspondiente al título de SOLICITUD.
        /// </summary>
        public const String SOLICITUD = "SOLICITUD";
        /// <summary>
        /// Constante correspondiente al título de DETALLE.
        /// </summary>
        public const String DETALLE = "DETALLE";
        /// <summary>
        /// Constante correspondiente al título de DOCUMENTOS.
        /// </summary>
        public const String DOCUMENTOS = "DOCUMENTOS";
        /// <summary>
        /// Constante correspondiente al título de CUOTADIARIAS.
        /// </summary>
        public const String CUOTASDIARIAS = "CUOTAS DIARIAS ";
    }

    /// <summary>
    /// Clase correspondiente a las constantes para los archivos.
    /// </summary>
    public class ConstantesArchivos
    {
        /// <summary>
        /// Constante para el mensaje SELECCIONETIPODOCUMENTO.
        /// </summary>
        public const String SELECCIONETIPODOCUMENTO = "Seleccione el tipo de documento...";
        /// <summary>
        /// Constate para el mensaje SELECCIONEDOCUMENTO
        /// </summary>
        public const String SELECCIONEDOCUMENTO = "Debe seleccionar el tipo de documento a cargar";
        /// <summary>
        /// Constante para el mensaje INFOEXTENSIONARCHIVO.
        /// </summary>
        public const String INFOEXTENSIONARCHIVO = "El archivo debe ser .jpg o .pdf";
        /// <summary>
        /// Constante para el mensaje DIRADJUNTOS.
        /// </summary>
        public const String DIRADJUNTOS = "../ArchivosSIRF";
        /// <summary>
        /// Constante para el mensaje DOCUMENTOGUARDADO
        /// </summary>
        public const String DOCUMENTOGUARDADO = "Se guardó satisfactoriamente el documento.";
        /// <summary>
        /// Constante para el documento DOCUMENTONOGUARDADO
        /// </summary>
        public const String DOCUMENTONOGUARDADO = "No se guardó satisfactoriamente el documento.";
        /// <summary>
        /// Constante para el mensaje DOCUMENTOELIMINADO
        /// </summary>
        public const String DOCUMENTOELIMINADO = "Se eliminó satisfactoriamente el documento.";
        /// <summary>
        /// Constante para el documento DOCUMENTONOELIMINADO
        /// </summary>
        public const String DOCUMENTONOELIMINADO = "No se eliminó satisfactoriamente el documento.";
    }

    /// <summary>
    /// Clase correspondiente a las constantes para los directorios del sistema.
    /// </summary>
    public class ConstantesDirectorios
    {
        /// <summary>
        /// Descripcion para la autentificacion correcta
        /// </summary>
        public const String DATOSINTEGRANTE = "Datos del integrante";
        /// <summary>
        /// Descripcion para la pestaña solicitud
        /// </summary>
        public const String SOLICITUD = "Solicitud";
        /// <summary>
        /// Descripcion para la pestaña Detalle
        /// </summary>
        public const String DETALLE = "Detalle";
        /// <summary>
        /// Descripcion para los documentos
        /// </summary>
        public const String DOCUMENTOS = "Documentos";
        /// <summary>
        /// Descripcion para la primera opcion de los cuadros de lista
        /// </summary>
        public const String SELECTOPTION = "Seleccione una opción...";
        /// <summary>
        /// Error para los días completos seleccionados por viáticos
        /// </summary>
        public const String ErrorRangoFechasViaticos = "No tiene disponibles la cantidad de días seleccionados-";
    }
}
