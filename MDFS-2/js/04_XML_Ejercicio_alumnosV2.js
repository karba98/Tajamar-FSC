/**
 * @author raul catsro
 * */

var idal = "";

window.onload = function () {
    var xhttp = new XMLHttpRequest();
    xhttp.addEventListener("load", function () {
        console.log(this.readyState);
        console.log(this.status);
        var lista = document.getElementById("lista");
        if (this.readyState == 4 && this.status == 200) {
            console.log("conectado");
            var alumnos = this.responseXML.getElementsByTagName("alumno");
            for (var alumno of alumnos) {
                console.log(alumno);
                var nombre = alumno.getElementsByTagName("nombre")[0].textContent;
                console.log(nombre);
                var li = document.createElement("li");
                var ref = document.createElement("a");
                ref.addEventListener("click", function () {
                    document.getElementById("nombre").innerText = "Nombre: " + this.dataset.nombre;
                    document.getElementById("nota").innerText = "Nota: " + this.dataset.nota;
                });
                ref.href = "#"
                ref.innerText = nombre;
                ref.dataset.nota = alumno.getElementsByTagName("idalumno")[0].textContent;
                ref.dataset.nombre =
                    alumno.getElementsByTagName("nombre")[0].textContent + " " +
                    alumno.getElementsByTagName("apellidos")[0].textContent;
                li.appendChild(ref);
                lista.appendChild(li);
            }

        }
    });
    xhttp.open("GET", "xml/alumnos.xml");
    xhttp.send();

}