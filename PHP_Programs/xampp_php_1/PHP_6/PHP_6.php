<!DOCTYPE html>  

<html lang="fi">  

  <head>  

<meta charset="utf-8">
<link href="CSS test.css"rel="stylesheet"type="text/css"/>
    <title>Adding information</title>  

  </head>  

<body>

<?php


if(isset($_POST['button'])){

$Name = $_POST["Name"];
$Score = $_POST["Score"];

$myfile = fopen("Scoreboard.txt", "w") or die("Unable to open file!");
$txt = "GamerName: ";
fwrite($myfile, $txt);
$txt = $Name;
fwrite($myfile, $txt);
$txt = "\n";
fwrite($myfile, $txt);
$txt = "Score: ";
fwrite($myfile, $txt);
$txt = $Score;
fwrite($myfile, $txt);
$txt = "\n";
fwrite($myfile, $txt);
fclose($myfile);

}


?>

</body>  

</html>