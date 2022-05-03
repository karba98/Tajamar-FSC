$(document).ready(function () {
    $("#caja1").attr("type", "number");
    console.log("attr cambiado");
    $("#caja2").attr("type", "number");
    console.log("attr cambiado");
    $("#sumar").click(function () {
        //capturamos value de caja1 y caja2
        var n1 = $("#caja1").val();
        var n2 = $("#caja2").val();
        var suma = parseInt(n1) + parseInt(n2);
        $("#resultado").text(suma);
        //$("#resultado").css("color","red");
        $("#resultado").css({ "color": "red" });//OTRA FORMA DE MODIFICAR CSS
    });
});