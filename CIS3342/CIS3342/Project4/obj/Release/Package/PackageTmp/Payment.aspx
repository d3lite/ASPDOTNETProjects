<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="Project4.Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>0Credit Card System</h2>
        <br />

        <asp:Button ID="btnApply" runat="server" Height="104px" Text="Apply for a Credit Card" Width="223px" OnClick="btnApply_Click" />
        <asp:Button ID="btnUpdate" runat="server" Height="104px" Text="Update Information" Width="191px" OnClick="btnUpdate_Click1" />
        <asp:Button ID="btnPayment" runat="server" Height="104px" Text="Make a Payment" Width="228px" OnClick="btnPayment_Click" />
        <asp:Button ID="btnTransaction" runat="server" Height="104px" Text="Transaction History" Width="257px" OnClick="btnTransaction_Click" />
        <asp:Button ID="btnPurchase" runat="server" Height="104px" Text="Purchase an Item" Width="257px" OnClick="btnPurchase_Click" />
        <br />
        <br />
        <asp:Button ID="btnEmployee" runat="server" Text="Employee Click Here" OnClick="btnEmployee_Click" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblEmployee" runat="server" Text="Are you updating information for a costumer?" Visible="False"></asp:Label>
        <asp:RadioButtonList ID="rbEmployee" runat="server" Visible="False">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="lblEmpName" runat="server" Text="Enter Your Name: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtEmployeeName" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter CreditCard Number: "></asp:Label>
        <asp:TextBox ID="txtCardNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label15" runat="server" Text="Enter CVV Number: "></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtCVVNumber" runat="server"></asp:TextBox>
&nbsp; <asp:Button ID="btnGetAccountInfo" runat="server" Text="Find Account Information" OnClick="btnGetAccountInfo_Click" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="gvPaymentInfo" runat="server" AutoGenerateColumns="False" Visible="False" >
            <Columns>
                <asp:BoundField DataField="CreditBalance" DataFormatString="{0:c}" HeaderText="Credit Balance" />
                <asp:BoundField DataField="CreditLimit" DataFormatString="{0:c}" HeaderText="Credit Limit" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="Label16" runat="server" Text="Enter Payment Amount: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtPaymentAmount" runat="server" Visible="False"></asp:TextBox>
&nbsp;
        <asp:Button ID="btnMakePayment" runat="server" OnClick="btnMakePayment_Click" Text="Make Payment" Visible="False" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

    <div>
    
    </div>
    </form>
</body>
</html>
