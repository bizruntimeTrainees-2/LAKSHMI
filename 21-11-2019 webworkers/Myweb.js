var request = new XMLHttpRequest();		//using this function we can call any external url and get the data 
request.open("GET","http://andberry.comcomsocket?delay=5",false);	//synchronous
request.send();
console.log(request,responseText);

