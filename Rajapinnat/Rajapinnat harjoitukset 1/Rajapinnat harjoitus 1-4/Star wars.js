
function SearchInfo() {

fetch('https://swapi.dev/api/people/')

    .then(res => res.json())
    .then((Info) => {
		

	document.getElementById("Print").innerHTML = Info.results[0].name + " " + Info.results[0].mass;

	
	
			
}).catch(err => console.error(err));

}