<?php
	
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
				
	function get_data() {
		$id = $_POST['id'];
		$file_name='People'. '.json';

		if(file_exists("$file_name")) {
			$current_data=file_get_contents("$file_name");
			$array_data=json_decode($current_data, true);
							
			$extra=array(
				'id' => $_POST['id'],
				'FName' => $_POST['enimi'],
				'LName' => $_POST['snimi'],
			);
			$array_data[]=$extra;
			echo "File found!<br/>";
			return json_encode($array_data);
		}
		else {
			$datae=array();
			$datae[]=array(
				'id' => $_POST['id'],
				'FName' => $_POST['enimi'],
				'LName' => $_POST['snimi'],
			);
			echo "File not found. Now one has been created!<br/>";
			return json_encode($datae);
		}
	}

	$file_name='People'. '.json';
	
	if(file_put_contents("$file_name", get_data())) {
		echo "Adding information was a succes!";
	}				
	else {
		echo "Error! Couldnt add info!";				
	}
}
	
?>
