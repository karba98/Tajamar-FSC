var url = "https://apidepartamentoscrudrc.azurewebsites.net/";
function getTablaDepartamentosAsync(callback) {
    var request = "api/departamentos";
    $.ajax({
        url: url + request,
        type: "GET",
        success: function (data) {
            var html = "";
            $.each(data, function (index, dept) {
                html += "<tr>";
                html += "<td>" + dept.id + "</td>"
                html += "<td>" + dept.nombre + "</td>"
                html += "<td>" + dept.localidad + "</td>"
                html += "</tr>";
            });
            callback(html);


        }
    });
}
function convertirDeptJson (id, nombre, localidad) {
    var departamento = new Object();
    
    departamento.nombre = nombre;
    departamento.localidad = localidad;
    departamento.id = id;
    var json = JSON.stringify(departamento);
    return json;
}
function eliminarDepartamentoAsync(id,callback) {
    var request = "api/departamentos/" + id;
    $.ajax({
        url: url + request,
        type: "DELETE",
        success: function () {
            cargarDepartamentos();
        }
    });
    return callback();
    
}
//MEJOR DIVIDIR EN DOS (INSERTAR Y MODIFICAR)
function AtackDepartamentoAsync(json,method,callback) {
    var request = "api/departamentos";
    $.ajax({
        url: url + request,
        type: method,
        data: json,
        contentType: "application/json",
        success: function () {
            cargarDepartamentos();
        }
    });
    return callback();
}