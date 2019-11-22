function PostForm()
        {
          var  xhttp = new XMLHttpRequest();
          xhttp.onreadystatechange=function(){
            if(xhttp.status==200&& xhttp.readyState==4)
            {
              document.getElementById("view").innerHTML = xhttp.responseText;
            }
          };
		  var data = "This is for the postform";
          xhttp.open("POST","post",true);
		  xhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
          xhttp.send(data);
		}
		function call()
      {
        
        var element = document.createElement("input");
        element.setAttribute("type","text");
         var add = document.getElementById("add");
         add.appendChild(element);       
      }
      function Talk()
      {
        
        var element = document.createElement("input");
        element.setAttribute("type","text");
         var add1 = document.getElementById("add1");
         add1.appendChild(element);       
      }