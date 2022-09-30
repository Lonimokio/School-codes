function SearchBoat() {

fetch('https://meri.digitraffic.fi/api/v1/metadata/vessels')

    .then(res => res.json())
    .then((data) => {
		
    	
	var Text = "";
	
	
	for (let i = 0; i < data.length; i++) {
		
	Text = Text + data[i] + "<br>" + "<br>";
			
	document.getElementById("Print").innerHTML = Text;
	} 
	
		
}).catch(err => console.error(err));

}

function SearchPorts() {

fetch('https://meri.digitraffic.fi/api/v1/port-calls')

    .then(res => res.json())
    .then((data) => {
		
    	
	var Text = "";
	
	
	for (let i = 0; i < data.portCalls.length; i++) {
		
	Text = Text + data.portCalls[i].portCallId + "<br>" + "<br>";

	document.getElementById("Print").innerHTML = Text;
	} 
	
		
}).catch(err => console.error(err));

}

function SearchWarning() {

fetch('https://meri.digitraffic.fi/api/v1/nautical-warnings/published')

    .then(res => res.json())
    .then((data) => {
		
    	
	var Text = "";
	
	
	for (let i = 0; i < data.properties.length; i++) {
		
	Text = Text + data.properties[i].id + "<br>" + "<br>";

	document.getElementById("Print").innerHTML = Text;
	} 
	
		
}).catch(err => console.error(err));

}