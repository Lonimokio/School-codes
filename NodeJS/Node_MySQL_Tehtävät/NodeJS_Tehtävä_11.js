
var mysql = require('mysql');


var con = mysql.createConnection(
{host: "localhost",
user: "root",
password: "",
database: "farm"
}
);

var Input = require("prompt-sync")();
var DID = Input ("Where to delete?: ");
var Show = Input ("Do you want to see records?: ");

con.connect(function(err) {
 if (err) throw err;

 console.log("Connection succes!");
 console.log("");
 
var poistaRivi = "DELETE FROM crops WHERE Id = ?";
 
 
 con.query(poistaRivi, DID, function (err, result) {
 if (err) throw err;
 
    console.log("Deleted ", result.affectedRows, " rows from database.");
  
	});
 if (Show = "Yes"){
   con.query("SELECT * FROM crops", function (err, result, fields) {
 if (err) throw err;
 
 console.log("Database includes these results: ", result);
 
 console.log(result[0].nimi);
 
 console.log(result[0].id);
   
	});
 }
 else {
 }
 });