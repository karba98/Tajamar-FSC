//Creamos objeto
/*
 * 
 * 
 * 
 * */
//Objeto Matematicas
var Matematicas = function (num) {
    //almaceno num
    this.numero = num;
    //dejamos doble como int inicializado a 0
    this.doble = 0;
    //generamos el doble en una funcion anonima
    //almacenamos this en una variable interna
    var obj = this;
    this.generarDoble = function () {
        //cambiamos algo del objeto
        obj.doble = parseInt(obj.numero * 2);

    }
}