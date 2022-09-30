<!DOCTYPEhtml>
<html>
	<head>
<meta charset="utf-8"><metaname="viewport"content="width=device-width">
<title>Main Page</title>
<link href="CSS test.css"rel="stylesheet"type="text/css"/>
</head>

<body
<br><br><br><br><br><br>
<h1>Welcome to the customer database</h1><br>
<p>You can also press add, remove or update buttons to excacute according functions.</p> 
<form method="post">
<label for="Sort1">Choose sorting parameter:</label><br>

<select name="Sort1" id="Sort1">
  <option value="FName">First name</option>
  <option value="LName">Last name</option>
  <option value="Age">Age</option>
  <option value="ID">ID</option>
</select><br>
<input type="submit" name="sort">
</form>

<?php
if(isset($_POST['sort'])){
	
$sort1 = $_POST["Sort1"];
	
$search = "SELECT * FROM customers ORDER BY ('".$sort1."')"; 

$Conn = mysqli_connect("localhost", "root", "1234", "Shop"); 


$Result = mysqli_query($Conn, $search);


if($Result){ 


    if(mysqli_num_rows($Result) > 0){ 


        echo "<table width=100% cellpadding=5 callspacing=5 border=1>"; 
            echo "<tr>"; 

                echo "<th>ID</th>"; 
                echo "<th>FName</th>"; 
                echo "<th>Age</th>";
				echo "<th>LName</th>";				

            echo "</tr>"; 


        while($row = mysqli_fetch_array($Result)){ 

            echo "<tr>"; 

                echo "<td>" . $row['ID'] . "</td>"; 
                echo "<td>" . $row['FName'] . "</td>"; 
                echo "<td>" . $row['Age'] . "</td>"; 
				echo "<td>" . $row['LName'] . "</td>"; 

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
}

?>

<h1>Here you can add customers</h1>
<p>You can add customers by typing in the corresponding fields and pressing add.<br>
<br>
<form method="post">
<label for="LName">|Last Name|</label>
<label for="Age">|Age|</label>
<label for="FName">|First name|</label>
<br>
<input type="text"id="LName"name="LName" max=4>
<input type="text"id="Age"name="Age" max=30>
<input type="text"id="FName"name="FName" max=50>
<br>
<input type="submit" name="add">
</form>
<?php

if(isset($_POST['add'])){
	
$LName = $_POST["LName"];
$Age = $_POST["Age"];
$FName = $_POST["FName"];

$add = "INSERT INTO customers (FName, LName, Age) VALUES ('".$FName."','".$LName."','".$Age."')";

$servername = "localhost";
$username = "root";
$password = "1234";
$db = "Shop";
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
<h1> Here you can update certain customer info </h1>
<form method="post">
<label for="LName">|Last name|</label>
<label for="Age">|Age|</label>
<label for="FName">|First name|</label>
<br>
<input type="text"id="LName"name="LName" max=4>
<input type="text"id="Age"name="Age" max=30>
<input type="text"id="FName"name="FName" max=50>
<br>
<label for="Update">|Where to update (ID)|</label><br>
<input type="text"id="ID1"name="ID1" max=4><br>
<button type="submit" name="Update">submit</button>
</form>
<?php
if(isset($_POST['Update'])){

$UID = $_POST["ID1"];
$LName = $_POST["LName"];
$Age = $_POST["Age"];
$FName = $_POST["FName"];

$Update = "UPDATE customers SET FName = ('".$FName."'), Age=('".$Age."'), LName=('".$LName."') WHERE ID=('".$UID."')";

$servername = "localhost";
$username = "root";
$password = "1234";
$db = "Shop";
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
<h1>You can remove a customer from here<h1>
<form method="post">
<label for="Remove">|What customer to remove (ID)|</label><br>
<input type="text"id="ID2"name="ID2" max=4><br>
<button type="submit" name="Remove">submit</button>
</form>
<?php

if(isset($_POST['Remove'])){

$Remove1 = $_POST["ID2"];
$Conn = mysqli_connect("localhost", "root", "1234", "Shop");
 
if($Conn === false){
    die("ERROR: Could not connect. " . mysqli_connect_error());
}

$sql = "DELETE FROM customers WHERE  ID = ('".$Remove1."')";
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
<h1>Leave your feedback here</h1>
<form method="post">
<label for="Name">|Name|</label>
<br>
<input type="text"id="Name"name="Name">
<br>
<label for="Feedback">|Feedback|</label>
<br>
<input type="text"id="Feedback"name="Feedback">
<br>
  <input type="submit" name="TF">
  <br>
</form>
<?php


if(isset($_POST['TF'])){

$Name = $_POST["Name"];
$Score = $_POST["Feedback"];

$myfile = fopen("Complaint.txt", "a") or die("Unable to open file!");
$txt = "$Name: ";
fwrite($myfile, $txt);
$txt = $Name;
fwrite($myfile, $txt);
$txt = "\n";
fwrite($myfile, $txt);
$txt = "Complaint: ";
fwrite($myfile, $txt);
$txt = $Score;
fwrite($myfile, $txt);
$txt = "\n";
fwrite($myfile, $txt);
fclose($myfile);

}


?>
<h1 class="glow">Testing in progress</h1>
<script src="JV1.js"></script>
</body>
</html>