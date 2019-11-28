function RequestHeader()
	{
  var data = document.getElementById("header2");
  var  xhr = new XMLHttpRequest();
  xhr.onreadystatechange=function(){
    if(xhr.status == 200 && xhr.readyState==4)
    {
      
      document.getElementById("view").innerHTML = xhr.responseText;
    }
  };
  xhr.open("GET","/headers");
  xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");  
  xhr.send(data.value);
}
function ResponseHeader()
	{
  var data = document.getElementById("header1");
  var  xhr = new XMLHttpRequest();
  xhr.onreadystatechange=function(){
    if(xhr.status==200 && xhr.readyState==4)
    {
      
      document.getElementById("view").innerHTML = xhr.responseText;
    }
  };2
  xhr.open("GET","/response-headers?foo1=bar1&foo2=bar");
  xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");  
  xhr.send();
}