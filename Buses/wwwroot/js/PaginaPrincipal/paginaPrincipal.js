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

$("#btnRegistrarme").click(function (e) {
    var nombre = $("#Nombre").val();
    var email = $("#Email").val();
    var contraseña = $("#txtPassword").val();
    var contraseña1 = $("#txtPassword2").val();
    $("#Nombre").val('');
    $("#Email").val('');
    $("#txtPassword").val('');
    $("#txtPassword2").val('');

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
                    title: "Satisfactorio!",
                    text: "Se registró correctamente :D!",
                    icon: "success",
                    button: "Aceptar"
                });
            }
            else {
                swal({
                    title: "Error!",
                    text: "No se registró, por favor ingresar los datos requeridos :C!",
                    icon: "error",
                    button: "Aceptar"
                });
            }
            $('#btnRegistrarme').modal('hide');
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

function validacion() {
    var origen = $("#cboRutaOrigen option:selected").text();
    var destino = $("#cboRutaDestino option:selected").text();
    if (origen === "- Origen -") {
        swal("Error!", "Por Favor seleccionar los campos requeridos")
        return false;
    }
    else if (destino === "- Destino -") {
        return false;
    }
    return true;
}
//$(document).on('change', '#cboRutaOrigen', function (event) {
//    alert(nombres);
//});