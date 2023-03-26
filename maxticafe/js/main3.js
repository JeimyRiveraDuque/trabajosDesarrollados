let slider = document.querySelector(".slider-contenedor")
let sliderIndividual = document.querySelectorAll(".contenido-slider")
let contador = 1;
let width = sliderIndividual[0].clientWidth;
let intervalo = 3000;

window.addEventListener("resize", function(){
    width = sliderIndividual[0].clientWidth;
})

setInterval(function(){
    slides();
},intervalo);



function slides(){
    slider.style.transform = "translate("+(-width*contador)+"px)";
    slider.style.transition = "transform .8s";
    contador++;

    if(contador == sliderIndividual.length){
        setTimeout(function(){
            slider.style.transform = "translate(0px)";
            slider.style.transition = "transform 0s";
            contador=1;
        },1500)
    }
}

/*$(document).ready(function(){

    var imgex = $('.slider-contenedor .contenido-slider').length;
    var img = 1;

    /*$('.ul_slider li').hide();
    $('.ul_slider li:first').show();+++++++++++++++++++++++++++++++++++

    $('.right1 span').click(siguiente_slider);
    $('.left1 span').click(anterior_slider);

    /*setInterval(function(){
        nextSlider();
    }, 10000);++++++++++++++++++++++++++++++++++++++++++++

function siguiente_slider(){
        if( img >= imgex){
            img = 1;

        } else {
            img++;
        }

        console.log(img);

      // $('.slider-contenedor .contenido-slider').hide();  //Ocultamos todos los slides
      // $('.slider-contenedor .contenido-slider:nth-child('+ img +')'); // Mostramos el Slide seleccionado

    }

    function anterior_slider(){
        if( img <= 1){img = imgex;} 
        else {img--;}

       // $('.slider-contenedor .contenido-slider').hide(); // Ocultamos todos los slides
       // $('.slider-contenedor .contenido-slider:nth-child('+ img +')'); // Mostramos el Slide seleccionado
    }



});*/