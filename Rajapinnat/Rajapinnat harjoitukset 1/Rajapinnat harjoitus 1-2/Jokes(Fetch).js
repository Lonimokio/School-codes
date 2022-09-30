function SJokes() {
	
fetch('https://api.icndb.com/jokes/')

 .then(Anwser => Anwser.json())
  .then((Info) => {

	var Text = "";


	for (let i = 1; i <= 10; i++) {
		
	Text = Text + Info.value[i].joke + "<br>" + "<br>";
	document.getElementById("Print").innerHTML = Text;
	
	}


})
}

function PrintB() {
	
fetch('https://api.icndb.com/jokes/')

 .then(Anwser => Anwser.json())
  .then((Info) => {

	var Text = "";


	for (let i = 10; i >= 1; i--) {
		
	Text = Text + Info.value[i].joke + "<br>" + "<br>";
	document.getElementById("Print").innerHTML = Text;
	
	}


})
}

function PrintThree() {
	
fetch('http://api.icndb.com/jokes/random/3')

 .then(Anwser => Anwser.json())
  .then((Info) => {

	var Text = "";


	for (let i = 0; i < 3; i++) {
		
	Text = Text + Info.value[i].joke+ "<br>" + "<br>";
	document.getElementById("Print").innerHTML = Text;
	
	}


})
}

function PrintOne() {
	
fetch('http://api.icndb.com/jokes/20')

 .then(Anwser => Anwser.json())
  .then((Info) => {


	document.getElementById("Print").innerHTML = Info.value.joke;


})
}