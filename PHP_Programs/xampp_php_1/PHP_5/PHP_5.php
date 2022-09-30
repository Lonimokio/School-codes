<!DOCTYPE html>  

<html lang="fi">  

  <head>  

<meta charset="utf-8">

    <title>Adding information</title>  

  </head>  

<body>


<?php


if(isset($_POST['button'])){


$R1;
$R2;

$servername = "localhost";
$username = "root";
$password = "1234";
$conn = mysqli_connect($servername, $username, $password); 

if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
} 
$sql = "CREATE DATABASE Random";
if ($conn->query($sql) === TRUE) {
  echo "Database created successfully";
} else {
  echo "Error creating database: " . $conn->error;
}
$servername = "localhost";
$username = "root";
$password = "1234";
$DB = "Random";
$conn = mysqli_connect($servername, $username, $password, $DB); 
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
} 
$sql = "CREATE TABLE Random (
id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
Number INT(30) NOT NULL,
reg_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
)";

if ($conn->query($sql) === TRUE) {
  echo "<br>Table Random created successfully";
} else {
  echo "<br>Error creating table: " . $conn->error;
}

for ($x = 0; $x <= 10; $x++) {
$Number = (rand(0,1000));

$add = "INSERT INTO Random (Number) VALUES ('".$Number."')";
$Result = mysqli_query($conn, $add);

if($Result){ 

    echo "Succes! Information added.<br>"; 

} else{ 

    echo "Error: error happened $add. " . mysqli_error($conn); 
}
}
	$randomId = (rand(0, 10));
	$search="SELECT Number FROM random WHERE id='$randomId'";
	$result = mysqli_query($conn, $search);

	if($result){ 


    if(mysqli_num_rows($result) > 0){ 


        echo "<table width=500 cellpadding=5 callspacing=5 border=1>"; 

            echo "<tr>"; 
                echo "<th>Number</th>"; 


            echo "</tr>"; 


        while($row = mysqli_fetch_array($result)){ 

            echo "<tr>"; 
                echo "<td>" . $row['Number'] . "</td>"; 
			$R2 = intval($row['Number']);
			echo "</tr>"; 
        } 
        echo "</table>"; 

		mysqli_free_result($result); 


    } else{ 
	
        echo "no rows found"; 
    } 

} else{ 

    echo "ERROR: could not exacute search $search. " . mysqli_error($conn); 
} 
	


mysqli_close($conn);

$servername = "localhost";
$username = "root";
$password = "1234";
$conn = mysqli_connect($servername, $username, $password); 

if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
} 
$sql = "CREATE DATABASE Random2";
if ($conn->query($sql) === TRUE) {
  echo "Database created successfully";
} else {
  echo "Error creating database: " . $conn->error;
}
$servername = "localhost";
$username = "root";
$password = "1234";
$DB = "Random2";
$conn = mysqli_connect($servername, $username, $password, $DB); 
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
} 
$sql = "CREATE TABLE Random2 (
id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
Number INT(30) NOT NULL,
reg_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
)";

if ($conn->query($sql) === TRUE) {
  echo "<br>Table Random2 created successfully";
} else {
  echo "<br>Error creating table: " . $conn->error;
}

for ($x = 0; $x <= 10; $x++) {
$Number = (rand(0,1000));

$add = "INSERT INTO Random2 (Number) VALUES ('".$Number."')";
$Result = mysqli_query($conn, $add);

if($Result){ 

    echo "Succes! Information added.<br>"; 

} else{ 

    echo "Error: error happened $add. " . mysqli_error($conn); 
}
}
	$randomId = (rand(0, 10));
	$search="SELECT Number FROM random2 WHERE id='$randomId'";
	$result = mysqli_query($conn, $search);

	if($result){ 


    if(mysqli_num_rows($result) > 0){ 


        echo "<table width=500 cellpadding=5 callspacing=5 border=1>"; 

            echo "<tr>"; 
                echo "<th>Number</th>"; 


            echo "</tr>"; 


        while($row2 = mysqli_fetch_array($result)){ 

            echo "<tr>"; 
                echo "<td>" . $row2['Number'] . "</td>"; 
			$R1=intval($row2['Number']);
			echo "</tr>"; 
        } 
        echo "</table>"; 

		mysqli_free_result($result); 


    } else{ 
	
        echo "no rows found"; 
    } 

} else{ 

    echo "ERROR: could not exacute search $search. " . mysqli_error($conn); 
} 
	$randomizer = (rand($R2, $R1));
	echo $randomizer;
	
	
mysqli_close($conn);


}


?>

</body>  

</html>