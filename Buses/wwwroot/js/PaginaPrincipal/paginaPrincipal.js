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

//$("#botonIniciarSesion").click(function (e) {
//    var txtCorreo = $("#txtCorreo").val();
//    $.ajax({
//        url: '/Account/Login',
//        type: 'GET',
//        dataType: 'Json',
//        contentType: 'application/json; charset=utf-8',
//        data: { correo: txtCorreo },
//        success: function (data) {

//        },
//        error: function (jqXhr, textStatus, errorThrown) {
//            console.log(errorThrown);
//        }
//    });
//});

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

