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
                    var xhttp = new XMLHttpRequest();
                    idal = this.id;
                    xhttp.addEventListener("load", leerAlumno);
                    xhttp.open("GET", "xml/alumnos.xml");
                    xhttp.send();
                });
                ref.href = "#"
                ref.innerText = nombre;
                ref.dataset.nota = alumno.getElementsByTagName("idalumno")[0].textContent;
                ref.dataset.nota = alumno.getElementsByTagName("idalumno")[0].textContent;
                li.appendChild(ref);
                lista.appendChild(li);
            }

        }
    });
    xhttp.open("GET", "xml/alumnos.xml");
    xhttp.send();
}
function leerAlumno() {
    if (this.readyState == 4 && this.status == 200) {
        var alumnos = this.responseXML.getElementsByTagName("alumno");
        for (var al of alumnos) {
            var id = al.getElementsByTagName("idalumno")[0].textContent;
            var nombre = al.getElementsByTagName("nombre")[0].textContent;
            var apellido = al.getElementsByTagName("apellidos")[0].textContent;
            var nota = al.getElementsByTagName("nota")[0].textContent;
            if (id == idal) {
                console.log(nombre + " " + nota)
                document.getElementById("nombre").innerText = "Nombre: " + nombre + " " + apellido;
                document.getElementById("nota").innerText = "Nota: " + nota;
            }
        }


    }


}