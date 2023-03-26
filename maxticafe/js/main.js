$(document).ready(function(){

	var imgItems = $('.ul_slider li').length;
	var imgPos = 1;

	$('.ul_slider li').hide();
	$('.ul_slider li:first').show();

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



});
