// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
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

});
