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