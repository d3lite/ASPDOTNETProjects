<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="Project3.CreateUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up Page</title>
    <style>
        h2{
            color: darkred;
        }
        h3{
            color: darkred;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>
            New User?</h2>
        <h3>
            &nbsp;Fill out the Information below 
        </h3>
    
    </div>
        <asp:Label ID="lblUserName" runat="server" Text="Username: "></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblName" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblUserType" runat="server" Text="User Type: "></asp:Label>
        <asp:DropDownList ID="ddlTypeSignUp" runat="server">
            <asp:ListItem>Reviewer</asp:ListItem>
            <asp:ListItem>Representative</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" Text="Sign Up" />
        <br />
        <br />
    </form>
</body>
</html>
