function getRegionOrCulture(region) {
    var regionInfo = $.formatCurrency.regions[region];
    if (regionInfo) {
        return regionInfo;
    }
    else {
        if (/(\w+)-(\w+)/g.test(region)) {
            var culture = region.replace(/(\w+)-(\w+)/g, "$1");
            return $.formatCurrency.regions[culture];
        }
    }
    // fallback to extend(null) (i.e. nothing)
    return null;
}

function validateParseType(parseType) {
    switch (parseType.toLowerCase()) {
        case 'int':
            return 'Int';
        case 'float':
            return 'Float';
        default:
            throw 'invalid parseType';
    }
}

function generateRegex(settings) {
    if (settings.symbol === '') {
        return new RegExp("[^\\d" + settings.decimalSymbol + "-]", "g");
    }
    else {
        var symbol = settings.symbol.replace('$', '\\$').replace('.', '\\.');
        return new RegExp(symbol + "|[^\\d" + settings.decimalSymbol + "-]", "g");
    }
}

//Author :JUVA
function esDecimal3(evt, element) {
    //console.log('entro');
    var charCode = (evt.which) ? evt.which : event.keyCode
    //if (charCode > 31 && (charCode < 48 || charCode > 57) && !(charCode == 46 || charCode == 8))
    if (!(charCode > 47 && charCode < 58) && !(charCode == 46))
        return false;
    else {
        var len = $(element).val().length;
        var index = $(element).val().indexOf('.');
        if (len == 0 && charCode == 46) {
            return false
        }
        if (index > 0 && charCode == 46) {
            return false;
        }
        if (index > 0) {
            var CharAfterdot = (len + 1) - index;
            if (CharAfterdot > 3) {
                return false;
            }
        } else if (index == 0) {
            var CharAfterdot = (len + 1) - index;
            if (CharAfterdot > 3) {
                return false;
            }
        }

    }
    return true;
}

function OcultarObservacines() {
    $('.ObsevacionesOcul').hide();
}

(function ($) {
    $('.spinner .btn:first-of-type').on('click', function () {
        $('.spinner input').val(parseInt($('.spinner input').val(), 10) + 1);
    });
    $('.spinner .btn:last-of-type').on('click', function () {
        $('.spinner input').val(parseInt($('.spinner input').val(), 10) - 1);
    });
})(jQuery);

function jsDecimals(e) {

    var evt = (e) ? e : window.event;
    var key = (evt.keyCode) ? evt.keyCode : evt.which;
    if (key != null) {
        key = parseInt(key, 10);
        if ((key < 48 || key > 57) && (key < 96 || key > 105)) {
            if (!jsIsUserFriendlyChar(key, "Decimals")) {
                return false;
            }
        }
        else {
            if (evt.shiftKey) {
                return false;
            }
        }
    }
    return true;
}
function jsNoDecimals(e) {


    var evt = (e) ? e : window.event;
    var key = (evt.keyCode) ? evt.keyCode : evt.which;
    if (key != null) {
        key = parseInt(key, 10);
        if ((key < 48 || key > 57) && (key < 96 || key > 105)) {
            if (!jsIsUserFriendlyChar(key, "NoDecimals")) {
                return false;
            }
        }
        else {
            if (evt.shiftKey) {
                return false;
            }
        }
    }
    return true;
}

function jsIsUserFriendlyChar(val, step) {
    // Backspace, Tab, Enter, Insert, y Delete
    if (val == 8 || val == 9 || val == 13 || val == 45 || val == 46) {
        return true;
    }
    // Ctrl, Alt, CapsLock, Home, End, y flechas
    if ((val > 16 && val < 21) || (val > 34 && val < 41)) {
        return true;
    }
    if (step == "Decimals") {
        if (val == 190 || val == 110) {  //Check dot key code should be allowed
            return true;
        }
    }
    // The rest
    return false;
}

function openModal() {
    $('#myModal').modal('show');
}

$('.FormartoDinero').on('change', function (e) {

    $(this).val($(this).val().replace("$", "").replace(/,/gi, ""));
    if (!$.isNumeric($(this).val()))
        $(this).val('0').trigger('change');

    $(this).val('$' + parseFloat($(this).val(), 10).toFixed(2).replace(/(\d)(?=(\d{3})+\.)/g, "$1,").toString());
});

/*Funcion para obtener la fecha actual, sirve para todos los modulos*/
function fechaActual() {
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1; //January is 0!

    var yyyy = today.getFullYear();
    if (dd < 10) {
        dd = '0' + dd;
    }
    if (mm < 10) {
        mm = '0' + mm;
    }
    var today = dd + '/' + mm + '/' + yyyy;
    return today;
}

function ShowMessage(message, messagetype) {
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
    $('#alert_container').append('<div id="alert_div"  class="alert fade in ' + cssclass + '"><a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a><strong>' + messagetype + '!</strong> <span>' + message + '</span></div>');
}


function ShowProgress() {
    setTimeout(function () {
        var modal = $('<div />');
        modal.addClass("mdloading");
        $('body').append(modal);
        var loading = $(".loading");
        loading.show();
        var top = Math.max($(window).height() / 2 - loading[0].offsetHeight / 2, 0);
        var left = Math.max($(window).width() / 2 - loading[0].offsetWidth / 2, 0);
        loading.css({ top: top, left: left, height: 120 });
    }, 200);
}

