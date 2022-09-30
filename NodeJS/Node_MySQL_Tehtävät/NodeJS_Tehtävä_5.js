
var mysql = require('mysql');


var con = mysql.createConnection(
{host: "localhost",
user: "root",
password: "",
database: "vehicles"
}
);

con.connect(function(err) {
 if (err) throw err;

 console.log("Connection succes!");
 console.log("");
 
var poistaRivi = "DELETE FROM Ships WHERE Id = 11";
 
 
 con.query(poistaRivi, function (err, result) {
 if (err) throw err;
 
    console.log("Deleted ", result.affectedRows, " rows from database.");
  
	});
 
   con.query("SELECT * FROM Ships", function (err, result, fields) {
 if (err) throw err;
 
 console.log("Database includes these results: ", result);
 
 console.log(result[0].nimi);
 
 console.log(result[0].id);
 
	});
 });