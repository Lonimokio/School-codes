function Search() {
	
fetch('https://api.icndb.com/jokes/')

 .then(Answer => Answer.json())
  .then((Info) => {

	var Text = "";

	for (let i = 1; i < 200; i++) {
		
	Text = Text + Info.value[i].joke + "<br>" + "<br>";
	document.getElementById("Joke").innerHTML = Text;
	
	}




})
}
function Search2() {
	
fetch('https://api.icndb.com/jokes/')

 .then(Answer => Answer.json())
  .then((Info) => {

	var Text = "";

	for (let i = 1; i < 200; i++) {
		
	Text = Text + Info.value[i].id + "<br>" + "<br>";
	document.getElementById("Joke").innerHTML = Text;
	
	}




})
}
function Search3() {
	
fetch('https://api.icndb.com/jokes/')

 .then(Answer => Answer.json())
  .then((Info) => {

	var Text = "";

	for (let i = 1; i < 200; i++) {
		
	Text = Text + Info.value[i].id + " " + Info.value[i].joke + "<br>" + "<br>";
	document.getElementById("Joke").innerHTML = Text;
	
	}




})
}
