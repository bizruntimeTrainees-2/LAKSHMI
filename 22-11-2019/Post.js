function Post()
        {
          var  xhttp = new XMLHttpRequest();
          xhttp.onreadystatechange=function(){
            if(xhttp.status==200 && xhttp.readyState==4)
            {
              document.getElementById("view").innerHTML = xhttp.responseText;
            }
          };
		  var data = "This is for the post request";
          xhttp.open("POST","post",true);
		  xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
          xhttp.send(data);
        }