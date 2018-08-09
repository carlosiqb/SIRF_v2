$(document).ready(function () {

    $('[data-toggle="tooltip"]').tooltip();

    $('#btnAgregar').click(function () {        
        $('#ModalCuotaDiaria').modal('show');
        CuotasDiarias();
        //CuentaBancaria();
        Partida();
    });

    $('#btnSalir').click(function () {
        localStorage.removeItem('lastTab');
        window.location.href('../Default.aspx')
    });    
});

function CuotasDiarias()
{
    $.ajax({
        type: 'GET',
        cache: false,
        url: 'frmSolicitudCuotas.aspx/CuotasDiarias',
        //data: JSON.stringify(persona),                                            
        contentType: "application/json; charset=utf-8",
        dataType: 'json',
        async: true,
        success: function (respuesta) {

            if (respuesta.d.TipoEstatus == 0) {
                var elementosMenu = "";
                $.each(respuesta.d.ListaRegistros, function (index, value) {
                    $("#ddlCuotasDiarias").append("<option value=" + value.conceptoGastosID + ">" + value.descripcionConceptoGasto + "</option>");
                });
            }
            else {

            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            if (XMLHttpRequest.responseText != '') {
                //$('#myModal').modal('show');
                //$('#tituloModal').html('<h4 class="modal-title">Error</h4>');
                //$('#lblError').html('<p>' + XMLHttpRequest.responseText + '</p>');
            }
            else {
                //targetUrl = '/Login';
                //window.location.href = targetUrl;
            }
        }
    });

}

function CuentaBancaria(ctrl)
{
    var numeroExpediente = ctrl.value;

    if (numeroExpediente != "") {
        $.ajax({
            type: 'GET',
            cache: false,
            url: 'frmSolicitudCuotas.aspx/CuentaBancaria',
            //data: JSON.stringify(numeroExpediente),
            data: { var1: numeroExpediente },
            contentType: "application/json; charset=utf-8",
            dataType: 'json',
            async: true,
            success: function (respuesta) {

                if (respuesta.d.TipoEstatus == 0) {
                    var elementosMenu = "";
                    $.each(respuesta.d.ListaRegistros, function (index, value) {
                        $("#ddlPartida").append("<option value=" + value.CodPartida + ">" + value.DescripcionPartida + "</option>");
                    });
                }
                else {

                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                if (XMLHttpRequest.responseText != '') {
                    //$('#myModal').modal('show');
                    //$('#tituloModal').html('<h4 class="modal-title">Error</h4>');
                    //$('#lblError').html('<p>' + XMLHttpRequest.responseText + '</p>');
                }
                else {
                    //targetUrl = '/Login';
                    //window.location.href = targetUrl;
                }
            }
        });
    }
    else {
        alert("Debe de ingresar un número de expediente.");
    }
}

function Partida()
{
    $.ajax({
        type: 'GET',
        cache: false,
        url: 'frmSolicitudCuotas.aspx/Partidas',        
        contentType: "application/json; charset=utf-8",
        dataType: 'json',
        async: true,
        success: function (respuesta) {

            if (respuesta.d.TipoEstatus == 0) {
                var elementosMenu = "";
                $.each(respuesta.d.ListaRegistros, function (index, value) {
                    $("#ddlPartida").append("<option value=" + value.CodPartida + ">" + value.DescripcionPartida + "</option>");
                });
            }
            else {

            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            if (XMLHttpRequest.responseText != '') {
                //$('#myModal').modal('show');
                //$('#tituloModal').html('<h4 class="modal-title">Error</h4>');
                //$('#lblError').html('<p>' + XMLHttpRequest.responseText + '</p>');
            }
            else {
                //targetUrl = '/Login';
                //window.location.href = targetUrl;
            }
        }
    });
}

function LlamadoAJAX(tipoLlamado, controladorURL) {

}
