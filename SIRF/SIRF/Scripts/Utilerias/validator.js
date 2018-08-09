/* Incluimos un método para validar el campo nombre */
jQuery.validator.addMethod("curp", function (value, element) {
    return this.optional(element) || /^[A-Z]{1}[AEIOU]{1}[A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[HM]{1}(AS|BC|BS|CC|CS|CH|CL|CM|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)[B-DF-HJ-NP-TV-Z]{3}[0-9A-Z]{1}[0-9]{1}$/i.test(value);
})

jQuery.validator.addMethod("rfc", function (value, element){
    return this.optional(element) || /[A-Z,Ñ,&amp;]{3,4}[0-9]{2}[0-1][0-9][0-3][0-9][A-Z,0-9]?[A-Z,0-9]?[0-9,A-Z]?/i.test(value);
})

jQuery.validator.addMethod("letras", function (value, element) {
    return this.optional(element) || /^[a-zA-Z\'\-\sáéíóúñÑÁÉÍÓÚüÜ]+$/i.test(value);
})

jQuery.validator.addMethod("calle", function (value, element) {
    return this.optional(element) || /^[a-zA-Z\'\-\ssáéíóúñÑÁÉÍÓÚüÜ.,0-9]+$/i.test(value);
})

jQuery.validator.addMethod("fecha", function (value, element){
    return this.optional(element) || /^[/0-9]+$/i.test(value);
})

$.validator.addMethod('filesize', function (value, element, param) {
    return this.optional(element) || (element.files[0].size <= param)
});

$(function () {
    $("#formIndex").validate({
        errorElement: "small",
        rules: {
            "Item1.Lada": {
                //required: true,
                number: true
            },
            "Item1.Telephone": {
                required: true,
                number: true
            },
            "Item1.Movil": {
                minlength: 10,
                number: true
            },
            "Item1.Email": {
                required: true,
                minlength: 2,
                email: true
            },
            "Item1.CURP": {
                required: true,
                minlength: 18,
                curp: true
            },
            "Item1.RFC": {
                required: true,
                minlength: 10,
                rfc: true
            },
            "Item1.Name": {
                required: true,
                letras: true
            },
            "Item1.MaternalLastName":{
                letras: true
            },
            "Item1.PaternalLastName": {
                required: true,
                letras: true
            },
            "Gender": {
                required: true,
            },
            "Item1.Birthdate": {
                fecha: true
            },
            "Item1.Birthplace": {
                required: true,
                letras: true
            },
            "Item1.ZipCode": {
                required: true,
                number: true,
                minlength: 5
            },
            "Item1.City": {
                required: true,
                calle: true
            },
            "Item1.Colony": {
                required: true,
                calle: true
            },
            "Item1.Street": {
                required: true,
                calle: true
            },
            "Item1.NumExt": { required: true, calle: true },
            "Item1.NumInt": { calle: true},
	    Movil: {number: true}
        },
        messages: {
            "Item1.Lada": {
                required: "Este campo es obligatorio.",
                number: "Introduce un número válido.",
                minlength: "Introduce al menos 2 dígitos."

            },
            "Item1.Telephone": {
                required: "Este campo es obligatorio.",
                number: "Introduce un número válido.",
                minlength: "Introduce al menos 8 dígitos."
            },
            "Item1.Movil": {
                number: "Introduce un número válido.",
                minlength: "Introduce al menos 10 dígitos."
            },
            "Item1.Email": {
                required: "Este campo es obligatorio.",
                email :"Introduce un correo válido.",
                minlength: "Introduce al menos 2 dígitos."
            },
            "Item1.CURP": {
                required: "Este campo es obligatorio.",
                minlength: "Debe introducir los 18 caracteres de su CURP.",
                curp: "Introduce una CURP válida."
            },
            "Item1.RFC": {
                required: "Este campo es obliatorio.",
                minlength: "Introduce al menos 10 dígitos.",
                rfc: "Introduce un RFC válido."
            },
            "Item1.Name": { required: "Este campo es obligatorio.", letras: "Solo debe ingresar letras." },
            "Item1.PaternalLastName": { required: "Este campo es obligatorio.", letras: "Solo debe ingresar letras." },
            "Item1.MaternalLastName": { letras: "Solo debe de ingresar letras." },
            "Gender": { required: "Selecciona una opción." },
            "Item1.Birthplace": { required: "Este campo es obligatorio.", letras: "Solo debe ingresar letras." },
            "Item1.Birthdate": { fecha: "Ingresa una fecha válida." },
            "Item1.ZipCode": { required: "Este campo es obligatorio.", number: "Introduce un número válido.", minlength: "Introduce al menos 5 caracteres." },
            "Item1.City": { required: "Este campo es obligatorio.", calle: "Solo debe ingresar números y/o letras." },
            "Item1.Colony": { required: "Este campo es obligatorio.", calle: "Solo debe ingresar números y/o letras." },
            "Item1.Street": { required: "Este campo es obligatorio.", calle: "Solo debe ingresar números y/o letras." },
            "Item1.NumExt": {required: "Este campo es obligatorio.", calle: "Solo debe ingresar números y/o letras."},
            "Item1.NumInt": { calle: "Solo debe ingresar números y/o letras."},
    	    "Item1.Movil":{number: "Introduce un número válido."}
        },
        highlight: function (element, errorClass, validClass) {

            $(element).prev().find(".required")
                      .addClass("error")
                      .removeClass(validClass);
            $(element).addClass("error")
                      .removeClass(validClass);

        },
        unhighlight: function (element, errorClass, validClass) {
            $(element).prev().find(".required")
                      .removeClass("error")
                      .addClass(validClass);
            $(element).removeClass("error")
                      .addClass(validClass);
        }
    });

        $('[name="Ingresar"]').click(function () {
            // your code that handles a cancel click
            $("#formNotEntitle").validate({
                errorElement: "small",
                rules: {
                    CURP: {
                        required: true,
                        minlength: 18,
                        curp: true
                    }
                },
                messages: {
                    CURP: {
                        required: "Este campo es obligatorio.",
                        minlength: "Tienes que ingresar los 18 caracteres.",
                        curp: "Ingresa un CURP válido."
                    }
                },
                unhighlight: function (element, errorClass, validClass) {
                    $(element).prev().find(".required")
                              .removeClass("error")
                              .addClass(validClass);
                    $(element).removeClass("error")
                              .addClass(validClass);
                }
            });
        });

    $('[name="Nuevo"]').click(function () {

        //alert("Limpiar los datos y redirigir al index");
        window.location = "index";
    });


    $("#formRegister").validate({
        errorElement: "small",
        rules: {            
        "ddltypeowner": {
            required: true,
            },
        "reqPrpEnt.Lada2": {
                number: true
            },
        "reqPrpEnt.Telephone2": {
                required: true,
                number: true
            },
        "reqPrpEnt.Email": {
                required: true,
                minlength: 2,
                email: true
            },            

            "FederalEntityCat": {
                required: true
            },
            "PropertTypeCat": {
                required: true
            },
            "reqPrpEnt.ZipCode": {
                required: true,
                number: true,
                minlength: 5
            },
            "reqPrpEnt.ZipCode2": {
                required: true,
                number: true,
                minlength: 5
            },
            "reqPrpEnt.Colony": {
                required: true,
                calle: true
            },
            "reqPrpEnt.Delegation": {
                required: true,
                calle: true
            },
            "reqPrpEnt.Street": {
                required: true,
                calle: true
            },
            "GenderCat":{
                required: true
            },
            "TypeOwnerCat": {
                required: true
            },
            "UrbanCenterCat": {
                required: true
            },

            "reqPrpEnt.Name": {
                required: true,
                letras: true
            },
            "reqPrpEnt.PaternalLastName": {
                required: true,
                letras: true
            },
            "reqPrpEnt.MaternalLastName": {
                letras: true
            },
            "reqPrpEnt.CURP2": {
                required: true,
                minlength: 18,
                curp: true
            },
            "reqPrpEnt.Birthdate": {
                fecha: true
            },
            "reqPrpEnt.Birthplace": {
                required: true,
                letras: true
            },
            "reqPrpEnt.City2": {
                required: true,
                calle: true
            },
            "reqPrpEnt.Colony2": {
                required: true,
                calle: true
            },
            "reqPrpEnt.Street2": {
                required: true,
                calle: true
            },
            "reqPrpEnt.NumExt": {
                required: true,
                calle: true
            },
            "reqPrpEnt.NumExt2": {
                required: true,
                calle: true
            },
            "reqPrpEnt.NumInt": {                
                calle: true
            },
            "reqPrpEnt.NumInt2": {
                calle: true
            },
            "reqPrpEnt.Square": {
                calle: true
            },
            "reqPrpEnt.Square2": {
                calle: true
            },
            "reqPrpEnt.Lote": {
                calle: true
            },
            "reqPrpEnt.Lote2": {
                calle: true
            },
            "reqPrpEnt.BetweenStreet": { calle: true },
            "reqPrpEnt.UbicationDescription": { calle: true }

        },

        messages: {

            "reqPrpEnt.Lada2": {
                number: "Introduce un número válido.",
                minlength: "Introduce al menos 2 dígitos."
            },
            "reqPrpEnt.Telephone2": {
                required: "Este campo es obligatorio.",
                number: "Introduce un número válido.",
                minlength: "Introduce al menos 8 dígitos."
            },
            "reqPrpEnt.Email": {
                required: "Este campo es obligatorio.",
                email: "Introduce un correo válido."
            },
            "ddltypeowner": {
                required: "Selecciona una opción."
            },
            "FederalEntityCat": {
                required: "Selecciona una opción."
            },
            "PropertTypeCat": {
                required: "Selecciona una opción."
            },
            "reqPrpEnt.ZipCode": {
                required: "Este campo es obligatorio.",
                number: "Introduce un número válido."
            },
            "reqPrpEnt.ZipCode2": {
                required: "Este campo es obligatorio.",
                number: "Introduce un número válido."
            },
            "reqPrpEnt.Delegation": {
                required: "Este campo es obligatorio.",
                calle: "Solo debe ingresar números y/o letras."
            },
            "reqPrpEnt.Colony": {
                required: "Este campo es obligatorio.",
                calle: "Solo debe ingresar números y/o letras."
            },           
            "reqPrpEnt.Street": {
                required: "Este campo es obligatorio.",
                calle: "Solo debe ingresar números y/o letras."
            },
            "TypeOwnerCat": {
                required: "Selecciona una opción."
            },
            "UrbanCenterCat": {
                required: "Selecciona una opción."
            },
            "reqPrpEnt.Name": { required: "Este campo es obligatorio.", letras: "Solo debe ingresar letras." },
            "reqPrpEnt.PaternalLastName": { required: "Este campo es obligatorio.", letras: "Solo debe ingresar letras." },
            "reqPrpEnt.MaternalLastName": { letras: "Solo debe ingresar letras." },
            "reqPrpEnt.Birthplace": { letras: "Solo debe ingresar letras." },
            "reqPrpEnt.Birthdate": { fecha: "Ingresa una fecha válida." },
            "ddlSex": { required: "Selecciona una opción." },
            "reqPrpEnt.City2": { required: "Este campo es obligatorio.", calle: "Solo debe ingresar números y/o letras." },
            "reqPrpEnt.Colony2": { required: "Este campo es obligatorio.", calle: "Solo debe ingresar números y/o letras." },
            "reqPrpEnt.Street2": { required: "Este campo es obligatorio.", calle: "Solo debe ingresar números y/o letras." },
            "reqPrpEnt.NumExt": { calle: "Solo debe ingresar números y/o letras." },
            "reqPrpEnt.NumInt": { calle: "Solo debe ingresar números y/o letras." },
            "reqPrpEnt.Square": { calle: "Solo debe ingresar números y/o letras." },
            "reqPrpEnt.NumExt2": { calle: "Solo debe ingresar números y/o letras." },
            "reqPrpEnt.NumInt2": { calle: "Solo debe ingresar números y/o letras." },
            "reqPrpEnt.Square2": { calle: "Solo debe ingresar números y/o letras." },
            "reqPrpEnt.CURP2": {
                required: "Este campo es obligatorio.",
                minlength: "Debe introducir los 18 caracteres de su CURP.",
                curp: "Introduce una CURP válida."
            },
            "reqPrpEnt.Lote": { calle: "Solo debe ingresar números y/o letras." },
            "reqPrpEnt.Lote2": { calle: "Solo debe ingresar números y/o letras." },
            "reqPrpEnt.BetweenStreet": { calle: "Solo debe ingresar números y/o letras." },
            "reqPrpEnt.UbicationDescription": { calle: "Solo debe ingresar números y/o letras." }
           },

        highlight: function (element, errorClass, validClass) {

            $(element).prev().find(".required")
                        .addClass("error")
                        .removeClass(validClass);
            $(element).addClass("error")
                        .removeClass(validClass);

        },
        unhighlight: function (element, errorClass, validClass) {
            $(element).prev().find(".required")
                        .removeClass("error")
                        .addClass(validClass);
            $(element).removeClass("error")
                        .addClass(validClass);
        }
    });

    $("#formDocs").validate({
        errorElement: "small",
        rules: {
            "1": {
                required: true,
                extension: "png|jpe?g|gif|pdf",
                filesize: 5242880
            },
            "2": {
                required: true,
                extension: "png|jpe?g|gif|pdf",
                filesize: 5242880
            },
            "3": {
                required: true,
                extension: "png|jpe?g|gif|pdf",
                filesize: 5242880
            },
            "4": {
                required: true,
                extension: "png|jpe?g|gif|pdf",
                filesize: 5242880
            },
            "5": {
                required: true,
                extension: "png|jpe?g|gif|pdf",
                filesize: 5242880
            },
            "6": {
                required: true,
                extension: "png|jpe?g|gif|pdf",
                filesize: 5242880
            },
            "7": {
                required: true,
                extension: "png|jpe?g|gif|pdf",
                filesize: 5242880
            },
            "8": {
                required: true,
                extension: "png|jpe?g|gif|pdf",
                filesize: 5242880
            },
            "9": {
                required: true,
                extension: "png|jpe?g|gif|pdf",
                filesize: 5242880
            },
            "10": {
                required: true,
                extension: "png|jpe?g|gif|pdf",
                filesize: 5242880
            }
        },
        messages: {
            "1": {
                required: "Debes subir el documento requerido.",
                extension: "Debe ingresar una extensión válida.",
                filesize: "El tamaño del archivo debe ser menor a 5 MB."
            },
            "2": {
                required: "Debes subir el documento requerido.",
                extension: "Debe ingresar una extensión válida.",
                filesize: "El tamaño del archivo debe ser menor a 5 MB."
            },
            "3": {
                required: "Debes subir el documento requerido.",
                extension: "Debe ingresar una extensión válida.",
                filesize: "El tamaño del archivo debe ser menor a 5 MB."
            },
            "4": {
                required: "Debes subir el documento requerido.",
                extension: "Debe ingresar una extensión válida.",
                filesize: "El tamaño del archivo debe ser menor a 5 MB."
            },
            "5": {
                required: "Debes subir el documento requerido.",
                extension: "Debe ingresar una extensión válida.",
                filesize: "El tamaño del archivo debe ser menor a 5 MB."
            },
            "6": {
                required: "Debes subir el documento requerido.",
                extension: "Debe ingresar una extensión válida.",
                filesize: "El tamaño del archivo debe ser menor a 5 MB."
            },
            "7": {
                required: "Debes subir el documento requerido.",
                extension: "Debe ingresar una extensión válida.",
                filesize: "El tamaño del archivo debe ser menor a 5 MB."
            },
            "8": {
                required: "Debes subir el documento requerido.",
                extension: "Debe ingresar una extensión válida.",
                filesize: "El tamaño del archivo debe ser menor a 5 MB."
            },
            "9": {
                required: "Debes subir el documento requerido.",
                extension: "Debe ingresar una extensión válida.",
                filesize: "El tamaño del archivo debe ser menor a 5 MB."
            },
            "10": {
                required: "Debes subir el documento requerido.",
                extension: "Debe ingresar una extensión válida.",
                filesize: "El tamaño del archivo debe ser menor a 5 MB."
            }
        },

        highlight: function (element, errorClass, validClass) {
            
            $(element).prev().find(".required")
                        .addClass("error")
                        .removeClass(validClass);
            $(element).addClass("error")
                        .removeClass("error");            
        },
        unhighlight: function (element, errorClass, validClass) {
            $(element).prev().find(".required")
                        .removeClass("error")
                        .addClass(validClass);
            $(element).removeClass("error")
                        .addClass(validClass);
        },
        submitHandler: function (form) {
            form.submit();
            Mostrar();
        }
    });
});

