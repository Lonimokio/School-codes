<?php

function get_data() {

        $file_name='People.json';
   
        if(file_exists("$file_name")) {

            $current_data=file_get_contents("$file_name");
            $array_data=json_decode($current_data, true);         
            $extra=array(
                'CustomerID' => '1',
                'FName' => 'Test',
                'LName' => 'Test',
				'Adrress' => 'Test',
				'PostNumber' => 'Test',
            );

            $array_data[]=$extra;
            
            echo "File found!\n";
            
            return json_encode($array_data);
        }
		
        else {

            $datae=array();
			
            $datae[]=array(
                'CustomerID' => '1',
                'FName' => 'Test',
                'LName' => 'Test',
				'Adrress' => 'Test',
				'PostNumber' => 'Test',
            );

            echo "File not found. Made a new one!\n";
            return json_encode($datae);   
        }
    }
  

    $file_name='People.json';

    if(file_put_contents("$file_name", get_data())) {
		
        echo "Adding information was a succes!\n";
    }                
    else {
		
        echo "Error!\n";                
    }
?>