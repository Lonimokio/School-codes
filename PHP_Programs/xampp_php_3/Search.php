<!DOCTYPE html>  

<html lang="fi">  

  <head>  

<meta charset="utf-8">
<link href="CSS test.css"rel="stylesheet"type="text/css"/>
    <title>Searching</title>  

  </head>  

<body>
<br><br><br><br><br><br>
<h1>Welcome to the search</h1>
<p>Youre searching books. if you want you can go home or,<br> You can also press add, remove or update buttons to excacute according functions.</p> 
<p id="Area_2">
<br>
<form action="FrontPage(L).html" method="post">
<button type="submit" name="VBooks">Home</button><br>
</form>
<form action="Add(L).html" method="post">
<button type="submit" name="Add">Add book</button>
</form>
<form action="Remove(L).html" method="post">
<button type="submit" name="Remove">Remove book</button><br>
</form>
<form action="Update(L).html" method="post">
<button type="submit" name="UBook">Update book</button>
</form>

<?php




if(isset($_POST['VBooks'])){



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
}

mysqli_close($Conn);


?>

</body>  

</html>