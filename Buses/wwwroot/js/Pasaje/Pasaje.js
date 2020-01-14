$("#asiento10").click(function () {
    swal("Asiento numero" + $(this).text(), "¿Seguro que desea agregarlos?", "info", {
        buttons: {
            cancelar: {
                text: "Cancelar"
            },
            agregar: {
                text: "Agregar"
            }
        }
    }).then((value) => {
        switch (value) {
            case "cancelar":
                swal("No agregado", "", "warning");
                break;

            case "agregar":
                swal("Agreado", "El asiento fue agregado correctamente", "success");
                var valor = $("#asientosSeleccionados").text();
                var suma = valor + $(this).text();
                $("#asientosSeleccionados").html(suma);

                var precio = document.getElementById("tipoServicio");
                var demoValue2 = String(precio.innerHTML);

                var demo = document.getElementById("precio");
                var demoValue = parseInt(demo.innerHTML);
                var puntos;
                if (demoValue2 === "Oferta") {

                    puntos = demoValue + 20;
                }
                else {
                    puntos = demoValue + 50;
                }

                demo.innerHTML = puntos;
                $(this).prop('disabled', true);
                break;
        }
    });
});
for (var i = 1; i <= 9; i++) {
    var numero = i;
    $("#asiento0" + i).click(function () {
        swal("Asiento numero" + $(this).text(), "¿Seguro que desea agregarlos?", "info", {
            buttons: {
                cancelar: {
                    text: "Cancelar"
                },
                agregar: {
                    text: "Agregar"
                }
            }
        }).then((value) => {
            switch (value) {
                case "cancelar":
                    swal("No agregado", "", "warning");
                    break;

                case "agregar":
                    swal("Agreado", "El asiento fue agregado correctamente", "success");
                    var valor = $("#asientosSeleccionados").text();
                    var suma = valor + $(this).text();
                    $("#asientosSeleccionados").html(suma);

                    var precio = document.getElementById("tipoServicio");
                    var demoValue2 = String(precio.innerHTML);

                    var demo = document.getElementById("precio");
                    var demoValue = parseInt(demo.innerHTML);
                    var puntos;
                    if (demoValue2 === "Oferta") {

                        puntos = demoValue + 20;
                    }
                    else {
                        puntos = demoValue + 50;
                    }

                    demo.innerHTML = puntos;
                    $(this).prop('disabled', true);
                    break;
            }
        });
    });
}
for (var j = 11; j <= 40; j++) {
    var numero2 = j;
    $("#asiento" + j).click(function () {
        swal("Asiento numero" + $(this).text(), "¿Seguro que desea agregarlos?", "info", {
            buttons: {
                cancelar: {
                    text: "Cancelar"
                },
                agregar: {
                    text: "Agregar"
                }
            }
        }).then((value) => {
            switch (value) {
                case "cancelar":
                    swal("No agregado", "", "warning");
                    break;

                case "agregar":
                    swal("Agreado", "El asiento fue agregado correctamente", "success");
                    var valor = $("#asientosSeleccionados").text();
                    var suma = valor + $(this).text();
                    $("#asientosSeleccionados").text(suma);

                    var precio = document.getElementById("tipoServicio");
                    var demoValue2 = String(precio.innerHTML);

                    var demo = document.getElementById("precio");
                    var demoValue = parseInt(demo.innerHTML);
                    var puntos;
                    if (demoValue2 === "Oferta") {

                        puntos = demoValue + 20;
                    }
                    else {
                        puntos = demoValue + 50;
                    }

                    demo.innerHTML = puntos;
                    $(this).prop('disabled', true);

                    break;
            }
        });
    });
}

