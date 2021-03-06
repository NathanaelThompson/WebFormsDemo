﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AWebForm.aspx.cs" Inherits="AWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Upload a file!</h1>
        Submission name:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        Type:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="a" Text="ASCII" />
            <asp:ListItem Value="b" Text="Binary" />
        </asp:DropDownList>

        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click"/>
        <asp:Literal ID="Feedback" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
