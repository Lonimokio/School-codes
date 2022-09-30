<?php

$Source = 'henkilot.json';

$ReadInfo = file_get_contents($Source);

$PeopleInfo = json_decode($ReadInfo);

$data = $PeopleInfo->Person;

foreach ($data as $Person) {

 echo "Persons last name is: ".$Person->LName;
 echo "<br>";
}

for ($i = 0; $i < count($data); $i++) {
	
echo $data[$i] -> FName . "<br>";

}

$Source2 = 'henkilot.json';

$ReadInfo2 = file_get_contents($Source2);

$PeopleInfo2 = json_decode($ReadInfo2);

$data2 = $PeopleInfo2->Ship;

foreach ($data2 as $Person2) {

 echo "Persons last name is: ".$Person2->Name;
 echo "<br>";
}

for ($i = 0; $i < count($data); $i++) {
	
echo $data[$i] -> Series . "<br>";

}
?>