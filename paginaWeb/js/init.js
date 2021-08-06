
 
(function($) {
    "use strict";
	
	$('.flexslider-home').flexslider({
			animation: "fade",
			slideshow: true,
			slideshowSpeed: 4000,
			animationSpeed: 600, 
			directionNav: false,
			controlNav: true,
			useCSS: false
									
					});

	$('.flexslider-testimonials').flexslider({
			animation: "fade",
			slideshow: true,
			slideshowSpeed: 4000,
			animationSpeed: 600, 
			directionNav: false,
			controlNav: true,
			useCSS: false
									
					});
	
	$(".gal-img a[data-rel^='prettyPhoto']").prettyPhoto({
						animation_speed: 'normal',
						autoplay_slideshow: true,
						slideshow: 3000
					});


$('.faq-section').hide();

$('h5.faq-title').click(function(){

  if( $(this).next().is(':hidden') ) {
  
  $('h5.faq-title').removeClass('active').next().slideUp(); 
  $(this).toggleClass('active').next().slideDown();
  
  } else {
   $('h5.faq-title').removeClass('active').next().slideUp();
 }
  return false; 
 });


$(".scrollup").hide();
     $(window).scroll(function() {
         if ($(this).scrollTop() > 400) {
             $('.scrollup').fadeIn();
         } else {
             $('.scrollup').fadeOut();
         }
     });

$("a.scrolltop[href^='#']").on('click', function(e) {
   e.preventDefault();
   var hash = this.hash;
   $('html, body').stop().animate({scrollTop:0}, 1000, 'easeOutExpo');

});


})(jQuery);


