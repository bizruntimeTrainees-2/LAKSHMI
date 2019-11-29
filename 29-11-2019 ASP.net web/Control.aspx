<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Control.aspx.cs" Inherits="Fourthweb1.Control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox id ="TextBox1" runat = "server" />
            <asp:Button ID ="Button1" runat ="server" Text ="Click me" />   //this is asp.net control ,here after asubmitting the data, the data is still present.
            <br/>
            <input type =" text" id ="TextBox2" />
            <input type ="submit" id ="submit1" value ="Click me"/> //this is html control, here after submitting data the value is not present
        </div>
    </form>
</body>
</html>
