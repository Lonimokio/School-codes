<!DOCTYPEhtml>
<html>
	<head>
<meta charset="utf-8"><metaname="viewport"content="width=device-width">
<title>Main Page</title>
<link href="CSS test.css"rel="stylesheet"type="text/css"/>
</head>

<body
<br><br><br><br><br><br>
<h1>Welcome to the library</h1>
<p>You can search books by clicking search button. <br> You can also press add, remove or update buttons to excacute according functions.</p> 
<?php
$search = "SELECT * FROM kirjat"; 

$Conn = mysqli_connect("localhost", "root", "1234", "kirjasto"); 


$Result = mysqli_query($Conn, $search);


if($Result){ 


    if(mysqli_num_rows($Result) > 0){ 


        echo "<table width=100% cellpadding=5 callspacing=5 border=1>"; 
            echo "<tr>"; 

                echo "<th>KirjanID</th>"; 
                echo "<th>Teos</th>"; 
                echo "<th>Tekijä</th>";
				echo "<th>Julkaisuvuosi</th>";				

            echo "</tr>"; 


        while($row = mysqli_fetch_array($Result)){ 

            echo "<tr>"; 

                echo "<td>" . $row['KirjanID'] . "</td>"; 
                echo "<td>" . $row['Teos'] . "</td>"; 
                echo "<td>" . $row['Tekijä'] . "</td>"; 
				echo "<td>" . $row['Julkaisuvuosi'] . "</td>"; 

			echo "</tr>"; 
        } 
        echo "</table>"; 


		mysqli_free_result($Result); 


    } else{ 

        echo "No rows found."; 
    } 

} else{ 

    echo "ERROR: No work $search. " . mysqli_error($Conn); 
} 

mysqli_close($Conn);
?>

<h1>Here you can add books</h1>
<p>You can add books by typing in the correspondin fields and pressing add.<br>
<br>
<form method="post">
<label for="Year">|Publish year|</label>
<label for="Author">|Author|</label>
<label for="BName">|Book name|</label>
<br>
<input type="text"id="Year"name="Year" max=4>
<input type="text"id="Author"name="Author" max=30>
<input type="text"id="BName"name="BName" max=50>
<br>
<input type="submit" name="add">
</form>
<?php

if(isset($_POST['add'])){
	
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
mysqli_close($Conn);
header("refresh: 0");
}
?>
<h1> Here you can update certain book info </h1>
<form method="post">
<label for="Year">|Publish year|</label>
<label for="Author">|Author|</label>
<label for="BName">|Book name|</label>
<br>
<input type="text"id="Year"name="Year" max=4>
<input type="text"id="Author"name="Author" max=30>
<input type="text"id="BName"name="BName" max=50>
<br>
<label for="Update">|Where to update (ID)|</label><br>
<input type="text"id="ID"name="ID" max=4><br>
<button type="submit" name="Update">submit</button>
</form>
<?php
if(isset($_POST['Update'])){

$UID = $_POST["ID"];
$Year = $_POST["Year"];
$Author = $_POST["Author"];
$BName = $_POST["BName"];

$Update = "UPDATE kirjat SET Teos = ('".$BName."'), Tekijä=('".$Author."'), Julkaisuvuosi=('".$Year."') WHERE KirjanID=('".$UID."')";

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
mysqli_close($Conn);
header("refresh: 0");
}


?>
<h1>You can remove a book from here<h1>
<form method="post">
<label for="Remove">|What book to remove (ID)|</label><br>
<input type="text"id="ID2"name="ID2" max=4><br>
<button type="submit" name="Remove">submit</button>
</form>
<?php

if(isset($_POST['Remove'])){

$Remove1 = $_POST["ID2"];
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
mysqli_close($Conn);
header("refresh: 0");
}
?>

<h1 class="glow">Testing in progress</h1>
<script src="JV1.js"></script>
</body>
</html>