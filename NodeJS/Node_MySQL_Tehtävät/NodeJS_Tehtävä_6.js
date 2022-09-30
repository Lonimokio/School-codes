var mysql = require('mysql');


var con = mysql.createConnection(
{host: "localhost",
user: "root",
password: "",
database: "farm"
}
);
con.connect(function(err) {
 if (err) throw err;

 console.log("Connection succes!");
 console.log("");
 
 var sql_lisaa = "INSERT INTO Crops (Crop) VALUES ?";
 
 var rivit = [
 ['Potato'],
 ['Carrot'],
 ['Beetroot'],
 ['Wheat'],
 ['Rye'],
];
 
 con.query(sql_lisaa, [rivit], function (err, result) {
 if (err) throw err;
 
    console.log("Tietokantaan lisättiin yhteensä ", result.affectedRows, " rivi.");
	console.log("Lisätyn rivin ID on: " + result.insertId);
  
	});
	var UpdateRow = "UPDATE Crops SET Name='Potato' WHERE Id = 3";
 
 
 con.query(UpdateRow, function (err, result) {
 if (err) throw err;
 
    console.log("Updated ", result.affectedRows, " row succesfully.");
  
	});
	var poistaRivi = "DELETE FROM Crops WHERE Id = 4";
 
 
 con.query(poistaRivi, function (err, result) {
 if (err) throw err;
 
    console.log("Deleted ", result.affectedRows, " rows from database.");
  
	});
	con.query(sql_lisaa, [rivit], function (err, result) {
 if (err) throw err;
 
    console.log("Tietokantaan lisättiin yhteensä ", result.affectedRows, " rivi.");
	console.log("Lisätyn rivin ID on: " + result.insertId);
  
	});
  con.query("SELECT * FROM Crops", function (err, result, fields) {
 if (err) throw err;
 
 console.log("Database includes these results: ", result);
 
 console.log(result[0].nimi);
 
 console.log(result[0].id);
 
	});
	  con.query("SELECT * FROM Crops WHERE Name='TARDIS'", function (err, result, fields) {
 if (err) throw err;
 
 console.log("Single result: ", result);
 
 console.log(result[0].nimi);
 
 console.log(result[0].id);
 
	});
});
