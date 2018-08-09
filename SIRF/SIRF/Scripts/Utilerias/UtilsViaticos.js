/*Funciones de JS para viaticos*/
function ShowMessage3(message, messagetype) {
    var cssclass;
    switch (messagetype) {
        case 'Success':
            cssclass = 'alert-success'
            break;
        case 'Error':
            cssclass = 'alert-danger'
            break;
        case 'Warning':
            cssclass = 'alert-warning'
            break;
        default:
            cssclass = 'alert-info'
    }
    $('#alert_containergv').append('<div id="alert_div"  class="alert fade in ' + cssclass + '"><a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a><strong>' + messagetype + '!</strong> <span>' + message + '</span></div>');
}

function validateDecimalFolio(valor) {
    $('#hdntxtFechaSolicitud').val($("#txtFecha").val());
    $('#hdntxtOficioSol').val($("#txtOficioSol").val());

    if (valor.value != '' && valor.value != undefined) {
        //document.getElementById('<%=validaOficio.ClientID%>').click();
        return true;
    }
    return false;
};

function ObsevacionesOcul_general() {
    $('.ObsevacionesOcul').hide();
}

function limpiafolio() {
    $("#txtOficioSol").val('');
}

function validateDecimal(valor) {
    var RE = /^[a-z0-9\-\/]+$/i;
    if (RE.test(valor.value)) {
        //document.getElementById('<%=validaOficio.ClientID%>').click();
        return true;
    } else {
        valor.value = "";
        valor.focus();
        return false;
    }
};

function ObtenerDatosSolicitud_general() {
    if ($('#hdntxtFechaSolicitud').val() != '') {
        $('#txtFechaSolicitud').val($('#hdntxtFechaSolicitud').val());
        $('#txtFecha').val($('#hdntxtFechaSolicitud').val());
        $('#txtFolioSolicitud').val($('#hdntxtFolioSolicitud').val());
        $('#txtObservaciones').val($('#hdntxtObservaciones').val());
    }
}
/*
$(function () {
    $('.datepicker').datepicker({
        format: 'dd/mm/yyyy',
        language: 'es',
        startDate: 'today',
        autoclose: true,
        todayBtn: 'linked',
        todayHighlight: true,
        enableOnReadonly: false
    }).on('changeDate', function (ev) {
        $('#hdntxtFechaSolicitud').val($('#txtFecha').val());
    });
});
*/
function MostrarModalViatico() {
    $('#ModalViatico').modal('show');
}
/*
$(function () {
    var seleccion = document.getElementById('Seleccionado').value;
    var fechaI = new Date();
    var fechaF = new Date();

    if (seleccion == 22 || seleccion == 24) {
        fechaII = new Date(fechaI.setDate(fechaI.getDate() - 365));
        fechaFF = new Date(fechaF.setDate(fechaF.getDate() - 1));
    } else {
        fechaII = new Date(fechaI.setDate(fechaI.getDate() + 0));
        fechaFF = new Date(fechaF.setDate(fechaF.getDate() + 365));
    }

    $('.input-daterange').datepicker({
        startDate: fechaII.getDate() + "/" + (fechaII.getMonth() + 1) + "/" + fechaII.getFullYear(),
        endDate: fechaFF.getDate() + "/" + (fechaFF.getMonth() + 1) + "/" + fechaFF.getFullYear(),
        todayBtn: "linked",
        format: "dd/mm/yyyy",
        language: "es",
        autoclose: true,
        todayHighlight: true,
        enableOnReadonly: false,
    })
        .change()
        .on('changeDate', function (ev) {
            $('#txtFechaFinal').datepicker("setStartDate", $('#txtFechaInicial').val());
        });
});

*/