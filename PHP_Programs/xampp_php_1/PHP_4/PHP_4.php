<!DOCTYPE html>  

<html lang="fi">  

  <head>  

<meta charset="utf-8">

    <title>Adding information</title>  

  </head>  

<body>


<?php


if(isset($_POST['button'])){

$FText = $_POST["FText"];
$LText = $_POST["LText"];

$length1 = strlen($FText);
$length2 = strlen($LText);

echo "first length ", $length1, "<br> Second Length ", $length2;
echo "<br>";
if ($length1 == $length2) 
{
	echo $FText, " and ", $LText, " are equally long";
}
else if ($length1 < $length2) 
{
	echo $LText, " is longer then ", $FText; 
}
else if ($length1 > $length2) 
{
	echo $FText, " is longer then ", $LText, "<br>"; 
}
echo "<br>Third letter of ", $FText, " is ", $FText[2], "<br>";
echo "Third letter of ", $LText, " is ", $LText[2], "<br>";

if (str_contains($LText, '.com')) {
    echo '.com was found in ', $LText, '<br>';
} else {
    echo '.com was not found in ', $LText, '<br>';
}
if (str_contains($FText, '.com')) {
    echo '.com was found in ', $FText, '<br>';
} else {
    echo '.com was not found in ', $FText, '<br>';
}

if (str_contains($LText, '@')) {
    echo '@	was found in ', $LText, '<br>';
} else {
    echo '@ was not found in ', $LText, '<br>';
}
if (str_contains($FText, '@')) {
    echo '@ was found in ', $FText, '<br>';
} else {
    echo '@ was not found in ', $FText, '<br>';
}

$Part1 = substr($FText,0,3)."<br>";
$Part2 = substr($LText,3,)."<br>";

echo substr_replace($Part1, $Part2, 3,0);

}

?>

</body>  

</html>