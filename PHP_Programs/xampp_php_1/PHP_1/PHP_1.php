<!DOCTYPE html>  

<html lang="fi">  

  <head>  

<meta charset="utf-8">

    <title>Adding information</title>  

  </head>  

<body>


<?php


if(isset($_POST['button'])){


$LName = $_POST["LName"];
$FName = $_POST["FName"];

$add = "INSERT INTO php_1 (LName, FName) VALUES ('".$LName."','".$FName."')";

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