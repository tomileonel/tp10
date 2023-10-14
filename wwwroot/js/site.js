// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function Temporada(idSerie){
    $.ajax(
        {
            type: 'POST',
            dataType:'JSON',
            url: '/Home/ObtenerTemporadasSerieAjax',
            data: {IdJugador:idSerie},
            success:
                 function(response)
                 {
                    $("#Temporadas").html(response)
                 }

        }






    );
}