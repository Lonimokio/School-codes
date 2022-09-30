<!DOCTYPE html>  

<html lang="fi">  

  <head>  

<meta charset="utf-8">

    <title>Adding information</title>  

  </head>  

<body>


<?php


if(isset($_POST['button'])){

$UID = $_POST["Update"];
$Year = $_POST["Year"];
$Author = $_POST["Author"];
$BName = $_POST["BName"];

$Update = "UPDATE kirjat SET Teos = ('".$BName."'), Tekijä=('".$Author."'), Julkaisuvuosi=('".$Year."') WHERE KirjanID=('".$UID."')";;

$servername = "localhost";
$username = "root";
$password = "1234";
$db = "Kirjasto";
$Conn = mysqli_connect($servername, $username, $password, $db); 


$Result = mysqli_query($Conn, $Update);


if($Result){ 

} else{ 

    echo "Error: error happened $Update. " . mysqli_error($Conn); 
	
} 


header("Location: Update(L).html");
exit();
mysqli_close($Conn);

}


?>

</body>  

</html>