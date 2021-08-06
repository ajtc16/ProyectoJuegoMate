(function($) {
    "use strict";
	
	var options2 = { success: showResponseContact, beforeSubmit: showRequestContact}; 
    $('#contact-form').submit(function() { 
        $(this).ajaxSubmit(options2); 
        return false; 
    });
	
	})(jQuery);

function showResponseContact(responseText, statusText)  { 
	if (statusText == 'success') {
		$('#contact-form-holder').html('<h5>Message sent</h5>'); 
		$('#output-contact').html('<p>' + $('someText', responseText).html()  + '</p>'); 
	} else {
		alert('status: ' + statusText + '\n\nAlgo esta mal aquí!');
	}
}

function showRequestContact(formData, jqForm, options2) { 
	var form = jqForm[0];
	var validRegExp = /^[^@]+@[^@]+.[a-z]{2,}$/i;
	
	if (!form.name.value) { 
		$('#output-contact').html('<div class="output2">Por favor llenar el campo Nombre!</div>'); 
		return false; 
	} else if (!form.email.value) {
		$('#output-contact').html('<div class="output2">Por favor llenar el campo Email!</div>'); 
		return false; 
	} else if (form.email.value.search(validRegExp) == -1) {
		$('#output-contact').html('<div class="output2">Por favor poner un Email valido!</div>'); 
		return false; 
	}
	else if (!form.subject.value) {
		$('#output-contact').html('<div class="output2">Por favor llenar el campo Tema!</div>'); 
		return false; 
	}
	else if (!form.message.value) {
		$('#output-contact').html('<div class="output2">Por favor llenar el campo Mensaje!</div>'); 
		return false; 
	}
	 else {	   
	 $('#output-contact').html('Enviando Mensaje...!');  		
		return true;
	}
}