
    function read() {
    var xhttp = new XMLHttpRequest();// supports all browers
  xhttp.onreadystatechange =function() {
    if (this.readyState == 4 && this.status == 200) {
      document.getElementById("demo").innerHTML =
      this.responseText;
    }
  };
  xhttp.open("GET", "ajax.txt", true);
  xhttp.send();
}

            