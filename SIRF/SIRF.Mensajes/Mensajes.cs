using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRF.Mensajes
{
    /// <summary>
    /// Clase correspondiente a las constantes del sistema para todos los mensajes.
    /// </summary>
    public class Mensajes
    {
        /// <summary>
        /// Constante para el mensaje de obtener informacion.
        /// </summary>
        public const String MsgTipoSolicitud = "Seleccione el tipo de solicitud que desea capturar.";
        /// <summary>
        /// Constantes para el mensaje advAnioServicio
        /// </summary>
        public const String advAnioServicio = "El campo año de servicio tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advBeneficiario
        /// </summary>
        public const String advBeneficiario = "El campo beneficiario tiene un formato de incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advCambioReferencial
        /// </summary>
        public const String advCambioReferencial = "El campo cambio referencial tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advCorreoElectronico
        /// </summary>
        public const String advCorreoElectronico = "El campo correo electrónico tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advDestino
        /// </summary>
        public const String advDestino = "El campo destino tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advEjercicioCLC
        /// </summary>
        public const String advEjercicioCLC = "El campo ejercicio clc tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advEjercicioFiscal
        /// </summary>
        public const String advEjercicioFiscal = "El campo ejercicio fiscal tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advIP
        /// </summary>
        public const String advIP = "El campo IP tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advLongitudIdentificador
        /// </summary>
        public const String advLongitudIdentificador = "El folio identificador debe estar formado por el consecutivo a tres cifras, las primeras tres letras del mes y el año a cuatro cifras.";
        /// <summary>
        /// Constantes para el mensaje advMontoADepositar
        /// </summary>
        public const String advMontoADepositar = "El campo Monto a depositar debe de ser mayor a 0.";
        /// <summary>
        /// Constantes para el mensaje advMontoOtorgado
        /// </summary>
        public const String advMontoOtorgado = "El monto otorgado no puede ser menor a 0.";
        /// <summary>
        /// Constantes para el mensaje advMontoPagar
        /// </summary>
        public const String advMontoPagar = "Importe mal capturado, por favor revise.";
        /// <summary>
        /// Constantes para el mensaje advMontoSolicitado
        /// </summary>
        public const String advMontoSolicitado = "Formato de monto solicitado incorrecto";
        /// <summary>
        /// Constantes para el mensaje advMunicipio
        /// </summary>
        public const String advMunicipio = "El campo municipio tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advNoHayIdentificacion
        /// </summary>
        public const String advNoHayIdentificacion = "No hay una relación con el folio indicado.";
        /// <summary>
        /// Constantes para el mensaje advNombre
        /// </summary>
        public const String advNombre = "El campo nombre tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advNumeroClc
        /// </summary>
        public const String advNumeroClc = "El campo número clc tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advNumeroDeDiasEfectivos
        /// </summary>
        public const String advNumeroDeDiasEfectivos = "El campo seleccionado no es válido.";
        /// <summary>
        /// Constantes para el mensaje advNumeroExpediente
        /// </summary>
        public const String advNumeroExpediente = "Número de expediente tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advNumeroReciboPago
        /// </summary>
        public const String advNumeroReciboPago = "Numero recibo de pago tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advPagoConPoliza
        /// </summary>
        public const String advPagoConPoliza = "El pago ya tiene una póliza asociada.";
        /// <summary>
        /// Constantes para el mensaje advPagoMonedaExtranjera
        /// </summary>
        public const String advPagoMonedaExtranjera = "El campo pago en moneda extranjera tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advPagoPesos
        /// </summary>
        public const String advPagoPesos = "El campo pago en pesos tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advPais
        /// </summary>
        public const String advPais = "El campo país tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advPrimerApellido
        /// </summary>
        public const String advPrimerApellido = "El campo apellido paterno tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advRangoFechasViatico
        /// </summary>
        public const String advRangoFechasViatico = "No tiene disponibles la cantidad de días seleccionados.";
        /// <summary>
        /// Constantes para el mensaje advRegistroPoliza
        /// </summary>
        public const String advRegistroPoliza = "El pago ya tiene asociada una póliza.";
        /// <summary>
        /// Constantes para el mensaje advSaldoFinal
        /// </summary>
        public const String advSaldoFinal = "El campo saldo final tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advSegundoApellido
        /// </summary>
        public const String advSegundoApellido = "El campo apellido materno tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advSuficienciaPresupuestaria
        /// </summary>
        public const String advSuficienciaPresupuestaria = "El campo suficiencia presupuestaria tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advTipoCambioPago
        /// </summary>
        public const String advTipoCambioPago = "El campo tipo de cambio al pago tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advTotalCLC
        /// </summary>
        public const String advTotalCLC = "El campo total clc tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje advUsuario
        /// </summary>
        public const String advUsuario = "El campo usuario tiene un formato incorrecto.";
        /// <summary>
        /// Constantes para el mensaje errAcademia
        /// </summary>
        public const String errAcademia = "El campo Academia es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errActividad
        /// </summary>
        public const String errActividad = "El campo actividad es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errAgenciaAduanal
        /// </summary>
        public const String errAgenciaAduanal = "Debe de ingresar una agencia aduanal.";
        /// <summary>
        /// Constantes para el mensaje errAltaUsuario
        /// </summary>
        public const String errAltaUsuario = "Ocurrió un error al intentar dar de alta al usuario.";
        /// <summary>
        /// Constantes para el mensaje errAltaUsuarioLlave
        /// </summary>
        public const String errAltaUsuarioLlave = "Es necesario capturar los datos del usuario antes de intentar guardar.";
        /// <summary>
        /// Constantes para el mensaje errAnioServicio
        /// </summary>
        public const String errAnioServicio = "El campo año de servicio es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errArchivadoRelacion
        /// </summary>
        public const String errArchivadoRelacion = "Ocurrió un error en el archivado de la relación de pólizas.";
        /// <summary>
        /// Constantes para el mensaje errAsociarPolizaPagos
        /// </summary>
        public const String errAsociarPolizaPagos = "No se pudo generar la relación de solicitudes.";
        /// <summary>
        /// Constantes para el mensaje errAumentoSaldo
        /// </summary>
        public const String errAumentoSaldo = "Ocurrió un error al tratar de aumentar el saldo, por favor intente nuevamente.";
        /// <summary>
        /// Constantes para el mensaje errAutorizacionComprobante
        /// </summary>
        public const String errAutorizacionComprobante = "Se ha producido un error al autorizar el comprobante";
        /// <summary>
        /// Constantes para el mensaje errAutorizacionLayoutPago
        /// </summary>
        public const String errAutorizacionLayoutPago = "Se ha producido un error al autorizar el Layout de pago";
        /// <summary>
        /// Constantes para el mensaje errAvisoReintegro
        /// </summary>
        public const String errAvisoReintegro = "El campo aviso reintegro es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errBajaIP
        /// </summary>
        public const String errBajaIP = "Ocurrió un error al intentar dar de baja la IP del usuario.";
        /// <summary>
        /// Constantes para el mensaje errBanderaActualizaUsuarioIP
        /// </summary>
        public const String errBanderaActualizaUsuarioIP = "Ocurrió un error al intentar realizar la asignación de la IP actual, por favor verifique y reintente.";
        /// <summary>
        /// Constantes para el mensaje errBanderaAltaIP
        /// </summary>
        public const String errBanderaAltaIP = "Ocurrió un error al intentar dar de alta la IP al usuario.";
        /// <summary>
        /// Constantes para el mensaje errBanderaAltaUsuario
        /// </summary>
        public const String errBanderaAltaUsuario = "Ocurrió un error al intentar guardar el alta de los datos del Nuevo Usuario.";
        /// <summary>
        /// Constantes para el mensaje errBanderaDesactivarIPs
        /// </summary>
        public const String errBanderaDesactivarIPs = "Ocurrió un error al intentar desactivar las IPs del usuario que intenta dar de baja, por favor verifique y vuelva a intentar el proceso de baja.";
        /// <summary>
        /// Constantes para el mensaje errBanderaEditaUsuario
        /// </summary>
        public const String errBanderaEditaUsuario = "Ocurrió un error al intentar guardar la modificación de los datos del usuario.";
        /// <summary>
        /// Constantes para el mensaje errBeneficiario
        /// </summary>
        public const String errBeneficiario = "El campo Beneficiarios es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errBeneficiarios
        /// </summary>
        public const String errBeneficiarios = "Debe capturar al menos un beneficiario.";
        /// <summary>
        /// Constantes para el mensaje errCambioReferencial
        /// </summary>
        public const String errCambioReferencial = "El campo cambio referencial es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errCantRegViaticos
        /// </summary> 
        public const String errCantRegViaticos = "Debe de cargar por lo menos 10 registros.";
        /// <summary>
        /// Constantes para el mensaje errCapturaDatosPoliza
        /// </summary>
        public const String errCapturaDatosPoliza = "Ocurrió un error al capturar la información de la póliza.";
        /// <summary>
        /// Constantes para el mensaje errCargarDatosPagos
        /// </summary>
        public const String errCargarDatosPagos = "Ocurrió un error en la carga de los pagos asociados a la solicitud.";
        /// <summary>
        /// Constantes para el mensaje errChequeInfo
        /// </summary>
        public const String errChequeInfo = "Error al guardar cheque";
        /// <summary>
        /// Constantes para el mensaje errClabe
        /// </summary>
        public const String errClabe = "El campo CLABE debe ser de 18 dígitos";
        /// <summary>
        /// Constantes para el mensaje errClabeInterbancaria
        /// </summary>
        public const String errClabeInterbancaria = "El campo CLABE interbancaria es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errCodCDExpediente
        /// </summary>
        public const String errCodCDExpediente = "El número de expediente no corresponde a su unidad administrativa.  Línea:";
        /// <summary>
        /// Constantes para el mensaje errCodDestino
        /// </summary>
        public const String errCodDestino = "No existe un registro de destino con la descripción de la linea";
        /// <summary>
        /// Constantes para el mensaje errCodEntidad
        /// </summary>
        public const String errCodEntidad = "No existe un registro de entidad con la descripción de la linea";
        /// <summary>
        /// Constantes para el mensaje errCodExpediente
        /// </summary>
        public const String errCodExpediente = "No existe un registro del número de expediente de la linea";
        /// <summary>
        /// Constantes para el mensaje errCodMoneda
        /// </summary>
        public const String errCodMoneda = "No existe un registro de moneda con la descripción de la linea ";
        /// <summary>
        /// Constantes para el mensaje errCodMunicipio
        /// </summary>
        public const String errCodMunicipio = "No existe un registro de municipio con la descripción  de la linea";
        /// <summary>
        /// Constantes para el mensaje errCodNoActivoExpediente
        /// </summary>
        public const String errCodNoActivoExpediente = "El expediente no esta ACTIVO de la linea";
        /// <summary>
        /// Constantes para el mensaje errCodPais
        /// </summary>
        public const String errCodPais = "No existe un registro de país con la descripción  de la linea";
        /// <summary>
        /// Constantes para el mensaje errCodPartida
        /// </summary>
        public const String errCodPartida = "No existe un registro de partida PRESUPUESTAL de la linea";
        /// <summary>
        /// Constantes para el mensaje errCodTipoCuota
        /// </summary>
        public const String errCodTipoCuota = "No existe un registro de tipo de cuota con la descripción de la linea";
        /// <summary>
        /// Constantes para el mensaje errComprobantePago
        /// </summary>
        public const String errComprobantePago = "No se adjuntó ningún documento";
        /// <summary>
        /// Constantes para el mensaje errConceptoPago
        /// </summary>
        public const String errConceptoPago = "Debe de ingresar un concepto de pago.";
        /// <summary>
        /// Constantes para el mensaje errConfiguracionIP
        /// </summary>
        public const String errConfiguracionIP = "Error al tratar de obtener la configuración de la IP de la PC del usuario";
        /// <summary>
        /// Constantes para el mensaje errContrato
        /// </summary>
        public const String errContrato = "El campo contrato es obligatorio";
        /// <summary>
        /// Constantes para el mensaje errCorreoElectronico
        /// </summary>
        public const String errCorreoElectronico = "El campo correo electrónico es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errCuentaBancaria
        /// </summary>
        public const String errCuentaBancaria = "El campo Cuenta bancaria es obligatorio ingresarlo.";
        /// <summary>
        /// Constantes para el mensaje errCuentaBancariaLongitud
        /// </summary>
        public const String errCuentaBancariaLongitud = "La longitud de la cuenta debe ser entre 8 y 11 posiciones";
        /// <summary>
        /// Constantes para el mensaje errCuentaNoEncontrada
        /// </summary>
        public const String errCuentaNoEncontrada = "No se encontró la cuenta";
        /// <summary>
        /// Constantes para el mensaje errCuotaDiarias
        /// </summary>
        public const String errCuotaDiarias = "Debe capturar cuotas diarias";
        /// <summary>
        /// Constantes para el mensaje errCuotasDiarias
        /// </summary>
        public const String errCuotasDiarias = "Seleccione un tipo.";
        /// <summary>
        /// Constantes para el mensaje errDestino
        /// </summary>
        public const String errDestino = "El campo destino es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errDocumentos
        /// </summary 
        public const String errDocumentos = "Es necesario cargar al menos un documento.";
        /// <summary>
        /// Constantes para el mensaje errEditarUsuario
        /// </summary>
        public const String errEditarUsuario = "Ocurrió un error al intentar actualizar la información del usuario.";
        /// <summary>
        /// Constantes para el mensaje errEjercicioCLC
        /// </summary>
        public const String errEjercicioCLC = "El campo ejercicio clc es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errEjercicioFiscal
        /// </summary>
        public const String errEjercicioFiscal = "El campo ejercicio fiscal es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errEntidadFederativa
        /// </summary>
        public const String errEntidadFederativa = "El campo entidad federativa es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errEstatusActualizado
        /// </summary>
        public const String errEstatusActualizado = "Se ha producido un error al actualizar la solicitud";
        /// <summary>
        /// Constantes para el mensaje errEstatusPago
        /// </summary>
        public const String errEstatusPago = "Debe seleccionar un estatus de pago";
        /// <summary>
        /// Constantes para el mensaje errExcepcionAltaCLC
        /// </summary>
        public const String errExcepcionAltaCLC = "Ocurrió un error de validación al tratar de dar de alta el CLC.";
        /// <summary>
        /// Constantes para el mensaje errExcepcionAltaUsuario
        /// </summary>
        public const String errExcepcionAltaUsuario = "Ocurrió una excepción al tratar de dar de alta el usuario, por favor actualice la página y reintente.";
        /// <summary>
        /// Constantes para el mensaje errExcepcionBajaIP
        /// </summary>
        public const String errExcepcionBajaIP = "Ocurrió una excepción al tratar de dar de baja la IP del usuario, por favor actualice la página y reintente.";
        /// <summary>
        /// Constantes para el mensaje errExcepcionEditarCLC
        /// </summary>
        public const String errExcepcionEditarCLC = "Ocurrió un error de validación al tratar de editar la información del CLC.";
        /// <summary>
        /// Constantes para el mensaje errExcepcionEditarUsuario
        /// </summary>
        public const String errExcepcionEditarUsuario = "Ocurrió una excepción al tratar de actualizar el usuario, por favor actualice la página y reintente.";
        /// <summary>
        /// Constantes para el mensaje errExistNumeroExpediente
        /// </summary>
        public const String errExistNumeroExpediente = "El número de expediente capturado no se encuentra";
        /// <summary>
        /// Constantes para el mensaje errFechaPago
        /// </summary>
        public const String errFechaPago = "El campo fecha pago es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errFolioGeneracionIncorrecto
        /// </summary>
        public const String errFolioGeneracionIncorrecto = "El folio de la generación no corresponde con el folio siguiente en la base de datos";
        /// <summary>
        /// Constantes para el mensaje errFormatoRFC
        /// </summary>
        public const String errFormatoRFC = "Verificar formato del RFC";
        /// <summary>
        /// Constantes para el mensaje errGeneracion
        /// </summary>
        public const String errGeneracion = "El campo generación es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errIdentificadorRelacion
        /// </summary>
        public const String errIdentificadorRelacion = "El campo Identificador Relación es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errInstituciónBancaria
        /// </summary>
        public const String errInstituciónBancaria = "El campo Institución bancaria es obligatorio ingresarlo.";
        /// <summary>
        /// Constantes para el mensaje errIPNoEstaAsignada
        /// </summary>
        public const String errIPNoEstaAsignada = "La IP de la computadora desde donde intenta ingresar al SIRF no tiene permiso de acceso al sistema para su usuario.";
        /// <summary>
        /// Constantes para el mensaje errIPOcupada
        /// </summary>
        public const String errIPOcupada = "La IP proporcionada ya la tiene asignada otro usuario, por favor verifique y reintente guardar.";
        /// <summary>
        /// Constantes para el mensaje errlistaPartidasObligatorias
        /// </summary>
        public const String errlistaPartidasObligatorias = "No se ha cargado la lista de Partidas Obligatorias";
        /// <summary>
        /// Constantes para el mensaje errLogin
        /// </summary>
        public const String errLogin = "El usuario o la contraseña con los que intenta ingresar son incorrectos.";
        /// <summary>
        /// Constantes para el mensaje errMoneda
        /// </summary>
        public const String errMoneda = "Debe de seleccionar un tipo de moneda.";
        /// <summary>
        /// Constantes para el mensaje errMontoADepositar
        /// </summary>
        public const String errMontoADepositar = "El campo Monto a depositar es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errMontoOtorgado
        /// </summary>
        public const String errMontoOtorgado = "El campo Monto otorgado es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errMontoPagar
        /// </summary>
        public const String errMontoPagar = "El campo monto a pagar es obligatorio ingresarlo.";
        /// <summary>
        /// Constantes para el mensaje errMontoSolicitado
        /// </summary>
        public const String errMontoSolicitado = "El campo monto solicitado es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errNoDatosCargaMasiva
        /// </summary>
        public const String errNoDatosCargaMasiva = "No se puede guardar la solicitud: Quedaría sin registros";
        /// <summary>
        /// Constantes para el mensaje errNombre
        /// </summary>
        public const String errNombre = "El campo nombre es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errNombreBeneficiario
        /// </summary>
        public const String errNombreBeneficiario = "El campo nombre beneficiario es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errNombreOperativo
        /// </summary>
        public const String errNombreOperativo = "El campo nombre operativo es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errNoTieneLaudos
        /// </summary>
        public const String errNoTieneLaudos = "No hay laudos capturados";
        /// <summary>
        /// Constantes para el mensaje errNumeroClc
        /// </summary>
        public const String errNumeroClc = "El campo número clc es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errNumeroDeDiasEfectivos
        /// </summary>
        public const String errNumeroDeDiasEfectivos = "El campo número de días efectivos es obligatorio ingresarlo.";
        /// <summary>
        /// Constantes para el mensaje errNumeroExpediente
        /// </summary>
        public const String errNumeroExpediente = "El campo número expediente es obligatorio ingresarlo.";
        /// <summary>
        /// Constantes para el mensaje errNumeroFaltas
        /// </summary>
        public const String errNumeroFaltas = "El campo número de faltas obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errNumeroReciboPago
        /// </summary>
        public const String errNumeroReciboPago = "El campo Número recibo de pago es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errObjetivoComision
        /// </summary>
        public const String errObjetivoComision = "El campo objetivo comisión es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errObservaciones
        /// </summary>
        public const String errObservaciones = "El campo observaciones es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errOficioSolicitud
        /// </summary>
        public const String errOficioSolicitud = "El campo oficio de solicitud es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje ERRORINSERT
        /// </summary>
        public const String ERRORINSERT = "Error al guardar información en {0}";
        /// <summary>
        /// Constantes para el mensaje ERRORINSERT1
        /// </summary>
        public const String ERRORINSERT1 = "Error al guardar información en {0}";
        /// <summary>
        /// Constantes para el mensaje errPagoCheque
        /// </summary>
        public const String errPagoCheque = "La(s) solicitud(es) {0} no pueden ser pagada(s) por cheques";
        /// <summary>
        /// Constantes para el mensaje errPagoChequeValidacion
        /// </summary>
        public const String errPagoChequeValidacion = "El campo número de cheque es obligatorio";
        /// <summary>
        /// Constantes para el mensaje errPagoMonedaExtranjera
        /// </summary>
        public const String errPagoMonedaExtranjera = "El campo pago en moneda extranjera es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errPagoPesos
        /// </summary>
        public const String errPagoPesos = "El campo pago en pesos es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errPais
        /// </summary>
        public const String errPais = "Debe de seleccionar un país.";
        /// <summary>
        /// Constantes para el mensaje errPartida
        /// </summary>
        public const String errPartida = "El campo partida es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errPerfil
        /// </summary>
        public const String errPerfil = "El campo perfil es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errPeriodo
        /// </summary>
        public const String errPeriodo = "Por favor revise que haya ingresado una fecha de inicio y una de fin.";
        /// <summary>
        /// Constantes para el mensaje errPeriodoSolicitud
        /// </summary>
        public const String errPeriodoSolicitud = "El rango de fechas es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errPlantillaNoValida
        /// </summary>
        public const String errPlantillaNoValida = "Plantilla no válida";
        /// <summary>
        /// Constantes para el mensaje errPolizaRepetida
        /// </summary>
        public const String errPolizaRepetida = "El número de poliza ya ha sido utilizado";
        /// <summary>
        /// Constantes para el mensaje errPrimerApellido
        /// </summary>
        public const String errPrimerApellido = "El campo apellido paterno es obligatorio";
        /// <summary>
        /// Constantes para el mensaje errProveedor
        /// </summary>
        public const String errProveedor = "El campo proveedor es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errRangoFechasTraslapa
        /// </summary>
        public const String errRangoFechasTraslapa = "El rango de fechas se traslapa";
        /// <summary>
        /// Constantes para el mensaje errRegistroPoliza
        /// </summary>
        public const String errRegistroPoliza = "No se ha podido guardar correctamente la asociación.";
        /// <summary>
        /// Constantes para el mensaje errRelacionPoliza
        /// </summary>
        public const String errRelacionPoliza = "La relación de póliza no se ha podido generar correctamente.";
        /// <summary>
        /// Constantes para el mensaje errRFC
        /// </summary>
        public const String errRFC = "El campo RFC es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errSaldoFinal
        /// </summary>
        public const String errSaldoFinal = "El campo saldo final es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errSegundoApellido
        /// </summary>
        public const String errSegundoApellido = "El campo apellido materno es obligatorio";
        /// <summary>
        /// Constantes para el mensaje errSeleccioneUnRegistroDelGrid
        /// </summary>
        public const String errSeleccioneUnRegistroDelGrid = "Debe seleccionar al menos un registro para su asignación";
        /// <summary>
        /// Constantes para el mensaje errSeleccioneUnRegistroDelGridSolicitudes
        /// </summary>
        public const String errSeleccioneUnRegistroDelGridSolicitudes = "Debe seleccionar al menos un registro para la asignación de una solicitud a una cuenta";
        /// <summary>
        /// Constantes para el mensaje errSesionCaducadaFirma
        /// </summary>
        public const String errSesionCaducadaFirma = "La sesión ha caducado vuelva a ingresar al sistema para firmar";
        /// <summary>
        /// Constantes para el mensaje errSuficienciaPresupuestaria
        /// </summary>
        public const String errSuficienciaPresupuestaria = "El campo suficiencia presupuestaria es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errTipoCambioPago
        /// </summary>
        public const String errTipoCambioPago = "El campo tipo de cambio al pago es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errTipoCuentaNoValido
        /// </summary>
        public const String errTipoCuentaNoValido = "El tipo de cuenta no corresponde al registrado";
        /// <summary>
        /// Constantes para el mensaje errTipoSolicitud
        /// </summary>
        public const String errTipoSolicitud = "Debe de seleccionar un tipo de solicitud.";
        /// <summary>
        /// Constantes para el mensaje errTitularCuentaBancaria
        /// </summary>
        public const String errTitularCuentaBancaria = "El campo Titular de Cuenta bancaria es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errTotalCLC
        /// </summary>
        public const String errTotalCLC = "El campo total clc es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errTransferencias
        /// </summary>
        public const String errTransferencias = "Error al guardar datos";
        /// <summary>
        /// Constantes para el mensaje errUnidadAdministrativa
        /// </summary>
        public const String errUnidadAdministrativa = "El campo unidad administrativa es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errUsuario
        /// </summary>
        public const String errUsuario = "El campo usuario es obligatorio.";
        /// <summary>
        /// Constantes para el mensaje errUsuarioActualizarNoExiste
        /// </summary>
        public const String errUsuarioActualizarNoExiste = "El usuario que intenta actualizar no existe, por favor verifique.";
        /// <summary>
        /// Constantes para el mensaje errUsuarioInactivo
        /// </summary>
        public const String errUsuarioInactivo = "El usuario no está activo en SIRF, valide con su administrador.";
        /// <summary>
        /// Constantes para el mensaje errUsuarioNoExiste
        /// </summary>
        public const String errUsuarioNoExiste = "El usuario no existe en la base de datos del SIRF";
        /// <summary>
        /// Constantes para el mensaje errUsuarioSinIPAsignadas
        /// </summary>
        public const String errUsuarioSinIPAsignadas = "Su nombre de usuario no tiene IPs asignadas en el SIRF, valide con su administrador.";
        /// <summary>
        /// Constantes para el mensaje errValidacionAltaUsuario
        /// </summary>
        public const String errValidacionAltaUsuario = "Ocurrió un error de validación al tratar de dar de alta al usuario.";
        /// <summary>
        /// Constantes para el mensaje errValidacionEditarUsuario
        /// </summary>
        public const String errValidacionEditarUsuario = "Ocurrió un error de validación al tratar de editar la información del usuario.";
        /// <summary>
        /// Constantes para el mensaje errValidacionPoliza
        /// </summary>
        public const String errValidacionPoliza = "No se pudo generar la relación de solicitudes.";
        /// <summary>
        /// Constantes para el mensaje errViaticos
        /// </summary>
        public const String errViaticos = "Debe capturar viáticos";
        /// <summary>
        /// Constantes para el mensaje exiActualizacionUsuarioCorrecta
        /// </summary>
        public const String exiActualizacionUsuarioCorrecta = "La actualización ha sido exitosa.";
        /// <summary>
        /// Constantes para el mensaje exiAltaUsuarioCorrecta
        /// </summary>
        public const String exiAltaUsuarioCorrecta = "El usuario ha sido dado de alta de manera correcta.";
        /// <summary>
        /// Constantes para el mensaje exiArchivadoRelacion
        /// </summary>
        public const String exiArchivadoRelacion = "Las solicitudes relacionadas han concluido su proceso.";
        /// <summary>
        /// Constantes para el mensaje exiAutorizacionComprobante
        /// </summary>
        public const String exiAutorizacionComprobante = "Se autorizó correctamente el comprobante de pago";
        /// <summary>
        /// Constantes para el mensaje exiAutorizacionLayoutPago
        /// </summary>
        public const String exiAutorizacionLayoutPago = "Autorización de Layout de pago correcta";
        /// <summary>
        /// Constantes para el mensaje exiBajaIP
        /// </summary>
        public const String exiBajaIP = "Se dio de baja correctamente la IP del usuario.";
        /// <summary>
        /// Constantes para el mensaje exiComprobantePago
        /// </summary>
        public const String exiComprobantePago = "Documento guradado correctamente";
        /// <summary>
        /// Constantes para el mensaje exiEstatusActualizdo
        /// </summary> 
        public const String exiEstatusActualizdo = "Solicitud actualizada correctamente";
        /// <summary>
        /// Constantes para el mensaje exiIPMismoUsuario
        /// </summary>
        public const String exiIPMismoUsuario = "El usuario ya tenía asignada la IP proporcionada";
        /// <summary>
        /// Constantes para el mensaje exiLayoutRadicacion
        /// </summary>
        public const String exiLayoutRadicacion = "Se autorizó correctamente el Layout de Radicación";
        /// <summary>
        /// Constantes para el mensaje exiRegistroPoliza
        /// </summary>
        public const String exiRegistroPoliza = "Se ha guardado correctamente la asociación.";
        /// <summary>
        /// Constantes para el mensaje exiRelacionPoliza
        /// </summary>
        public const String exiRelacionPoliza = "La relación de pólizas se ha generado correctamente.";
        /// <summary>
        /// Constantes para el mensaje exiSolicitudesAsociadasCuenta
        /// </summary>
        public const String exiSolicitudesAsociadasCuenta = "Solicitud(es) asociada(s) a una cuenta correctamente";
        /// <summary>
        /// Constantes para el mensaje exiTransferencias
        /// </summary>
        public const String exiTransferencias = "Datos guardados correctamente";
        /// <summary>
        /// Constantes para el mensaje exiValidacionPoliza
        /// </summary>
        public const String exiValidacionPoliza = "Se ha autorizado correctamente la asociación.";
        /// <summary>
        /// Constantes para el mensaje infAumentoSaldo
        /// </summary>
        public const String infAumentoSaldo = "Aumento de Saldo exitoso";
        /// <summary>
        /// Constantes para el mensaje infAutorizar
        /// </summary>
        public const String infAutorizar = "¡La solicitud se autorizó con éxito!";
        /// <summary>
        /// Constantes para el mensaje infAutorizarSolicitud
        /// </summary>
        public const String infAutorizarSolicitud = "¿Desea autorizar la solicitud?";
        /// <summary>
        /// Constantes para el mensaje infAutorizarSolicitudVentanilla
        /// </summary>
        public const String infAutorizarSolicitudVentanilla = "¿Desea enviar la solicitud a  Fiscalización?";
        /// <summary>
        /// Constantes para el mensaje infAutorizaSolicitudABancos
        /// </summary>
        public const String infAutorizaSolicitudABancos = "¿Desea enviar la solicitud a  Bancos?";
        /// <summary>
        /// Constantes para el mensaje infCancelar
        /// </summary>
        public const String infCancelar = "¡La solicitud se canceló con éxito!";
        /// <summary>
        /// Constantes para el mensaje infCancelarSolicitud
        /// </summary>
        public const String infCancelarSolicitud = "¿Desea cancelar la solicitud?";
        /// <summary>
        /// Constantes para el mensaje infConfirmarConciliacion
        /// </summary>
        public const String infConfirmarConciliacion = "¿Desea enviar a enlace esta solicitud para su corrección?";
        /// <summary>
        /// Constantes para el mensaje infDescargarReporteErroresCargaMasiva
        /// </summary>
        public const String infDescargarReporteErroresCargaMasiva = "El archivo cargado no es válido, ¿Desea descargar el reporte de errores?";
        /// <summary>
        /// Constantes para el mensaje infDevolverSolicitud
        /// </summary>
        public const String infDevolverSolicitud = "¿Desea devolver la solicitud?";
        /// <summary>
        /// Constantes para el mensaje infExtensionArchivo
        /// </summary>
        public const String infExtensionArchivo = "El archivo debe ser .jpg o .pdf";
        /// <summary>
        /// Constantes para el mensaje infFirmaExitosa
        /// </summary>
        public const String infFirmaExitosa = "Se ha firmado correctamente el trámite";
        /// <summary>
        /// Constantes para el mensaje infFirmarTramite
        /// </summary>
        public const String infFirmarTramite = "¿Desea firmar el trámite?";
        /// <summary>
        /// Constantes para el mensaje infMontoADepositar
        /// </summary>
        public const String infMontoADepositar = "Importe mal capturado, por favor revise.";
        /// <summary>
        /// Constantes para el mensaje infMontoOtorgado
        /// </summary>
        public const String infMontoOtorgado = "Importe mal capturado, por favor revise.";
        /// <summary>
        /// Constantes para el mensaje  infNoExisteInformacionGrids
        /// </summary>
        public const String infNoExisteInformacionGrids = "¡No hay solicitudes con los parámetros seleccionados! ";
        /// <summary>
        /// Constantes para el mensaje infoComprobantePago
        /// </summary>
        public const String infoComprobantePago = "Es necesario adjuntar un documento";
        /// <summary>
        /// Constantes para el mensaje infRescatarSolicitud
        /// </summary>
        public const String infRescatarSolicitud = "¿Desea rescatar la solicitud?";
        /// <summary>
        /// Constantes para el mensaje infSeleccionarArchivo
        /// </summary>
        public const String infSeleccionarArchivo = "Es necesario seleccionar un archivo";
        /// <summary>
        /// Constantes para el mensaje infSinBeneficiarios
        /// </summary>
        public const String infSinBeneficiarios = "No cuenta con beneficiarios registrados";
        /// <summary>
        /// Constantes para el mensaje infSinCLC
        /// </summary>
        public const String infSinCLC = "No cuenta con registros de CLC";
        /// <summary>
        /// Constantes para el mensaje infSinDocumentos
        /// </summary>
        public const String infSinDocumentos = "No cuenta con documentación";
        /// <summary>
        /// Constantes para el mensaje infSinObservaciones
        /// </summary>
        public const String infSinObservaciones = "No cuenta con observaciones";
        /// <summary>
        /// Constantes para el mensaje infSolAsignar
        /// </summary>
        public const String infSolAsignar = "No cuenta con solicitudes para asignar";
        /// <summary>
        /// Constantes para el mensaje infSolEdicion
        /// </summary>
        public const String infSolEdicion = "Se actualizo la solicitud con el número de folio {0}";
        /// <summary>
        /// Constantes para el mensaje infSolRegistro
        /// </summary>
        public const String infSolRegistro = "Se registró la solicitud con el número de folio {0}";
        /// <summary>
        /// Constantes para el mensaje infTamanioArchivo
        /// </summary>
        public const String infTamanioArchivo = "El archivo debe ser menor a 4 MB";
        /// <summary>
        /// Constantes para el mensaje infTipoSolicitud
        /// </summary>
        public const String infTipoSolicitud = "Seleccione el tipo de solicitud que desea capturar";
        /// <summary>
        /// Constantes para el mensaje infTrabDisponible
        /// </summary>
        public const String infTrabDisponible = "No hay cargas de trabajo disponible";
        /// <summary>
        /// Constantes para el mensaje infValidarConciliaciones
        /// </summary>
        public const String infValidarConciliaciones = "Esta solicitud alcanzó el número máximo de conciliaciones permitidas.";
        /// <summary>
        /// Constantes para el mensaje infValidarSolicitud
        /// </summary>
        public const String infValidarSolicitud = "¿Desea validar la solicitud?";

    }   
}
