<?php

$Info = 'Ships.json';

$ReadInfo = file_get_contents($Info);

$Ships = json_decode($ReadInfo);

$data = $Ships->Ships;

foreach ($data as $Ships1) {

 echo "Ships series is: ".$Ships1->Series;
 echo "<br>";
}

for ($i = 0; $i < count($data); $i++) {
	
echo $data[$i] -> Name . "<br>";

}
?>