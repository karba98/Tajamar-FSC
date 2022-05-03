/*
 * 
 * 
 *
 */
//CFREAMOS OBJETO QUE HEREDARÄ DE ARRAY
var MiArray = function () {
    this.longitud = 0;
    this.descripcion = "Mi descripcion";
    this.contarElementos = function () {
        return this.length;
    }
    this.sumarNumeros = function () {
        console.log("Mi Array");
        var suma = 0;
        for (var i of this) {
            suma += parseInt(i);
        }
        return suma;
    }
    
}
MiArray.prototype = new Array();

//AÑADIMOS METODOS A LA CLASE Array() (extends)
Array.prototype.contarElementos = function () {
    return this.length;
}
Array.prototype.sumarNumeros = function () {
    console.log("PROTO");
    var suma = 0;
    for (var i of this) {
        suma += parseInt(i);
    }
    return suma;

}