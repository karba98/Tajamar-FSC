/*
 * 
 * GET JSON From URL
 * 
 * */
var urlD = "https://apicruddepartamentoscore.azurewebsites.net/api/departamentos";
var urlE = "https://apiempleadosspgs.azurewebsites.net/api/Empleados";
$(document).ready(function () {
    loadDep();
});

function loadDep() {

    $.getJSON(urlD, function (data) {
        $.each(data, function (index, dep) {

            /*var depart = $("<tr>", {
                "click": function () {
                    loadEmp(dep.numero);
                }
            });   */
            var depart = $("<tr>");
            depart.click(function () {
                loadEmp(dep.numero);
            });
            var nom = $("<td>", {text: dep.nombre});
            var loc = $("<td>", {text: dep.localidad});
            depart.append(nom);
            depart.append(loc);
            $("#tabla").append(depart);
        });
        
    });


   
    //setTimeout("loadDep()", 800);
}
function loadEmp(id) {
    var res = "";
    console.log(id);

    $("#tablaEmp").empty();
    var tabla = $("<table>", { "id":"tabla"});
    var thead = $("<thead>");
    var tr = $("<tr>");
    var idh = $("<th>", { "text": "ID" });
    var aph = $("<th>", { "text": "Apellido" });
    var ofh = $("<th>", { "text": "Oficio" });
    var salh = $("<th>", { "text": "Salario" });
    tr.append(idh);
    tr.append(aph);
    tr.append(ofh);
    tr.append(salh);
    thead.append(tr);
    tabla.append(thead);
    var tbody = $("<tbody>");
    $.getJSON(urlE + "/EmpleadosDepartamento/" + id, function (data) {
        $.each(data, function (index, emp) {
            var trb = $("<tr>");
            var id = $("<td>", { "text": emp.departamento+emp.idEmpleado });
            var ap = $("<td>", { "text": emp.apellido });
            var of = $("<td>", { "text": emp.oficio });
            var sa = $("<td>", { "text": emp.salario +"€"});
            trb.append(id);
            trb.append(ap);
            trb.append(of);
            trb.append(sa);
            tbody.append(trb);
            res = emp;
        });

        if (res != "") {
            tabla.append(tbody);
            $("#tablaEmp").append(tabla);
        }
        
    });
}