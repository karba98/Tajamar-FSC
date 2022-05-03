/*
* EJEMPLO LECTURA JSON
*/
$(document).ready(function () {
    $("#res").empty();
    $.ajax({
        "url": "json/jugadores.json",
        "method": "GET",
        "dataType" : "json",
        "success": function (data) {
            $.each(data.jugadores, function (index, value) {
                console.log("cargando "+value.nombre);
                var op = $("<option>", {
                    "text": value.nombre,
                    "value": index
                });
                $("#jugadores").append(op);
            });
            $("#jugadores").change(function () {
                $("#res").empty();
                //$(this).prop("selectedIndex") --> devuelve el indice seleccionado
                //$("select option:selected").val()
                $.each(data.jugadores, function (index, value) {
                    if (index == $("select option:selected").val()) {
                        var nombre = $("<h1>", {
                            "text": value.nombre
                        });
                        var num = $("<h2>", {
                            "text": "Numero: " + value.numero
                        });
                        var pos = $("<h2>", {
                            "text": "Poscicion: " + value.posicion
                        });
                        var edad = $("<h2>", {
                            "text": "Edad: " + value.edad
                        });
                        var img = $("<img>", {
                            "src": value.imagen,
                            "onerror": "this.onerror=null;this.src=\"red.jpg\""
                        });
                        $("#res").append(img);
                        $("#res").append(nombre);
                        $("#res").append(num);
                        $("#res").append(pos);
                        $("#res").append(edad);
                    }
                });
            });
        }
    });
    
});