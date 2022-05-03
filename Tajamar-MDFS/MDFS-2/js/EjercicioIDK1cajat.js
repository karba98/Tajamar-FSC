$(document).ready(function () {
    $("#repe").on("input", function () {
        $("#nr").text($(this).val());
    });
    $("#repe").change(function () {
        $("#nr").text($(this).val());
        var caja = $("#caja");
        caja.empty();
        var repeti = parseInt($(this).val());
        for (var i = 0; i < repeti; i++) {
            var img = $("<img>", {
                "src": "green.jpg",
            });
            img.css({
                "width": "70px",
                "height": "50px"
            });
            img.data("id", i)
            img.appendTo(caja);

            if (i == repeti - 1) {
                var br = $("<br/>");
                br.appendTo(caja);
            }

        }
        for (var i = 0; i < parseInt($(this).val()); i++) {
            var bot = $("<button>", {
                "type": "button",
                "text": "Imagen " + i
            });

            bot.data("id", i)
            bot.appendTo(caja);

            bot.click(function () {
                var imagen = caja.children().eq(parseInt($(this).data("id")));
                console.log(imagen.attr("src"));
                if (imagen.attr("src") == "facebook_logo_portada.jpg") {
                    imagen.attr("src", "green.jpg");
                }
                else imagen.attr("src", "facebook_logo_portada.jpg");
            });

        }
    });

});