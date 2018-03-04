<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SandwichSelection.aspx.cs" Inherits="Project1.SandwichSelection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color:cyan; height: 466px;">
        <div style="margin-left: 80px">
        <asp:Label ID="lblAdditionalItems" runat="server" Text="Additional Items" style="position: absolute; z-index: 1; left: 14px; top: 251px"></asp:Label>
        </div>
        <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone number" style="position: absolute; z-index: 1; left: 13px; top: 94px"></asp:Label>


        <br />


            <asp:Label ID="lblName" runat="server" Text="Name" style="position: absolute; height: 19px; z-index: 1; left: 12px; top: 54px;"></asp:Label>


        <br />
        <asp:Label ID="lblSandwichSize" runat="server" Text="Sandwich Size" style="position: absolute; z-index: 1; left: 12px; top: 132px"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblMeatType" runat="server" Text="Meat Type" style="position: absolute; z-index: 1; left: 13px; top: 172px"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblAddonItems" runat="server" Text="Addon Items" style="position: absolute; z-index: 1; left: 13px; top: 211px; margin-top: 0px;"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="lblTips" runat="server" style="z-index: 1; left: 15px; top: 315px; position: absolute; height: 20px" Text="Tips :"></asp:Label>
        <asp:Label ID="lblMeal" runat="server" style="z-index: 1; left: 16px; top: 285px; position: absolute; height: 21px" Text="Meal : "></asp:Label>
        <asp:Label ID="lblFinalPrice" runat="server" style="z-index: 1; left: 13px; top: 348px; position: absolute; height: 21px; margin-top: 1px" Text="Final Price :"></asp:Label>
        </div>

    </form>
</body>
</html>
