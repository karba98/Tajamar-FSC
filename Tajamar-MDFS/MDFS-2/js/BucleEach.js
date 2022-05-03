$(document).ready(function () {
    $("h2").click(function () {
        var colores = ["blue", "yellow", "green", "red"];
        $("h2").each(function () {
            var aleatorio = parseInt(Math.random() * colores.length);
            //cada parrafo tendra colo diferente
            var color = colores[aleatorio];
            console.log(color);
            $(this).css("background-color", color);
            $(this).text(color);
        });
    });
});