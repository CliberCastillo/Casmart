
$("#botonIniciarSesion").click(function (e) {
    var txtCorreo = $("#txtCorreo").val();
    alert(txtCorreo);
    $.ajax({
        url: '/PaginaPrincipal/Login',
        type: 'GET',
        dataType: 'Json',
        contentType: 'application/json; charset=utf-8',
        data: { correo: txtCorreo },
        success: function (data) {

        },
        error: function (jqXhr, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });

});