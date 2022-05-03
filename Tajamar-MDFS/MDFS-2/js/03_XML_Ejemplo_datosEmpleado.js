
window.onload = function () {
    var xhttp = new XMLHttpRequest();
    xhttp.addEventListener("load", function () {
        console.log(this.readyState);
        console.log(this.status);
        
        if (this.readyState == 4 && this.status == 200) {
            console.log("conectado");
            var select = document.getElementById("selectemp");
            var nodosapellido = this.responseXML.getElementsByTagName("APELLIDO");
            for (var nodoap of nodosapellido) {
                var apellido = nodoap.textContent;
                var option = document.createElement("option");
                option.innerText = apellido;
                option.value = apellido;
                select.appendChild(option);
            }
        }
    });
    xhttp.open("GET", "xml/datosempleados.xml");
    xhttp.send();
}
function peticion() {
    var xhttp = new XMLHttpRequest();
    xhttp.addEventListener("load", leerEmp);
    xhttp.open("GET", "xml/datosempleados.xml");
    xhttp.send();
}
function leerEmp() {
    if (this.readyState == 4 && this.status == 200) {
        var pos = -1;
        var select = document.getElementById("selectemp");
        //sacamos la posicion del elemento seleccionado
        for (var i = 0; i < select.options.length; i++) {
            var opt = select.options[i];
            if (opt.selected == true) {
                pos = i;
                break;
            }
        }
        console.log(pos);
        var doc = this.responseXML;
        var nodosempleado = doc.getElementsByTagName("EMPLEADO")[pos];
        var empleado = nodosempleado.getElementsByTagName("APELLIDO")[0].textContent;
        var oficio = nodosempleado.getElementsByTagName("OFICIO")[0].textContent;
        console.log(empleado);
       

        var res = document.getElementById("dato");
        res.innerText = "Apellido: " + empleado + "\nOficio: " + oficio;
    }
}