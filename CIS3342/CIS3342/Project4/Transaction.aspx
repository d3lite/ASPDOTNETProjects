<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="Project4.Transaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <h2>Credit Card System</h2>
        <br />
        <asp:Button ID="btnApply" runat="server" Height="104px" Text="Apply for a Credit Card" Width="223px" OnClick="btnApply_Click" />
        <asp:Button ID="btnUpdate" runat="server" Height="104px" Text="Update Information" Width="191px" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnPayment" runat="server" Height="104px" Text="Make a Payment" Width="228px" OnClick="btnPayment_Click" />
        <asp:Button ID="btnTransaction" runat="server" Height="104px" Text="Transaction History" Width="257px" OnClick="btnTransaction_Click" />
        <asp:Button ID="btnPurchase" runat="server" Height="104px" Text="Purchase an Item" Width="257px" OnClick="btnPurchase_Click" />

         <br />
         <br />
         <asp:Label ID="Label7" runat="server" Text="Retrieve Transaction History: "></asp:Label>

         <br />
         <br />

    <div>
    
        <asp:Label ID="Label8" runat="server" Text="Please Enter your Username: "></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnFindTransaction" runat="server" Text="Find Transaction" OnClick="btnFindTransaction_Click" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="gvCardInfo" runat="server" Width="289px" AutoGenerateColumns="False"  Visible="False">
            <Columns>
                <asp:BoundField DataField="CreditCardNumber" HeaderText="Card Number" />
                <asp:BoundField DataField="CVVNumber" HeaderText="CVV Number" />
                <asp:BoundField DataField="MonthYear" HeaderText="Expired Month/Year" />
                <asp:BoundField DataField="ItemName" HeaderText="Item Name" />
                <asp:BoundField DataField="ItemPrice" HeaderText="Item Price" DataFormatString="{0:C}" />
                <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" />
                <asp:BoundField DataField="TransactionStatus" HeaderText="Transaction Status" />
            </Columns>
        </asp:GridView>
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
