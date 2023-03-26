$(document).ready(function(){

	var imgItems = $('.contenido-slider').length;
	var imgPos = 1;

	
	$('.contenido-slider').show();
	$('.contenido-slider:first').show();


	$('.right1 span').click(nextSlider);
	$('.left1 span').click(prevSlider);

	setInterval(function(){
		nextSlider();
	}, 4000);

function nextSlider(){
		if( imgPos >= imgItems){
			imgPos = 1;

		} else {
			imgPos+6;
		}

		console.log(imgPos);

		$('.contenido-slider').hide(); // Ocultamos todos los slides
		$('.contenido-slider:nth-child(-n+3)').fadeIn(); // Mostramos el Slide seleccionado

	}

	function prevSlider(){
		if( imgPos <= 1){imgPos = imgItems;} 
		else {imgPos--;}

		$('.contenido-slider').hide(); // Ocultamos todos los slides
		$('.contenido-slider:nth-child(-n+3)').fadeIn(); // Mostramos el Slide seleccionado
	}


	/*$('.slider2 li').hide();
	$('.slider2 li:first').show();

	$('.right span').click(nextSlider);
	$('.left span').click(prevSlider);

	setInterval(function(){
		nextSlider();
	}, 10000);

function nextSlider(){
		if( imgPos >= imgItems){
			imgPos = 1;

		} else {
			imgPos++;
		}

		console.log(imgPos);

		$('.ul_slider li').hide(); // Ocultamos todos los slides
		$('.ul_slider li:nth-child('+ imgPos +')').fadeIn(); // Mostramos el Slide seleccionado

	}

	function prevSlider(){
		if( imgPos <= 1){imgPos = imgItems;} 
		else {imgPos--;}

		$('.ul_slider li').hide(); // Ocultamos todos los slides
		$('.ul_slider li:nth-child('+ imgPos +')').fadeIn(); // Mostramos el Slide seleccionado
	}

*/

});
