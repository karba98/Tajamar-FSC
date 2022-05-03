/*
 * 
 * GET JSON From URL
 * 
 * */
var url = "https://apicruddepartamentoscore.azurewebsites.net"
$(document).ready(function () {

    $("#refresh").click(function () {
        loadDep();
    });

    loadDep();
    $("#borrar").click(function () {
        var numero = $("#numero").val();
        var request = "/api/Departamentos/" + numero;
        $.ajax({
            "url": url + request,
            "type": "DELETE",
            "success": function (data) {
                alert("Eliminado Departamento: " + numero);
                loadDep();
            }
        });
    });
    $("#modificar").click(function () {
        var numero = $("#numero").val();
        var nombre = $("#nombre").val();
        var localidad = $("#localidad").val();
        var request = "/api/Departamentos/";

        //CREAMOS OBJETO
        var newDep = new Object();
        newDep.numero = parseInt(numero);
        newDep.nombre = nombre;
        newDep.localidad = localidad;

        //LO PASAMOS A JSON
        var json = JSON.stringify(newDep);
        $.ajax({
            "url": url + request,
            "type": "PUT",
            //ENVIAMOS EL JSON
            "data": json,
            "contentType": "application/json",
            "success": function (data) {
                alert("Objeto modificado con exito");
                loadDep();
            },
            "error": function () {
                alert("Errro al modificar");
            }
        });
    });

  
    $("#insertar").click(function () {
        var numero = $("#numero").val();
        var nombre = $("#nombre").val();
        var localidad = $("#localidad").val();
        var request = "/api/Departamentos/";

        //CREAMOS OBJETO
        var newDep = new Object();
        newDep.numero = parseInt(numero);
        newDep.nombre = nombre;
        newDep.localidad = localidad;

        //LO PASAMOS A JSON
        var json = JSON.stringify(newDep);
        $.ajax({
            "url": url + request,
            "type": "POST",
            //ENVIAMOS EL JSON
            "data": json,
            "contentType": "application/json",
            "success": function (data) {
                alert("Objeto enviado con exito");
                loadDep();
            },
            "error": function () {
                alert("Errro al insertar");
            }
        });
    });
});

function loadDep() {
    
    var request = "/api/Departamentos";
    $.getJSON(url + request, function (data) {
        $.each(data, function (index, dep) {

            var depart = $("<tr>");
            var num = $("<td>", {
                text: dep.numero
            });
            var nom = $("<td>", {
                text: dep.nombre
            });
            var loc = $("<td>", {
                text: dep.localidad
            });
            depart.append(num);
            depart.append(nom);
            depart.append(loc);
            $("#tabla").append(depart);

        });
        console.log($("#tabla").html());
    });

    //setTimeout("loadDep()", 800);
}