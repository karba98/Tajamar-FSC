
$(document).ready(function () {
    $("#boton").click(function () {
        //consumo xml
        $.get("xml/empleados.xml", function (data) {
            console.log("Leyendo...");
            //buscamos etiquetas
            var apellidos = $(data).find("APELLIDO");
            var html = "<ul>"
            apellidos.each(function () {
                var ape = $(this).text();
                html+="<li>"+ape+"</li>"
            });

            html += "</ul>"
            $("#capa").html(html);
        });
    });
});