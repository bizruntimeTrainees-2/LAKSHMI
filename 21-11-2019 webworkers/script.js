<script>
if(window.Worker)
{
	var myWorker = new Worker("worker.js");
	var message = {add This: {num1:1, num2:2}};
	myWorker.postMessage(message);
	myWorker.onmessage = function(e)
	{
		console.dir(e.data.result);
		};
		}