/// funcion: función a ejecutar en else success
/// div: div a renderizar
function EjecutaAjax(url, modelo, funcion, div) {
    $.ajax({
        type: "POST",
        url: url,
        data: modelo,
        async: false,
        cache: false,
        success: function (htmlResult) {
            if (funcion != null && funcion != undefined) {
                funcion(htmlResult);
            }
            if (div != funcion && div != undefined) {
                $("#" + div).html(htmlResult);
            }
        },
        error: function (errorHtml) {
            alert("ERROR: " + JSON.stringify(errorHtml));
        },
        complete: function (XMLHttpRequest, status) {
        }
    });
}

function redirect(url) {
    url = new String(url);
    url = url.replace(".aspx", "");
    EjecutaAjax(url, null, null, "SeccionTrabajo");
    $("#collapseExample").removeClass("in");
    $("#collapseExample").addClass("collapse out");
}
