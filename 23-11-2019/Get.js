function SendRequest()
        {
          var  xhttp = new XMLHttpRequest();
          xhttp.onreadystatechange=function(){
            if(xhttp.status==200&& xhttp.readyState==4)
            {
				var object = JSON.parse(xhttp.response);
				document.getElementById("view").innerHTML = object.surname +" "+ object.name;
            }
		  };
          xhttp.open("GET","Get.json",true);
          xhttp.send();
        }      
		