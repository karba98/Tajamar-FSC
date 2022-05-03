/*
 * 
 * author:Raúl castro
 * 
 * 
 * */

/*
 * La URL del servicio Azure es la siguiente:
https://apichampions.azurewebsites.net
Tendremos dos métodos GET:
1)	Devolverá la descripción de los equipos de la final
https://apichampions.azurewebsites.net/api/Equipos
2)	Devolverá las apuestas realizadas
https://apichampions.azurewebsites.net/api/Apuestas
Existe un método POST para insertar apuestas alojado en:
https://apichampions.azurewebsites.net/api/Apuestas
También tenemos un método para eliminar Apuestas por su ID:
https://apichampions.azurewebsites.net/api/Apuestas/88

 * 
 * */
var url = "https://apichampions.azurewebsites.net";
var urlPOST = "https://apichampions.azurewebsites.net/api/Apuestas";
var urlPUT = "https://apichampions.azurewebsites.net/api/Apuestas";
var urlDEL = "https://apichampions.azurewebsites.net/api/Apuestas/";

$(document).ready(function () {

    //APARTADO APUESTAS
    $("#apuestas").click(function () {
        loadApuestas();
    });


    //GET DE EQUIPOS ENLAZADO AL DROPDOWN MENU
    $.getJSON(url + "/api/Equipos", function (data) {
        console.log(data);
        $.each(data, function (index, equipo) {
            var dropdown = $("#equiposDD");
            var div = $("<div>");
            
            var text = $("<a>",{
                "text": equipo.nombre,
                "class": "dropdown-item",
                "href":"#"
            });
            div.append(text);
            dropdown.append(div);

            div.click(function () {
                $("#caja").empty();
                $("#textoH").text("Soccer Teams");
                var foto = $("<img>", {
                    "src": equipo.imagen
                });
                var descipcion = $("<p>", {
                    "text": equipo.descripcion
                });
                var champions = $("<h3>", {
                    "text":"Campions: "+equipo.champions
                });
                $("#caja").append(foto);
                $("#caja").append(champions);
                $("#caja").append(descipcion);

                var jugadores = $("<button>", {
                    "text":"Players"
                });
                $("#caja").append(jugadores);

                jugadores.click(function () {
                    var modal = document.getElementById("myModal");
                    var span = document.getElementsByClassName("close")[0];
                    modal.style.display = "block";
                    $.getJSON(url + "/api/Jugadores/JugadoresEquipo/" + equipo.idEquipo,
                        function (data) {
                            var popup = $("#popup");

                            var tabla = $("<table>", { "id": "tabla" });
                            var thead = $("<thead>");
                            var tr = $("<tr>");
                            var img = $("<th>");
                            var nombre = $("<th>", { "text": "NOMBRE" });
                            var posicion = $("<th>", { "text": "POSICION" });
                            var fn = $("<th>", { "text": "FECHA-NAC" });
                            var pais = $("<th>", { "text": "PAIS" });

                            tr.append(img);
                            tr.append(nombre);
                            tr.append(posicion);
                            tr.append(fn);
                            tr.append(pais);
                            thead.append(tr);
                            tabla.append(thead);
                            $.each(data, function (index, jugador) {
                                

                                var tbody = $("<tbody>");
                                var tr2 = $("<tr>");

                                var img2 = $("<td>");
                                var imagenj = $("<img>", {
                                    "src":jugador.imagen
                                });
                                img2.append(imagenj);
                                var nombre2 = $("<td>", { "text": jugador.nombre });
                                var posicion2 = $("<td>", { "text": jugador.posicion });
                                var fn2 = $("<td>", { "text": jugador.fechaNacimiento });
                                var pais2 = $("<td>", { "text": jugador.pais });

                                tr2.append(img2);
                                tr2.append(nombre2);
                                tr2.append(posicion2);
                                tr2.append(fn2);
                                tr2.append(pais2);
                                tbody.append(tr2);
                                tabla.append(tbody);
                                popup.append(tabla);
                                
                            });
                        });
                    //METO LOS JUGADORES
                    span.onclick = function () {
                        modal.style.display = "none";
                        $("#popup").empty();
                       
                    }
                    window.onclick = function (event) {
                        if (event.target == modal) {
                            $("#popup").empty();
                            modal.style.display = "none";
                        }
                    }
                });

               
            });
           
           

        });
    });
});
//CARGA LAS APUESTAS
function loadApuestas() {
    
    $("#textoH").text("Bets");
    var tabla = $("<table>", { "id": "tabla" });
    var thead = $("<thead>");
    var tr = $("<tr>");
    var ush = $("<th>", { "text": "USUARIO" });
    var reh = $("<th>", { "text": "RESULTADO" });
    var feh = $("<th>", { "text": "FECHA" });


    tr.append(ush);
    tr.append(reh);
    tr.append(feh);
    thead.append(tr);
    tabla.append(thead);

    var tbody = $("<tbody>");
    var trinput = $("<tr>");

    var tdusu = $("<td>");
    var inputUsu = $("<input>", {
        "type": "text",
        "id": "usuario"
    });
    tdusu.append(inputUsu);

    var tdresu = $("<td>");
    var inputResu = $("<input>", {
        "type": "text",
        "id": "resu",
    });
    tdresu.append(inputResu);

    var tdfecha = $("<td>");
    var inputFecha = $("<input>", {
        "type": "date",
        "id": "fecha"
    });
    tdfecha.append(inputFecha);

    var add = $("<td>", {
        "text": "+",
        "style": "font-size:20px"
    })

    //RECOGE DATOS DE INPUTS Y AÑADE APUESTA
    add.click(function () {
        var usuario = $("#usuario").val();
        var resu = $("#resu").val();
        var fech = $("#fecha").val();

        var existeApuesta = false;
        $.getJSON(url + "/api/Apuestas", function (data) {
            $.each(data, function (index, apuesta) {
                console.log(usuario + "  " + apuesta.usuario);
                if (apuesta.usuario == usuario) {
                    console.log("La apuesta existe");
                    existeApuesta = true;
                    modApuesta(apuesta.idApuesta, usuario, resu, fech);
                    $("#caja").empty();
                    
                }
                
            });
            console.log("existe: " + existeApuesta);
        });
        
        if (!existeapuesta) {
    
            var expresionR = /[0-99]-[0-99]/;
            //var expresionF = /[1-31]-[1-12]-[1000-9000]/;
            console.log("res" + expresionR.test(resu));
            //console.log("fech" + expresionF.test(fech));//DA SIEMPRE FALSE
            //VERIFICA CON PATTERN SI SON VLAIDO SLOS DATOS
            if (expresionR.test(resu) == true) {
                addApuesta(usuario, resu, fech);
            } else {
                alert("Hay algo mal en la apuesta");
            }
        }
        
        
    });

    trinput.append(tdusu);
    trinput.append(tdresu);
    trinput.append(tdfecha);
    trinput.append(add);
    tbody.append(trinput);

    $("#caja").empty();
    $.getJSON(url + "/api/Apuestas", function (data) {
        $.each(data, function (index, apuesta) {
            var usuario = $("<td>", { "text": apuesta.usuario });
            var resultado = $("<td>", {
                "text": "Real Madrid "
                    + apuesta.resultado +
                    " Atletico de Madrid"
            });
            var fecha = $("<td>", { "text": apuesta.fecha });
            var options = $("<td>");
            var tr = $("<tr>");
            tr.append(usuario);
            tr.append(resultado);
            tr.append(fecha);

            var borrar = $("<button>", {
                "text": "x",
                "data-id": apuesta.idApuesta,
                "type": "button",
                "style": "background-color: #f44336;color:white;border:0px"
            });
            borrar.click(function () {
                deleteA(apuesta.idApuesta);
            });

            options.append(borrar);
            tr.append(options);

            tbody.append(tr);
        });
        tabla.append(tbody);
        $("#caja").append(tabla);

    });
}
//eLIMINA APUESTA SELECCIONADA
function deleteA(id) {
    $.ajax({
        "url": urlDEL+id,
        "type": "DELETE",
        "success": function (data) {
            alert("Apuesta borrada con exito");
            loadApuestas();
        },
        "error": function () {
            alert("Errro al borrar");
        }
    });
}
//AÑADA LA APUESTA ENVIANDO UN OBJETO JSON
function addApuesta(usuario, resu, fech) {
    var newApuesta = new Object();
    newApuesta.idApuesta = 0;
    newApuesta.usuario = usuario;
    newApuesta.resultado = resu;
    newApuesta.fecha = fech;

    var json = JSON.stringify(newApuesta);
    $.ajax({
        "url": urlPOST,
        "type": "POST",
        "data": json,
        "contentType": "application/json",
        "success": function (data) {
            alert("Apuesta creada con exito");
            loadApuestas();
        },
        "error": function () {
            alert("Errro al crear");
        }
    });
}
function modApuesta(id,usuario, resu, fech) {
    var newApuesta = new Object();
    newApuesta.idApuesta = id;
    newApuesta.usuario = usuario;
    newApuesta.resultado = resu;
    newApuesta.fecha = fech;
    console.log("Modificando apuesta");
    var json = JSON.stringify(newApuesta);
    $.ajax({
        "url": urlPUT,
        "type": "PUT",
        "data": json,
        "contentType": "application/json",
        "success": function (data) {
            alert("Apuesta modificada con exito");
            loadApuestas();
        },
        "error": function () {
            alert("Errro al modificar");
        }
    });
}