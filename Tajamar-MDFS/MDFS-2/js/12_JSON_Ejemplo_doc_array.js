/*
* EJEMPLO LECTURA JSON
*/
$(document).ready(function () {

    $("#get").click(function () {
        $("#res").empty();
        $.getJSON("json/clientessimples.json", function (data) {
            //en el each, accedemos como el nombre de la jet del array
            //data.CLIENTES
            /*
             {
                "clientes":
                [
                    "nombre":"juan",
                    "nombre":"pepe"
                ]
                
             }
             */
            $.each(data.clientes, function (index,obj) {
                var h = $("<h2>", {
                    "text": "Indice: " + index + " Nombre: " + obj.nombre
                });
                $("#res").append(h);
            });
        });
    });
});