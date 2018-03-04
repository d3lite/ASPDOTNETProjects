<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Restaurant Review</title>
    <style>
        h1{
            color: darkred;
        }
        h2{
            color: darkred;
        }
    </style>
</head>
<body>
    <h1>Welcome to Restaurant Review </h1>
    <form id="form1" runat="server">
    <div>
        <h2>
            Please Login or Sign up 
        </h2>
        <h3>
            &nbsp;</h3>
        
        <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>

    
        <br />
        <asp:Label ID="Label1" runat="server" Text="User Type:"></asp:Label>
        <asp:DropDownList ID="ddlUserTypeLogIn" runat="server" AutoPostBack="True">
            <asp:ListItem>Reviewer</asp:ListItem>
            <asp:ListItem>Representative</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
&nbsp;<asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" Text="Sign Up" />
        <br />
        <br />
        <asp:Label ID="lblUserError" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

    
    </div>
    </form>
</body>
</html>
