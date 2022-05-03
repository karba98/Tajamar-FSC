
//PETICION AL SERVIDOR
function peticion() {
    //CREAMOS OBJETO XMLHTTP
    var xhttp = new XMLHttpRequest();
    //TRAS LA RESPUESTA SE EJECUTARÁ LOAD
    //DELEGAMOS EL EVENTO DE RESPUESTA DEL SERVICIO
    xhttp.addEventListener("load", pintarDatos);
    //CONFIGURAMOS PETICION
    xhttp.open("GET", "xml/empleados.xml");//O URL
    //EJECUTAMOS LA PETICIÓN
    xhttp.send();
}


function pintarDatos() {
    console.log(" ** Acceso al servicio concedido");
    var caja = document.getElementById("caja_datos");
    //DIBUJAMOS LA RESPUESTA
   
    /*
     EN VSCODE HAY QUE INSTALAR LIVESERVER
     */

    //OBJETO XML
    //caja.innerText = this.responseXML;

    //TEXTO BRUTO
    caja.innerText = this.responseText;

    
}