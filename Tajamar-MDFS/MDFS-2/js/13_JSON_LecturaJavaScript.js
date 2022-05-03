
function peticion() {
    console.log("Entro en peticion");
    var xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function () {
        //el estado hace la peticion en estado 3 y 4
        //por lo que metemon un if para que solo haga cosas en state = 4
        if (this.readyState == 4 && this.status == 200) {
            //Convertimos el texto plano recibido a json
            var textoplano = this.responseText;
            //textoplano --> json
            console.log(this.readyState);
            console.log(textoplano);
            var data = JSON.parse(textoplano);
            leerdatos(data);
        }
        
    }
    //El boolean indica que queremos la petición asincrona
    xhr.open("GET", "json/clientessimples.json", true);
    xhr.send();
}
function leerdatos(data) {
    console.log("leemos datos");
    var array = data.clientes;
    //element --> key,value
    for (var element of array) {
        var h2 = document.createElement("h2");
        h2.innerText = "Nombre: " + element.nombre;
        var caja = document.getElementById("res");
        caja.appendChild(h2);
    }
}