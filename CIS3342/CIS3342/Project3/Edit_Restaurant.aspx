<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit_Restaurant.aspx.cs" Inherits="Project3.Edit_Restaurant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Restaurant Review</h1>
        <h2>Edit Restaurant Here:</h2>

    </div>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label1" runat="server" Text="Edit Restaurant Name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtRestName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Edit Category: "></asp:Label>
        <asp:DropDownList ID="ddlCategory" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Edit City: "></asp:Label>
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Edit State: "></asp:Label>
        <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnUpdateRestaurant" runat="server" OnClick="btnUpdateRestaurant_Click" Text="Update Restaurant " />
    </form>
</body>
</html>
