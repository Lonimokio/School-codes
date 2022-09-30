var mysql = require('mysql');



var con = mysql.createConnection(
{host: "localhost",
user: "root",
password: "",
database: "farm"
});


con.connect(function(err) {
 if (err) throw err;
 console.log("Connection succes!");
  var sql = "CREATE TABLE Animals (id INT AUTO_INCREMENT PRIMARY KEY, Animal VARCHAR(255))";
  con.query(sql, function (err, result) {
    if (err) throw err;
    console.log("Table created");
  });
});
