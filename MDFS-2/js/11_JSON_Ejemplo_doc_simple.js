/*
* EJEMPLO LECTURA JSON
*/
$(document).ready(function () {
    $("#get").click(function () {
        $("#res").empty();
        console.log("clicked");
        $.getJSON("json/tareas.json", function (data) {
            //Objeto simple
            var title = $("<h1>", {
                "text":"GET"
            });
            $("#res").append(title);
            $.each(data, function (key, value) {
                var h = $("<h2>", {
                    "text": "Clave: " + key + " Valor: " + value

                });
                $("#res").append(h);
            });
        });
    });

    $("#ajax").click(function () {
        $("#res").empty();
        $.ajax({
            "url": "json/tareas.json",
            "method": "GET",
            "success": function (data) {
                var title = $("<h1>", {
                    "text": "AJAX"
                });
                $("#res").append(title);
                $.each(data,function (key, value) {
                    var h = $("<h2>", {
                        "text": "Clave: " + key + " Valor: " + value

                    });
                    $("#res").append(h);
                });
            },
            "error": function () {
                var title = $("<h1>", {
                    "text": "ERROR"
                });
                $("#res").append(title);
            }
        });
    });
});