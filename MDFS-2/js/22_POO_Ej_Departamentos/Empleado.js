/*
 * 
 * OBJETO EMPLEADO
 * */


var Empleado = function (id,apellido,oficio,salario,departamento,fechaalta) {
    this.idempleado = id;
    this.apellido = apellido;
    this.oficio = oficio;
    this.salario = parseInt(salario);
    this.departamento = departamento;
    this.fechaalta = fechaalta;
    this.getSalarioAnual = function (salario) {
        return parseInt(salario * 12) + "€";
    }
    this.getAniosT = function (fecha) {
        var input = fecha.split("/");
        var dateObject = new Date(input[2] + "-" + input[1] + "-" + input[0]);
        var year = dateObject.getFullYear();
        return parseInt(new Date().getFullYear()-year);

    }
    this.getSalarioTotal = function (anios, salario) {
        return parseInt(salario*anios);

    }
    
}
