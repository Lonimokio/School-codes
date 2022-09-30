var mysql = require('mysql');

const readline = require("readline");
const Reading = readline.createInterface({
	 input: process.stdin,
	 output: process.stdout,
 });

var con = mysql.createConnection(
{host: "localhost",
user: "root",
password: "",
database: "farm"
}
);

var Input = require("prompt-sync")();
var Answer1 = Input("First thing to add?: ");
var Answer2 = Input("Second thing to add?: ");
var Answer3 = Input("Third thing to add?: ");
var Answer4 = Input("Fourth thing to add?: ");
var Answer5 = Input("Fifth thing to add?: ");
var UID = Input ("Where to update to potato?: ");
var DID = Input ("Where to delete?: ");

con.connect(function(err) {
 if (err) throw err;

 console.log("Connection succes!");
 console.log("");
 
 var sql_lisaa = "INSERT INTO Crops (Crop) VALUES ?";
 


 var rivit = [
 [Answer1],
 [Answer2],
 [Answer3],
 [Answer4],
 [Answer5],
];
 
 con.query(sql_lisaa, [rivit], function (err, result) {
 if (err) throw err;
 
    console.log("Tietokantaan lisättiin yhteensä ", result.affectedRows, " rivi.");
	console.log("Lisätyn rivin ID on: " + result.insertId);
  
	});
	var UpdateRow = "UPDATE Crops SET Crop='Potato' WHERE Id = ?";
 
 
 con.query(UpdateRow, UID,function (err, result) {
 if (err) throw err;
 
    console.log("Updated ", result.affectedRows, " row succesfully.");
  
	});
	var DeleteRow = "DELETE FROM Crops WHERE Id = ?";
 
 
 con.query(DeleteRow, DID,function (err, result) {
 if (err) throw err;
 
    console.log("Deleted ", result.affectedRows, " rows from database.");
  
	});
  con.query("SELECT * FROM Crops", function (err, result, fields) {
 if (err) throw err;
 
 console.log("Database includes these results: ", result);
 
 console.log(result[0].nimi);
 
 console.log(result[0].id);
 
	});
	  con.query("SELECT * FROM Crops WHERE Crop='Potato'", function (err, result, fields) {
 if (err) throw err;
 
 console.log("Single result: ", result);
 
 console.log(result[0].nimi);
 
 console.log(result[0].id);
 
	});
});
