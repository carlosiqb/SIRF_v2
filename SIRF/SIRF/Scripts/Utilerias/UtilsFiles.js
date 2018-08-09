/*Para poder validar el tamaño de los archivos a subir a la base de datos*/
$(document).on('change', 'input[type="file"]', function () {
    // this.files[0].size recupera el tamaño del archivo
    // alert(this.files[0].size);
    var fileName = this.files[0].name;
    var fileSize = this.files[0].size;

    if (fileSize > 5242880) {
        $('#contentBody_lblMensaje').html('El tamaño del archivo seleccionado supera los 5 MB permitidos.');
        $('#ModalFileUp').modal();
        //alert('El archivo no debe superar los 5MB');
        this.value = '';
        this.files[0].name = '';
    } else {
        // recuperamos la extensión del archivo
        var ext = fileName.split('.').pop();

        // console.log(ext);
        switch (ext) {
        case 'jpg':
        case 'jpeg':
        case 'png':
        case 'pdf':
            break;
        default:
            $('#contentBody_lblMensaje').html('La extensión seleccionada no esta permitida, por favor vuelva a seleccionar un nuevo archivo.');
            $('#ModalFileUp').modal();
            this.value = ''; // reset del valor
            this.files[0].name = '';
        }
    }
});