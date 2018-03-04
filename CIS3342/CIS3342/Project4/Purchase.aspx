<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Purchase.aspx.cs" Inherits="Project4.Purchase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Credit Card System</h2>
        <br />
        <asp:Button ID="btnApply" runat="server" Height="104px" Text="Apply for a Credit Card" Width="223px" OnClick="btnApply_Click" />
        <asp:Button ID="btnUpdate" runat="server" Height="104px" Text="Update Information" Width="191px" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnPayment" runat="server" Height="104px" Text="Make a Payment" Width="228px" OnClick="btnPayment_Click" />
        <asp:Button ID="btnTransaction" runat="server" Height="104px" Text="Transaction History" Width="257px" OnClick="btnTransaction_Click" />
        <asp:Button ID="btnPurchase" runat="server" Height="104px" Text="Purchase an Item" Width="257px" OnClick="btnPurchase_Click" />
         <br />
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Please Provide the Item Name: "></asp:Label>
        <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Item Price (Dollars): "></asp:Label>
        <asp:TextBox ID="txtItemPrice" runat="server" Width="79px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnPaymentInfo" runat="server" OnClick="btnPaymentInfo_Click" Text="Payment Information" />
        <br />
        <br />
        <asp:Label ID="lblError2" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="lblUserName" runat="server" Text="Customer Username: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblCreditCardNumber" runat="server" Text="Credit Card Number: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtCardNumber" runat="server" Visible="False"></asp:TextBox>
        <br />
        <asp:Label ID="lblCVVNumber" runat="server" Text="CVV Number: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtCVVNum" runat="server" Width="57px" Visible="False"></asp:TextBox>
        <br />
        <asp:Label ID="lblMonthYear" runat="server" Text="Expired Month/Date (MM/YY):  " Visible="False"></asp:Label>
        <asp:TextBox ID="txtMonthYear" runat="server" Width="99px" Visible="False"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblBill" runat="server" Text="Billing Information" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbladdress" runat="server" Text="Street Address: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" Visible="False"></asp:TextBox>
        <br />
        <asp:Label ID="lblCity" runat="server" Text="City: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtCity" runat="server" Visible="False"></asp:TextBox>
        <br />
        <asp:Label ID="lblbillstate" runat="server" Text="State: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtState" runat="server" Width="30px" Visible="False"></asp:TextBox>
        <br />
        <asp:Label ID="lblzipcode" runat="server" Text="Ziip Code: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtZip" runat="server" Width="59px" Visible="False"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnPurchaseItem" runat="server" OnClick="btnPurchaseItem_Click" Text="Purchase Item" Visible="False" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="lblError1" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
