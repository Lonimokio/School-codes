<?php

$ApiAdrress='https://restcountries.com/v3.1/all';

$JsonData= file_get_contents($ApiAdrress);

$ObjectData= json_decode($JsonData);

foreach($ObjectData as $Country) {
  
echo"Country name: ".$Country-> name -> common;
echo"\n";

}


?>