$("#botonIniciarSesion2").click(function (e) {
    var email = $("#Email2").val();
    var password = $("#Password2").val();

    $.ajax({
        url: '/Account/LoginAjax',
        type: 'GET',
        dataType: 'Json',
        async: false,
        contentType: 'application/json; charset=utf-8',
        data: { Email: email, Password: password, Remenber: true },
        success: function (data, textStatus, jQxhr) {
            if (data === "Registrado") {
                location.reload();
            }
            else {
                swal({
                    title: "Error!",
                    text: "No se logueo, por favor ingresar los datos correctos y/o crear tu cuenta :C!",
                    icon: "error",
                    button: "Aceptar"
                });
                $("#Email2").val("");
                $("#Password2").val("");
            }
            $('#btnRegistrarme').modal('hide');
        },
        error: function (jqXhr, textStatus, errorThrown) {
            swal({
                title: "Error!",
                text: "No se logueo, por favor ingresar los datos correctos y/o crear tu cuenta :C!",
                icon: "error",
                button: "Aceptar"
            });
        }
    });
});
$("#btnGuardarPasajero").click(function (e) {
    var Nombre = $("#txtNombre").val();
    var ApellidoPaterno = $("#txtApellidoPaterno").val();
    var ApellidoMaterno = $("#txtApellidoMaterno").val();
    var Telefono = $("#txtTelefono").val();
    var TipoDocumento = $("#cboTipoDocumento").val();
    var NumeroDocumento = $("#txtDni").val();
    var Correo = $("#txtEmail").val();
    $.ajax({
        url: '/Pasaje/RegistrarPasajero',
        type: 'GET',
        dataType: 'Json',
        async: false,
        contentType: 'application/json; charset=utf-8',
        data: {
            Nombre: Nombre, ApellidoPaterno: ApellidoPaterno, ApellidoMaterno: ApellidoMaterno,
            Telefono: Telefono, TipoDocumento: TipoDocumento, NumeroDocumento: NumeroDocumento,
            Correo: Correo
        },
        success: function (data, textStatus, jQxhr) {
            if (data === "PasajeroGuardado") {
                $("#DNIPasajeroDetalle").text(NumeroDocumento);
                swal({
                    title: "Satisfactorio!",
                    text: "Se guardaron sus datos correctamente",
                    icon: "success",
                    button: "Aceptar"
                });

                $("#txtNombre").val("");
                $("#txtApellidoPaterno").val("");
                $("#txtApellidoMaterno").val("");
                $("#txtTelefono").val("");
                $("#cboTipoDocumento").val("");
                $("#txtDni").val("");
                $("#txtEmail").val("");
                $("#btnContinuar").css("display", "none");
            }else if(data === "YaGuardado") {
                swal({
                    title: "Adventencia!",
                    text: "Usted ya esta registrado, Proceda a realizar el pago",
                    icon: "warning",
                    button: "Aceptar"
                });
                $("#txtNombre").val("");
                $("#txtApellidoPaterno").val("");
                $("#txtApellidoMaterno").val("");
                $("#txtTelefono").val("");
                $("#cboTipoDocumento").val("");
                $("#txtDni").val("");
                $("#txtEmail").val("");
                $('.bd-example-modal-lg').modal('toggle');
            }
            else {
                swal({
                    title: "Error!",
                    text: "No se guardaron sus datos, por favor volver a intentar :C!",
                    icon: "error",
                    button: "Aceptar"
                });
                $("#txtNombre").val("");
                $("#txtApellidoPaterno").val("");
                $("#txtApellidoMaterno").val("");
                $("#txtTelefono").val("");
                $("#cboTipoDocumento").val("");
                $("#txtDni").val("");
                $("#txtEmail").val("");
                $('.bd-example-modal-lg').modal('toggle');
            }
        },
        error: function (jqXhr, textStatus, errorThrown) {
            swal({
                title: "Error!",
                text: "No se guardaron sus datos, por favor volver a intentar: C!",
                icon: "error",
                button: "Aceptar"
            });
            $("#txtNombre").val("");
            $("#txtApellidoPaterno").val("");
            $("#txtApellidoMaterno").val("");
            $("#txtTelefono").val("");
            $("#cboTipoDocumento").val("");
            $("#txtDni").val("");
            $("#txtEmail").val("");
            $('.bd-example-modal-lg').modal('toggle');
        }
    });
});

$("#PagoPasaje").click(function (e) {

    var DNIPasajero = $("#DNIPasajeroDetalle").text();
    var fechaViaje = $("#fechaViaje").text();
    var tipoServicio = $("#tipoServicio").text();
    var numeroAsiento = $("#asientosSeleccionados").text();
    var precioPasaje = $("#precio").text();
    var idItinerario = $("#idItinerario").text();

    $.ajax({
        url: '/Pasaje/RegistrarPasaje',
        type: 'GET',
        dataType: 'Json',
        async: false,
        contentType: 'application/json; charset=utf-8',
        data: {
            dniPasajero: DNIPasajero, fechaViaje: fechaViaje, numeroAsiento: numeroAsiento,
            precioPasaje: precioPasaje, IdItinerario: idItinerario, estado: tipoServicio
        },
        success: function (data, textStatus, jQxhr) {
            if (data === "PasajeGuardado") {
                swal({
                    title: "Satisfactorio!",
                    text: "Se guardaron sus datos correctamente",
                    icon: "success",
                    button: "Aceptar"
                });
            }
            else {
                swal({
                    title: "Error!",
                    text: "No se guardaron sus datos, por favor volver a intentar :C!",
                    icon: "error",
                    button: "Aceptar"
                });
            }
        },
        error: function (jqXhr, textStatus, errorThrown) {
            swal({
                title: "Error!",
                text: "No se guardaron sus datos, por favor volver a intentar: C!",
                icon: "error",
                button: "Aceptar"
            });
        }
    });
});