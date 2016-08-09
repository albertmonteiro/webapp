﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApp.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
</head>
<body>
    <p>This is the registration page</p>
    <a href="Default.aspx">Home</a> | <a href="#">Registration</a>

    <form id="form1" runat="server">
    <div>
        <p>Enter first name</p>
        <asp:TextBox ID="firstnameTextBox" Text="" runat="server" />
        <p>Enter middle name</p>
        <asp:TextBox ID="middlenameTextBox" Text="" runat="server" />
        <p>Enter last name</p>
        <asp:TextBox ID="lastnameTextBox" Text="" runat="server" />
        <p>Enter email</p>
        <asp:TextBox ID="emailTextBox" Text="" runat="server" />
        <p>Enter phone number</p>
        <asp:TextBox ID="phoneNumberTextBox" Text="" runat="server" />
        <p>Enter Username</p>
        <asp:TextBox ID="usernameTextBox" Text="" runat="server" />
        <p>Enter Password</p>
        <asp:TextBox ID="passwordTextBox" TextMode="Password"  runat="server" />
        <asp:Button ID="registerButton" Text="REGISTER" runat="server" OnClick="registerEventMethod" />
    
    </div>
    </form>
</body>
</html>
