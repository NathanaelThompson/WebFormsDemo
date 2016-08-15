<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
    <h2>Registration page</h2>
    <a href="Default.aspx">Default page</a>
    
    <form id="form1" runat="server">
    <div>
        <p>Enter first name</p>
        <asp:TextBox ID="fnBox" placeholder="First name here" runat="server"/>
        <p>Enter middle name</p>
        <asp:TextBox ID="mnBox" placeholder="Middle name here" runat="server"/>
        <p>Enter last name</p>
        <asp:TextBox ID="lnBox" placeholder="Last name here" runat="server"/>
        <p>Email</p>
        <asp:TextBox ID="emailBox" placeholder="Email here" runat="server"/>
        <p>Phone Number</p>
        <asp:TextBox ID="phoneBox" placeholder="Phone # here" runat="server"/>
        <p>Username</p>
        <asp:TextBox ID="usernameBox" placeholder="Username here" runat="server"/>
        <p>Password</p>
        <asp:TextBox ID="passwordBox" placeholder="Password here" runat="server"/>
        <asp:Button ID="submitButton" Text="Submit" runat="server" OnClick="submitButton_Click"/>
    </div>
    </form>
</body>
</html>
