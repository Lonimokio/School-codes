var mysql = require('mysql');



var con = mysql.createConnection(
{host: "localhost",
user: "root",
password: "",
database: "farm"
}
);

var Input = require("prompt-sync")();
var Search1 = Input ("What to use for searching? Crop OR ID?: ");
var Search2 = Input ("What to Search for?: ");

con.connect(function(err) {
 if (err) throw err;

 console.log("Connection succes!");
 console.log("");
 
 
  con.query("SELECT * FROM Crops", function (err, result, fields) {
 if (err) throw err;
 
 console.log("Database includes these results: ", result);
 
 console.log(result[0].nimi);
 
 console.log(result[0].id);
 
	});
if (Search1 = "Crop"){
	  con.query("SELECT * FROM crops WHERE Crop=?",Search2,function (err, result, fields) {
 if (err) throw err;
 
 console.log("Filtered result: ", result);
 
 console.log(result[0].nimi);
 
 console.log(result[0].id);
 
	});
	}
else if (Search1 = "ID"){
		con.query("SELECT * FROM crops WHERE ID=?",Search2,function (err, result, fields) {
 if (err) throw err;
 
 console.log("Filtered result: ", result);
 
 console.log(result[0].nimi);
 
 console.log(result[0].id);
 
	});
	}
else {
		console.log("That perimeter doesnt exist!")
	}
});
