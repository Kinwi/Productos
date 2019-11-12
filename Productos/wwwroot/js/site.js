// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//----------------RECOGEMOS  LAS BUSQUEDAS Y LAS ALMACENAMOS EN UN OBJETO "JUEGO"-------------------------------------------------------------
// Cuando pulsamos el boton busqueda nos guarada cada juego en el array juego en formato JSON
// Guardamos la variable en el localStorage

let busquedajuego = {
    'nombre': inputNombre.value,
    'anio': inputAnio.value

}

juegos.push(busquedajuego);
localStorage.setItem('juegos', JSON.stringify(juegos));
console.log(juegosalmacenados);
RellenarModal();

let like = document.createElement('button');
like.getAttribute('id', 'like');
like.innerHTML = "LIKE"
cajaelementos1.appendChild(like);