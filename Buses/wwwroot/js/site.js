// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//function zoom() {
//      document.getElementById('imagenTuristico').style.width = '90px';
//}
//function desZoom() {
//    document.getElementById('imagenTuristico').style.width = '80px';
//}

$(document).ready(function () {
    $("#imagenTuristico").mouseover(function () {
        $(this).css("width", "90");
    });

    $("#imagenTuristico").mouseout(function () {
        $(this).css("width", "80");
    });

    $("#visa").mouseover(function () {
        $(this).css("width", "80");
    });

    $("#visa").mouseout(function () {
        $(this).css("width", "70");
    });

    $("#american").mouseover(function () {
        $(this).css("width", "80");
    });

    $("#american").mouseout(function () {
        $(this).css("width", "70");
    });

    $("#mastercard").mouseover(function () {
        $(this).css("width", "80");
    });

    $("#mastercard").mouseout(function () {
        $(this).css("width", "70");
    });

    $("#pagoEfectivo").mouseover(function () {
        $(this).css("width", "144");
    });

    $("#pagoEfectivo").mouseout(function () {
        $(this).css("width", "126");
    });

    $("#diners").mouseover(function () {
        $(this).css("width", "80");
    });

    $("#diners").mouseout(function () {
        $(this).css("width", "70");
    });

    $("#paypal").mouseover(function () {
        $(this).css("width", "80");
    });

    $("#paypal").mouseout(function () {
        $(this).css("width", "70");
    });

    $("#linkedin").mouseover(function () {
        $(this).css("width", "40");
    });

    $("#linkedin").mouseout(function () {
        $(this).css("width", "30");
    });

    $("#youtube").mouseover(function () {
        $(this).css("width", "40");
    });

    $("#youtube").mouseout(function () {
        $(this).css("width", "30");
    });

    $("#whatsapp").mouseover(function () {
        $(this).css("width", "40");
    });

    $("#instagram").mouseover(function () {
        $(this).css("width", "40");
    });

    $("#instagram, #whatsapp, #youtube").mouseout(function () {
        $(this).css("width", "30");
    });

    $("#btnRegistrar").click(function (e) {
        var nombre = $("#Nombre").val();
        var email = $("#Email").val();
        var contraseña = $("#txtPassword").val();
        var contraseña1 = $("#txtPassword2").val();
        nombre.val('');
        email.val('');
        contraseña.val('');
        contraseña1.val('');

        $.ajax({
            url: '/Account/CreateUser',
            type: 'GET',
            dataType: 'Json',
            async: false,
            contentType: 'application/json; charset=utf-8',
            data: { Nombre: nombre, Email: email, Contraseña: contraseña },
            success: function (data, textStatus, jQxhr) {
                if (data) {
                    swal({
                        title: "Registrado!",
                        text: "Se registró correctamente :D!",
                        icon: "success",
                        button: "Aceptar"
                    });
                }
                else {
                    swal({
                        title: "No Registrado!",
                        text: "No se registró, por favor ingresar los datos requeridos :C!",
                        icon: "error",
                        button: "Aceptar"

                    });
                }
                $('#ModalRegistrarme').modal('hide');
            },
            error: function (jqXhr, textStatus, errorThrown) {
                swal({
                    title: "Error!",
                    text: "Por favor completar todo los campos requeridos",
                    icon: "error",
                    button: "Aceptar"
                });
            }
        });

    });

});

function mostrarPassword() {
    var cambio = document.getElementById("txtPassword");
    var cambio2 = document.getElementById("txtPassword2");
    if (cambio.type === "password" & cambio.type === "password") {
        cambio.type = "text";
        cambio2.type = "text";
        $('.icon').removeClass('fa fa-eye-slash').addClass('fa fa-eye');
    } else {
        cambio.type = "password";
        cambio2.type = "password";
        $('.icon').removeClass('fa fa-eye').addClass('fa fa-eye-slash');
    }
}