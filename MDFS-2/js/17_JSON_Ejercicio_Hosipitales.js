

var url = "https://apicrudhospital.azurewebsites.net/webresources/hospitales"
$(document).ready(function () {
    loadHos();
    
    $("#refresh").click(function () {
        $("#data").empty();
        $("#numero").val("");
        $("#numero").prop("readonly", false);

        $("#nombre").val("");
        $("#localidad").val("");
        $("#tlf").val("");
        $("#camas").val("");

        loadHos();
    });
});

$("#insertar").click(function () {
    var numero = $("#numero").val();
    var nombre = $("#nombre").val();
    var direccion = $("#localidad").val();
    var telefono = $("#tlf").val();
    var camas = $("#camas").val();

    var newHospital = new Object();
    newHospital.idhospital = parseInt(numero);
    newHospital.nombre = nombre;
    newHospital.direccion = direccion;
    newHospital.telefono = telefono;
    newHospital.camas = camas;

    var json = JSON.stringify(newHospital);
    $.ajax({
        "url": url + "/post",
        "type": "POST",
        "data": json,
        "contentType": "application/json",
        "success": function (data) {
            alert("Hospital creado con exito");
            loadHos();
        },
        "error": function () {
            alert("Errro al crear");
        }
    });
});
function loadHos() {
    $("#data").empty();
    $.getJSON(url, function (data) {
        $.each(data, function (index, hospital) {
            console.log(hospital);
            var hos = $("<tr>");
            var num = $("<td>", {
                text: hospital.idhospital
            });
            var nom = $("<td>", {
                text: hospital.nombre
            });
            var loc = $("<td>", {
                text: hospital.direccion
            });
            var tlf = $("<td>", {
                text: hospital.telefono
            });
            var camas = $("<td>", {
                text: hospital.camas
            });
            var opt = $("<td>", {
                "style":"padding:0px"
            });

                var borrar = $("<button>", {
                    "text": "x",
                    "data-id": hospital.numero,
                    "type":"button",
                    "style":"background-color: #f44336;color:white;border:0px"
                });
                borrar.click(function () {
                    deleteH(hospital.idhospital);
                });
                opt.append(borrar);
                var modi = $("<button>", {
                    "text": "U",
                    "data-id": hospital.numero,
                    "type": "button",
                    "style": "background-color: green ;color:white;border:0px"
                });
                modi.click(function () {
                    modificar(hospital.idhospital,hospital.nombre,hospital.direccion,hospital.telefono,hospital.camas);
                });
                opt.append(modi);

            hos.append(num);
            hos.append(nom);
            hos.append(loc);
            hos.append(tlf);
            hos.append(camas);
            hos.append(opt);
            $("#tabla").append(hos);

        });
    });

}
function deleteH(idH) {

    var respuesta = confirm("Confirme el borrado.")

    if (respuesta) {
        var request = "/delete/" + idH;
        $.ajax({
            "url": url + request,
            "type": "DELETE",
            "success": function (data) {
                loadHos();
            }
        });
    }
    else window.history.go(-1); 

    
}
function modificar(idH,n,d,t,c) {
    console.log(idH);
    var numero = $("#numero");
    var nombre = $("#nombre");
    var direccion = $("#localidad");
    var telefono = $("#tlf");
    var camas = $("#camas");
    numero.val(idH);
    numero.prop("readonly", true);
    nombre.val(n);
    direccion.val(d);
    telefono.val(t);
    camas.val(c);

}
$("#modificar").click(function () {
    var respuesta = confirm("¿Procedemos a modificar " + $("#nombre").val() + "?.")
    if (respuesta) {
        var numero = $("#numero").val();
        var nombre = $("#nombre").val();
        var direccion = $("#localidad").val();
        var telefono = $("#tlf").val();
        var camas = $("#camas").val();

        var newHospital = new Object();
        newHospital.idhospital = parseInt(numero);
        newHospital.nombre = nombre;
        newHospital.direccion = direccion;
        newHospital.telefono = telefono;
        newHospital.camas = camas;

        var json = JSON.stringify(newHospital);
        $.ajax({
            "url": url + "/put",
            "type": "PUT",
            "data": json,
            "contentType": "application/json",
            "success": function (data) {
                alert("Hospital modificado con exito");
                loadHos();
            },
            "error": function () {
                alert("Errro al modificar");
            }
        });
    }
    else window.history.go(-1);
});