function HideProgress() {
    setTimeout(function () {
        $("div").remove('.mdloading');
        var loading = $(".loading");
        loading.hide();
    }, 200);
} function getRegionOrCulture(region) {
    var regionInfo = $.formatCurrency.regions[region];
    if (regionInfo) {
        return regionInfo;
    }
    else {
        if (/(\w+)-(\w+)/g.test(region)) {
            var culture = region.replace(/(\w+)-(\w+)/g, "$1");
            return $.formatCurrency.regions[culture];
        }
    }
    // fallback to extend(null) (i.e. nothing)
    return null;
}

function validateParseType(parseType) {
    switch (parseType.toLowerCase()) {
        case 'int':
            return 'Int';
        case 'float':
            return 'Float';
        default:
            throw 'invalid parseType';
    }
}

function generateRegex(settings) {
    if (settings.symbol === '') {
        return new RegExp("[^\\d" + settings.decimalSymbol + "-]", "g");
    }
    else {
        var symbol = settings.symbol.replace('$', '\\$').replace('.', '\\.');
        return new RegExp(symbol + "|[^\\d" + settings.decimalSymbol + "-]", "g");
    }
}

//Author :JUVA
function esDecimal3(evt, element) {
    //console.log('entro');
    var charCode = (evt.which) ? evt.which : event.keyCode
    //if (charCode > 31 && (charCode < 48 || charCode > 57) && !(charCode == 46 || charCode == 8))
    if (!(charCode > 47 && charCode < 58) && !(charCode == 46))
        return false;
    else {
        var len = $(element).val().length;
        var index = $(element).val().indexOf('.');
        if (len == 0 && charCode == 46) {
            return false
        }
        if (index > 0 && charCode == 46) {
            return false;
        }
        if (index > 0) {
            var CharAfterdot = (len + 1) - index;
            if (CharAfterdot > 3) {
                return false;
            }
        } else if (index == 0) {
            var CharAfterdot = (len + 1) - index;
            if (CharAfterdot > 3) {
                return false;
            }
        }

    }
    return true;
}

function OcultarObservacines() {
    $('.ObsevacionesOcul').hide();
}

(function ($) {
    $('.spinner .btn:first-of-type').on('click', function () {
        $('.spinner input').val(parseInt($('.spinner input').val(), 10) + 1);
    });
    $('.spinner .btn:last-of-type').on('click', function () {
        $('.spinner input').val(parseInt($('.spinner input').val(), 10) - 1);
    });
})(jQuery);

function jsDecimals(e) {

    var evt = (e) ? e : window.event;
    var key = (evt.keyCode) ? evt.keyCode : evt.which;
    if (key != null) {
        key = parseInt(key, 10);
        if ((key < 48 || key > 57) && (key < 96 || key > 105)) {
            if (!jsIsUserFriendlyChar(key, "Decimals")) {
                return false;
            }
        }
        else {
            if (evt.shiftKey) {
                return false;
            }
        }
    }
    return true;
}
function jsNoDecimals(e) {


    var evt = (e) ? e : window.event;
    var key = (evt.keyCode) ? evt.keyCode : evt.which;
    if (key != null) {
        key = parseInt(key, 10);
        if ((key < 48 || key > 57) && (key < 96 || key > 105)) {
            if (!jsIsUserFriendlyChar(key, "NoDecimals")) {
                return false;
            }
        }
        else {
            if (evt.shiftKey) {
                return false;
            }
        }
    }
    return true;
}

function jsIsUserFriendlyChar(val, step) {
    // Backspace, Tab, Enter, Insert, y Delete
    if (val == 8 || val == 9 || val == 13 || val == 45 || val == 46) {
        return true;
    }
    // Ctrl, Alt, CapsLock, Home, End, y flechas
    if ((val > 16 && val < 21) || (val > 34 && val < 41)) {
        return true;
    }
    if (step == "Decimals") {
        if (val == 190 || val == 110) {  //Check dot key code should be allowed
            return true;
        }
    }
    // The rest
    return false;
}

function openModal() {
    $('#myModal').modal('show');
}

$('.FormartoDinero').on('change', function (e) {

    $(this).val($(this).val().replace("$", "").replace(/,/gi, ""));
    if (!$.isNumeric($(this).val()))
        $(this).val('0').trigger('change');

    $(this).val('$' + parseFloat($(this).val(), 10).toFixed(2).replace(/(\d)(?=(\d{3})+\.)/g, "$1,").toString());
});

/*Funcion para obtener la fecha actual, sirve para todos los modulos*/
function fechaActual() {
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1; //January is 0!

    var yyyy = today.getFullYear();
    if (dd < 10) {
        dd = '0' + dd;
    }
    if (mm < 10) {
        mm = '0' + mm;
    }
    var today = dd + '/' + mm + '/' + yyyy;
    return today;
}

function ShowMessage(message, messagetype) {
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
    $('#alert_container').append('<div id="alert_div"  class="alert fade in ' + cssclass + '"><a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a><strong>' + messagetype + '!</strong> <span>' + message + '</span></div>');
}


function ShowProgress() {
    setTimeout(function () {
        var modal = $('<div />');
        modal.addClass("mdloading");
        $('body').append(modal);
        var loading = $(".loading");
        loading.show();
        var top = Math.max($(window).height() / 2 - loading[0].offsetHeight / 2, 0);
        var left = Math.max($(window).width() / 2 - loading[0].offsetWidth / 2, 0);
        loading.css({ top: top, left: left, height: 120 });
    }, 200);
}

function HideProgress() {
    setTimeout(function () {
        $("div").remove('.mdloading');
        var loading = $(".loading");
        loading.hide();
    }, 200);
}