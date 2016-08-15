<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- MySQL Username = webformuser (maybe localhost) Password = webuser2016 -->

    <h2>Echo Title: <%: EchoTitle() %></h2>
    <p>The time is <%:DateTime.Now.ToString() %></p>
    <a href="Registration.aspx">Registration</a>
    
    <div>
        <p>Enter Username</p>
        <asp:TextBox ID="usernameBox" placeholder="Enter username here" runat="server" />
        <p>Enter Password</p>
        <asp:TextBox ID="passwordBox" placeholder="Enter password here" runat="server" />
        <asp:Button ID="loginButton" Text="Login" runat="server" OnClick="loginButton_Click"/>
    </div>
    <br /><br />
    <asp:Literal ID="Literal1" runat="server">New Title: </asp:Literal>
    <asp:TextBox ID="titleBox" runat="server" placeholder="Type here"></asp:TextBox>
    <asp:Button ID="titleButton" runat="server" Text="Change Title" OnClick="titleButton_Click"/>
    <asp:RegularExpressionValidator ID="regexpTitle" runat="server"
                                    ErrorMessage="Invalid title"
                                    ControlToValidate="titleBox"
                                    ValidationExpression="^[a-zA-Z0-9\s'-]*$" />
    <br /><br />
    <asp:Calendar ID="defaultCal" BackColor="Black" BorderColor="Wheat" DayStyle-ForeColor="White" Font-Bold="true" runat="server" OnSelectionChanged="defaultCal_SelectionChanged"></asp:Calendar>
    <asp:TextBox ID="selectedDate" placeholder="Selected date displayed here" runat="server"></asp:TextBox>
    
</asp:Content>
