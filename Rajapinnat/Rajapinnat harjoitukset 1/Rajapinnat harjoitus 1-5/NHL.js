function SearchNames() {

fetch('https://statsapi.web.nhl.com/api/v1/teams/5/roster')

    .then(res => res.json())
    .then((data) => {
		
    	
	var Text = "";
	
	
	for (let i = 0; i < data.roster.length; i++) {
		
	Text = Text + data.roster[i].person["fullName"] + "<br>" + "<br>";
			
	document.getElementById("Print").innerHTML = Text;
	} 
	
		
}).catch(err => console.error(err));

}

function SearchTeamNames() {

fetch('https://statsapi.web.nhl.com/api/v1/teams/?teamId=4,5,29')

    .then(res => res.json())
    .then((data) => {
		
    	
	var Text = "";
	
	
	for (let i = 0; i < data.teams.length; i++) {
		
	Text = Text + data.teams[i].name + "<br>" + "<br>";

	document.getElementById("Print").innerHTML = Text;
	} 
	
		
}).catch(err => console.error(err));

}

function SearchDivisions() {

fetch('https://statsapi.web.nhl.com/api/v1/divisions')

    .then(res => res.json())
    .then((data) => {
		
    	
	var Text = "";
	
	
	for (let i = 0; i < data.divisions.length; i++) {
		
	Text = Text + data.divisions[i].name + "<br>" + "<br>";

		
	document.getElementById("Print").innerHTML = Text;
	} 
	
	
}).catch(err => console.error(err));

}