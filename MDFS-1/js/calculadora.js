var numero = 0;
var operador = "";
var caja = document.getElementById("caja");
window.onload = function () {
    var botones = document.getElementsByName("bot");
    for (var b of botones) {
        b.addEventListener("click", function () {
            var caja = document.getElementById("caja");
            caja.value += parseInt(this.value);
        });
    }
    var oper = document.getElementsByName("op");
    for (var o of oper) {
        o.addEventListener("click", function () {
            //GUARDAMOS EL OPERADOR PULSAOD UY EL NUMERO
            var caja = document.getElementById("caja");
            numero = parseInt(caja.value);
            operador = this.value;
            caja.value = "";
        });
    }
    var igual = document.getElementById("igual");
    igual.addEventListener("click", function () {
        var caja = document.getElementById("caja");
        var num2 = parseInt(caja.value);
        var resultado = 0;
        switch (operador) {
            case "+":
                resultado = numero + num2;
                break;

            case "-":
                resultado = numero - num2;
                break;

            case "*":
                resultado = numero * num2;
                break;

            case "/":
                resultado = numero / num2;
                break;

        }
        caja.value = "";
        caja.value = resultado;
    });
}
