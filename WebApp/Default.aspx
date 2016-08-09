<%@ Page Title="Default" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default</title>
</head>
<body>
    <p>This is the home page</p>
    <a href="#">Home</a> | <a href="Registration.aspx">Registration</a>

    <form id="form1" runat="server">
    <div>

        <p>Enter Username</p>
        <asp:TextBox ID="usernameTextBox" runat="server" />
        <p>Password</p>
        <asp:TextBox ID="passwordTextBox" TextMode="Password" runat="server" />
        <asp:Button ID="submitButton" runat="server" Text="Log in" OnClick="submitButton_Click" />
        <br/><br/>
        <asp:Label ID="lblMessage" runat="server" Text="" />
    
    </div>
    </form>
</body>
</html>
