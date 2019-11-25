
var input_id =2;

$(function(){
  $('#add').click(function(){
    $('#a1').clone().attr("id","a"+ ++input_id +$(this).index()).insertAfter('#a2') ;
  });
  $('#add1').click(function(){
    $('#b1').clone().attr("id","b"+ ++input_id +$(this).index()).insertAfter('#b2') ;
  });
});

function PostFormData()
{
  var text = document.getElementById("q");
  var data='?';
  for(var i=0; i<text.children.length;i++)
       {
        if(text.children[i].id.includes("Text"))
        {
          data += text.children[i].id +'='+ text.children[i].value +'&';
        }
		else
		   {
			 data += b1.value +'&'+b2.value ;
		   }
      }
      
       
      
    var xhr = new XMLHttpRequest();
    xhr.withCredentials = true;
    
    xhr.onreadystatechange=function(){
      if(xhr.readyState===4)
      {
        document.getElementById("view").innerHTML = xhr.responseText;
      }
    };
    xhr.open("POST","/post");
    xhr.setRequestHeader("cache-control", "no-cache");
    xhr.setRequestHeader("postman-token", "e5a83bba-0476-63f1-26ea-e2c3f389b22b");  
    xhr.send(data);
}
    
