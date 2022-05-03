
$(document).ready(function () {
    $("#botonAP").click(function () {
        $("#result").empty();
        $.get("xml/empleados.xml", function (data) {
            console.log("Leyendo...");
            var apellido = $("#cajaAP").val().toUpperCase();
            var filtro = "APELLIDO:contains(\"" + apellido + "\")";
            var empleados = $(data).find(filtro);
            console.log(empleados);
            if (empleados.length == 0) {
                $("#result").append($("<h1>", { "text": "No se encontró nada" }));
            } else {
                empleados.each(function () {
                    var ape = $(this).text();
                    $("#result").append($("<h2>", {
                        "text": "Apellido: " + ape
                    }));
                });
                
               
            }
           
        });
    });
    $("#botonCH").click(function () {
        //consumo xml
        $("#result").empty();
        $.get("xml/HOSPITAL_ATRIBUTOS.xml", function (data) {
            console.log("Leyendo...");
            var codigo = $("#cajaCH").val();
            //FILTRO SELECTOR
            var filtro = "HOSPITAL[HOSPITAL_COD=\"" + codigo + "\"]";
            var hospitales = $(data).find(filtro);
            if (hospitales.length == 0) {
                $("#result").append($("<h1>", { "text": "No se encontró nada" }));
            } else {
                var hospital = hospitales.first();
                var nom = hospital.attr("NOMBRE");
                var dir = hospital.attr("DIRECCION");
                var tlf = hospital.attr("TELEFONO");
                var camas =  hospital.attr("NUM_CAMA");
                $("#result").append($("<h2>", {
                    "text": "Nombre: " + nom
                }));
                $("#result").append($("<h2>", {
                    "text":"Dir: " + dir  
                }));
                $("#result").append($("<h2>", {
                    "text": "Tlf: " + tlf
                }));
                $("#result").append($("<h2>", {
                    "text": "Nº Camas: " + camas
                }));

            }

        });
    });
});