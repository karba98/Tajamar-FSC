

function peti() {
    var xhttp = new XMLHttpRequest();
    xhttp.addEventListener("load", mostrarDatos);
    xhttp.open("GET", "xml/empleados.xml");
    xhttp.send();
}


function mostrarDatos() {
    console.log(" * Acceso al servicio concedido");
    var caja = document.getElementById("caja_datos");
    //readystate => indica sui ha finalizado la lectura(4)
    console.log(this.readystate);
    console.log("Status: "+this.status);
    
    if (this.readyState == 4 && this.status == 200) {
        //accedemos al objeto con el DOm de html (this.responseXML)
        var doc = this.responseXML;
        //Buscamos nodos para sacar los apellidos  (CASE SENSITVE)
        var nodosApellido = doc.getElementsByTagName("APELLIDO");
        var html = "";
        for (var apellido of nodosApellido) {
            html+=apellido.childNodes[0].nodeValue+"<br/>"
        }
        caja.innerHTML = html;
    } else {
        caja.innerHTML="<h1>Petición incorrecta<br/>"+this.status+"</h1>"
    }
}