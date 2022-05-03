
$(document).ready(function () {
    $("#boton").click(function () {
        //consumo xml
        $.get("xml/HOSPITAL_ATRIBUTOS.xml", function (data) {
            console.log("Leyendo...");
            //buscamos etiquetas
            var hospitales = $(data).find("HOSPITAL");
            var html = ""
            hospitales.each(function () {
                //html += "<tr>";
                var nombre = $(this).attr("NOMBRE");
                var dir = $(this).attr("DIRECCION");
                var tlf = $(this).attr("TELEFONO");
                var camas = $(this).attr("NUM_CAMA");

                //CON HTML DIRECTAMENTE
               /* html += "<td>" + nombre + "</td>";
                html += "<td>" + dir + "</td>";
                html += "<td>" + tlf + "</td>";
                html += "<td>" + camas + "</td>";*/

                //CON JQUERY
                var tr = $("<tr>")
                var tn = $("<td>", { text: nombre });
                var tdir = $("<td>", { text: dir });
                var ttlf = $("<td>", { text: tlf });
                var tcam = $("<td>", { text: camas });

                tr.append(tn);
                tr.append(tdir);
                tr.append(ttlf);
                tr.append(tcam);
                $("#tabla").append(tr);
                
            });

            //CON HTML DIRECTAMENTE
            /*html += "</tr>";
            $("#tabla").append(html);*/
        });
    });
});