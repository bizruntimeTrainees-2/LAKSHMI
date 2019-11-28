<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASPfirst.aspx.cs" Inherits="aspfirst.ASPfirst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        document.write("I am using while loop here");
        var i = 0, j = 1, k;
        document.write("<br/> Fibonacci series program");
        while (i < 100) {
            document.write(i + " ");
            k = i + j;
            i = j;
            j = k;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
