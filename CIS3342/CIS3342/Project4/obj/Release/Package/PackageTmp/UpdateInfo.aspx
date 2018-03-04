<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateInfo.aspx.cs" Inherits="Project4.UpdateInfo" %>

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

    <div>
    
        <br />
        <asp:Button ID="btnEmployee" runat="server" Text="Employee Click Here" OnClick="btnEmployee_Click" />
        <br />
        <br />
        <asp:Label ID="lblEmployee" runat="server" Text="Are you updating information for a costumer?" Visible="False"></asp:Label>
        <br />
        <asp:RadioButtonList ID="rbEmployee" runat="server" Visible="False">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="lblEmpName" runat="server" Text="Enter Your Name: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtEmployeeName" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Customer username: "></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label17" runat="server" Text="Customer Last 4 Digit of Social Security Number:"></asp:Label>
        <asp:TextBox ID="txtSSN" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFindInfo" runat="server" Text="Get Information" OnClick="btnFindInfo_Click" />
&nbsp;
        <br />
        <br />
        <br />
        <asp:GridView ID="gvCardInformation" runat="server" AutoGenerateColumns="False" Visible="False" OnRowCommand="gvCardInformation_RowCommand">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Deactivate" HeaderText="Deactivate" Text="Deactivate Card" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="CreditCardNumber" HeaderText="Credit Card Number" />
                <asp:BoundField DataField="CVVNumber" HeaderText="CVV Number" />
                <asp:TemplateField HeaderText="Address">
                    <ItemTemplate>
                        <asp:TextBox ID="txtAddress" runat="server" Text='<%# Bind("StreetAddress") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="City">
                    <ItemTemplate>
                        <asp:TextBox ID="txtCity" runat="server" Text='<%# Bind("BillingCity") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="State">
                    <ItemTemplate>
                        <asp:TextBox ID="txtState" runat="server" Text='<%# Bind("BillingState") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Zip">
                    <ItemTemplate>
                        <asp:TextBox ID="txtZip" runat="server" Text='<%# Bind("BillingZipCode") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:ButtonField ButtonType="Button" CommandName="Activate" HeaderText="Activate" Text="Activate Card" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        &nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            &nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;
            <br />

        <br />
        <asp:Button ID="btnUpdateInfo" runat="server" Text="Update Information " OnClick="btnUpdateInfo_Click" />
        <br />
        <br />
        <asp:Label ID="lblEmployeeFilledOut" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
