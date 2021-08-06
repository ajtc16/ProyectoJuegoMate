<?php

$recipient = "ajtc16@gmail.com";
$name = $_POST['name'];
$email = $_POST['email'];
$subject = $_POST['subject'];
$message = $_POST['message'];

if (isset($_POST['email'])) {	
	if (preg_match('(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,})', $_POST['email'])) {
		$msg = 'E-mail address is valid';
	} else {
		$msg = 'Invalid email address';
	}

  $ip = getenv('REMOTE_ADDR');
  $host = gethostbyaddr($ip);	
  $mess = "Nombre: ".$name."\n";
  $mess .= "Email: ".$email."\n";
  $mess .= "Tema: ".$subject."\n";
  $mess .= "Mensaje: ".$message."\n\n";
  $mess .= "IP:".$ip." HOST: ".$host."\n";
  
  $headers = "Pagina Tesis: <".$email.">\r\n"; 

  $sent = mail($recipient, $subject, $mess, $headers); 
  

$text = "Gracias por contactarme! Voy a revisar tu mail lo antes posible.";
	
echo '<xml>	<someText>'.$text.'</someText> </xml>';

} else {
	die('Invalid entry!');
}


?>