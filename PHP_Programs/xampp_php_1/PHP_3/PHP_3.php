<!DOCTYPE html>  

<html lang="fi">  

  <head>  

<meta charset="utf-8">

    <title>Adding information</title>  

  </head>  

<body>


<?php


if(isset($_POST['button'])){


$Number = $_POST["LBox"];
$Numbers = $Number *2;

$add = "INSERT INTO php_3 (Math) VALUES ('".$Numbers."')";

$servername = "localhost";
$username = "root";
$password = "1234";
$db = "xampp_php_1";
$Connection = mysqli_connect($servername, $username, $password, $db); 


$Result = mysqli_query($Connection, $add);


if($Result){ 

    echo "Succes! Information added.<br>"; 

} else{ 

    echo "Error: error happened $add. " . mysqli_error($Connection); 
	
} 

mysqli_close($Connection);

}


?>

</body>  

</html>