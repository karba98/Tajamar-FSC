/*
 * 
 * GET JSON From URL
 * 
 * */
var urlE = "https://apipracticaempleados.azurewebsites.net";
var urldep = "https://apicruddepartamentoscore.azurewebsites.net/api/departamentos";

var arrDep = new Map();
$(document).ready(function () {
    var selector = $("#oficios");
    $.getJSON(urlE + "/api/Empleados/Oficios", function (data) {
        $.each(data, function (index, of) {
            console.log(of);
            var op = $("<option>", {
                "text": of.oficio
            });
            selector.append(op);
        });
        

    });

    $.getJSON(urldep, function (data) {
        $.each(data, function (index, dep) {
            arrDep.set(dep.numero, dep.nombre)
        });
    });
    console.log(arrDep);
});

$("#oficios").change(function () {
    var oficio = $("#oficios option:selected").val();
    console.log(oficio);
    loadEmp(oficio);
});

var arrayEmpleados = new Array();
function loadEmp(oficio) {
    arrayEmpleados = [];

    var res = "";

    $("#tablaEmp").empty();
    var tabla = $("<table>", { "id": "tabla" });
    var thead = $("<thead>");
    var tr = $("<tr>");
    var idh = $("<th>", { "text": "ID" });
    var de = $("<th>", { "text": "Departamento" });
    var aph = $("<th>", { "text": "Apellido" });
    var ofh = $("<th>", { "text": "Oficio" });

    tr.append(idh);
    tr.append(de);
    tr.append(aph);
    tr.append(ofh);
    thead.append(tr);
    tabla.append(thead);
    var tbody = $("<tbody>");
    $.getJSON(urlE + "/api/Empleados/EmpleadosOficio/" + oficio, function (data) {
        $.each(data, function (index, emp) {
            var emple = new Empleado(emp.idempleado, emp.apellido, emp.oficio, emp.salario, emp.departamento, emp.fechaalta);
            arrayEmpleados.push(emple);
            var trb = $("<tr>");
            var id = $("<td>", { "text": emple.departamento + "-" + + emp.idempleado });
            var de = $("<td>", { "text": arrDep.get(emple.departamento) });
            var ap = $("<td>", { "text": emple.apellido });
            var of = $("<td>", { "text": emple.oficio });
          
            trb.append(id);
            trb.append(de);
            trb.append(ap);
            trb.append(of);
          
            tbody.append(trb);
            res = emp;

            trb.click(function () {
                var modal = document.getElementById("myModal");
                var span = document.getElementsByClassName("close")[0];
                modal.style.display = "block";

                $("#apellidos").attr("placeholder", emple.apellido);
                $("#id").attr("placeholder", "#"+emple.idempleado);
                $("#oficio").attr("placeholder",emple.oficio);
                $("#dep").attr("placeholder", arrDep.get(emple.departamento));
                $("#fa").attr("placeholder", emple.fechaalta);
                $("#at").attr("placeholder", emple.getAniosT(emple.fechaalta)+" años");
                $("#sal").attr("placeholder", emple.salario+"€");
                $("#sala").attr("placeholder", emple.getSalarioAnual(emple.salario) + "€");
                $("#salt").attr("placeholder", emple.getSalarioTotal(
                    emple.getAniosT(emple.fechaalta),
                    parseInt(emple.getSalarioAnual(emple.salario))) + "€");

                span.onclick = function () {
                    modal.style.display = "none";
                }
                window.onclick = function (event) {
                    if (event.target == modal) {
                        modal.style.display = "none";
                    }
                }

                console.log("clicked span");
            });
        });

        if (res != "") {
            tabla.append(tbody);
            $("#tablaEmp").append(tabla);
        }

    });
    console.log(arrayEmpleados);
}
