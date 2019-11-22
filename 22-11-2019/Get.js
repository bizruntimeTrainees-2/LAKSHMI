function SendRequest()
        {
          var  xhttp = new XMLHttpRequest();
          xhttp.onreadystatechange=function(){
            if(xhttp.status==200&& xhttp.readyState==4)
            {
              document.getElementById("view").innerHTML = xhttp.responseText;
            }
          };
          xhttp.open("GET","get?foo1=bar1",true);
          xhttp.send();
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
	  
       
		