<!DOCTYPE html>  

<html lang="fi">  

  <head>  

<meta charset="utf-8">

    <title>Proccesing information</title>  
<link href="CSS test.css"rel="stylesheet"type="text/css"/>

  </head>  

<body>


<?php

if(isset($_POST['button'])){

$Remove1 = $_POST["Remove"];
$Conn = mysqli_connect("localhost", "root", "1234", "Kirjasto");
 
if($Conn === false){
    die("ERROR: Could not connect. " . mysqli_connect_error());
}

$sql = "DELETE FROM Kirjat WHERE  KirjanID = ('".$Remove1."')";
$Result = mysqli_query($Conn, $sql);
if($Result){ 

	$Amount = mysqli_affected_rows($Conn);		
	if($Amount > 0) 
	{
		echo "Deleting was a succes.<br>"; 
	}
	if($Amount == 0) 
	{
		echo "<br>Error: error occured while deleting. $sql. " . mysqli_error($Conn); 
	}
} 



header("Location: Remove(L).html");
exit();
mysqli_close($Conn);
}



?>

</body>  

</html>