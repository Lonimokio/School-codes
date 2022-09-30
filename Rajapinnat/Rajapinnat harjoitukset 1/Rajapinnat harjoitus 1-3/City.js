
function SearchCapitals() {

fetch('https://restcountries.com/v3.1/all')

    .then(res => res.json())
    .then((Info) => {
		
    	
	var Text = "";
	
	for (let i = 0; i < Info.length; i++) {
		
		Text = Text + Info[i].capital + "<br>" + "<br>";
		document.getElementById("Print").innerHTML = Text;
	} 
	
	
			
}).catch(err => console.error(err));

}

function SearchNames() {

fetch('https://restcountries.com/v3.1/all')

    .then(res => res.json())
    .then((Info) => {
		
    	
	var Text = "";
	
	for (let i = 0; i < Info.length; i++) {
		
		Text = Text + Info[i].name["official"] + "<br>" + "<br>";
		document.getElementById("Print").innerHTML = Text;
	} 
		
			
}).catch(err => console.error(err));

}