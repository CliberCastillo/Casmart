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
                var suma = valor + "," + $(this).text();
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
                    var suma = valor + "," + $(this).text();
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
                    var suma = valor + "," + $(this).text();
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
            if (data) {
                location.reload();
            }
            else {
                swal({
                    title: "Error!",
                    text: "No se logueo, por favor ingresar los datos correctos y/o crear tu cuenta :C!",
                    icon: "error",
                    button: "Aceptar"
                });
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