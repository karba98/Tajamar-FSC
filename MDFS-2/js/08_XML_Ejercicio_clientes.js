
$(document).ready(function () {

    $.get("xml/ClientesXML.xml", function (data) {
        console.log("Leyendo...");
        var clientes = $(data).find("CLIENTE");;
        clientes.each(function () {
            var op = $("<option>", {
                "text": $(this).find("NOMBRE").first().text(),
                "data-id": $(this).attr("IDCLIENTE")
            });
            op.appendTo($("#clientes"));
        });
        var selector = $("#clientes");
        selector.change(function () {
            $("#result").empty();
            var ids = $("#clientes option:selected").data("id");
            console.log(ids);
            var filtro = "CLIENTE[IDCLIENTE=" + ids + "]";
            var nombre = $(data).find(filtro).find("NOMBRE").text();
            var dir = $(data).find(filtro).find("DIRECCION").text();
            var cp = $(data).find(filtro).find("CODIGOPOSTAL").text();
            var email = $(data).find(filtro).find("EMAIL").text();
            var web = $(data).find(filtro).find("PAGINAWEB").text();
            var imgsrc = $(data).find(filtro).find("IMAGENCLIENTE").text();

            var caja = $("#result");
            $("<img>", {
                "src": imgsrc,
                "onerror": "this.onerror=null;this.src=\"red.jpg\""
            }).appendTo(caja);
            $("<h1>", {
                "class": "name",
                "text": nombre
            }).appendTo(caja);
            $("<h2>", {
                "text": "Dir.: " + dir+", "+cp
            }).appendTo(caja);
            caja.append($("<hr>"));
            $("<a>", {
                "text": email,
                "href": "mailto:" + email
            }).appendTo(caja);
            caja.append($("<br/>"));
            $("<a>", {
                "text": web,
                "href": web
            }).appendTo(caja);
           
            
        });
           
        
    });
   
});