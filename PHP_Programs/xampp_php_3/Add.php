<!DOCTYPE html>  

<html lang="fi">  

  <head>  

<meta charset="utf-8">

    <title>Adding information</title>  

  </head>  

<body>


<?php


if(isset($_POST['button'])){

$Year = $_POST["Year"];
$Author = $_POST["Author"];
$BName = $_POST["BName"];

$add = "INSERT INTO kirjat (Teos, Julkaisuvuosi, Tekijä) VALUES ('".$BName."','".$Year."','".$Author."')";

$servername = "localhost";
$username = "root";
$password = "1234";
$db = "Kirjasto";
$Conn = mysqli_connect($servername, $username, $password, $db); 


$Result = mysqli_query($Conn, $add);


if($Result){ 

} else{ 

    echo "Error: error happened $add. " . mysqli_error($Conn); 
	
} 


header("Location: Add(L).html");
exit();
mysqli_close($Conn);

}


?>

</body>  

</html>