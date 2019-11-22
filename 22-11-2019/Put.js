 function Put()
        {
          var  xhttp = new XMLHttpRequest();
          xhttp.onreadystatechange=function(){
            if(xhttp.status==200 && xhttp.readyState==4)
            {
              document.getElementById("view").innerHTML = xhttp.responseText;
            }
          };
		  var data = "This is for the put request";
          xhttp.open("PUT","put",true);
		  xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
          xhttp.send(data);
        }