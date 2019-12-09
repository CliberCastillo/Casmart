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
        e.preventDefault();
        var email = $("#Email").val();
        var contraseña = $("#Contraseña").val();
        $.ajax({
            url: '/Account/CreateUser',
            type: 'GET',
            dataType: 'Json',
            async: false,
            contentType: 'application/json; charset=utf-8',
            data: { Email: email, Contraseña: contraseña },
            success: function (data, textStatus, jQxhr) {
                swal({
                    title: "Good job!",
                    text: "You clicked the button!",
                    icon: "success",
                    button: "Aww yiss!",
                });
                alert(data);
            },
            error: function (jqXhr, textStatus, errorThrown) {
                alert(errorThrown);
            }
        });

        alert("sss");

    });

});
