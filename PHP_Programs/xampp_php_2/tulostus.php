<!DOCTYPE html>  

<html lang="fi">  

  <head>  

<meta charset="utf-8">
<link href="CSS test.css"rel="stylesheet"type="text/css"/>

    <title>Adding information</title>  

  </head>  

<body>


<?php



$Name = $_POST["kokonimi"];
$Password = $_POST["ssana"];
$Age = $_POST["ikaryhma"];
$Grade = $_POST["arvosana"];
$OS = $_POST["OS"];
$Opinion = $_POST["mielipide"];


if ($Password = "test")
{
	echo "<br>your name is: ", $Name, "<br>";
	echo "Your age is: ",$Age, "<br>";
	echo "Your grade for us is: ",$Grade, "<br>";
	echo "Your operating system is: ",$OS, "<br>";
	echo "<br>Your feedback to us is: <br>",$Opinion, "<br>";
}
else
{
	echo "incorrect password";
}


?>

</body>  

</html>