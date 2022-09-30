
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
 
 var sql_lisaa = "INSERT INTO Ships (Name, Series, Year, Usefulness) VALUES ?";
 
 var rivit = [
 ['USS Enterprise','Star Trek','1966','Moderate'],
 ['Orville','Orville','2017','Moderate'],
 ['Dalek Ship','Doctor Who','1966','Moderate'],
 ['Flying Dutchman','???','???','???'],
 ['Potato','???','???','???'],
];
 
 con.query(sql_lisaa, [rivit], function (err, result) {
 if (err) throw err;
 
    console.log("Tietokantaan lisättiin yhteensä ", result.affectedRows, " rivi.");
	console.log("Lisätyn rivin ID on: " + result.insertId);
  
	});
  con.query("SELECT * FROM Ships", function (err, result, fields) {
 if (err) throw err;
 
 console.log("Database includes these results: ", result);
 
 console.log(result[0].nimi);
 
 console.log(result[0].id);
 
	});
	  con.query("SELECT * FROM Ships WHERE Name='TARDIS'", function (err, result, fields) {
 if (err) throw err;
 
 console.log("Single result: ", result);
 
 console.log(result[0].nimi);
 
 console.log(result[0].id);
 
	});
 });