<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Apply.aspx.cs" Inherits="Project4.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Credit Card System</title>
    <style>
        #creditcardform
        {
            background-color: lightslategrey;
        }
    </style>
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
        <br />
        <asp:Button ID="btnEmployee" runat="server" Text="Employee Click Here" OnClick="btnEmployee_Click" />
        <br />
        <br />
        <asp:Label ID="lblEmployee" runat="server" Text="Are you applying for a customer? " Visible="False"></asp:Label>
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
        <div id="creditcardform">
            <br />
            Please enter the information below for approval:<br />
            <br />
            <br />
        <asp:Label ID="Label2" runat="server" Text="First Name: "></asp:Label>
&nbsp;<asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Text="Last Name: "></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        &nbsp;<br />
&nbsp;<asp:Label ID="Label3" runat="server" Text="UserName: "></asp:Label>
&nbsp;<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label20" runat="server" Text="Last 4 digit of your Social Security Number: "></asp:Label>
            <asp:TextBox ID="txtSSN" runat="server"></asp:TextBox>
            <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Address: "></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        &nbsp;
        <asp:Label ID="Label5" runat="server" Text="City: "></asp:Label>
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Text="State: "></asp:Label>
        <asp:TextBox ID="txtState" runat="server" Width="45px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label10" runat="server" Text="Zip Code: "></asp:Label>
        <asp:TextBox ID="txtZip" runat="server" Width="74px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
        <asp:Label ID="Label16" runat="server" Text="Credit Card Type: "></asp:Label>
        &nbsp;<asp:DropDownList ID="ddlCardType" runat="server">
                <asp:ListItem>Visa</asp:ListItem>
                <asp:ListItem>Master Card</asp:ListItem>
                <asp:ListItem>American Express</asp:ListItem>
                <asp:ListItem>Discover</asp:ListItem>
            </asp:DropDownList>
            <br />
        <asp:Label ID="Label17" runat="server" Text="Please enter your desired 16-digit Credit Card Number: "></asp:Label>
        &nbsp;<asp:TextBox ID="txtCardNumber" runat="server" Width="161px"></asp:TextBox>
            <br />
        <asp:Label ID="Label18" runat="server" Text="Please enter your desired 3-git CVV Number: "></asp:Label>
        <asp:TextBox ID="txtCVVNumber" runat="server"></asp:TextBox>
            <br />
        <asp:Label ID="Label19" runat="server" Text="Please enter your desired expired Month/Year: (MM/YYYY)"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtMonthYear" runat="server" ></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnApplyForCreditCard" runat="server" Text="Apply " Width="118px" OnClick="btnApplyForCreditCard_Click" />

            &nbsp;&nbsp;&nbsp;
            <br />
            <br />

            </div>
        <br />
        <asp:Label ID="lblError" runat="server" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblApprovalMessage" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblcredtypemessage" runat="server" Text="Credit Card Type: " Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblcrednum" runat="server" Text="Credit Card Number: " Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblcvvnum" runat="server" Text="CVV: " Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblexp" runat="server" Text="Expired Month/Date: " Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblcredlimit" runat="server" Text="Credit Limit: " Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lblEmployeeFilledOut" runat="server" Text="Label" Visible="False"></asp:Label>
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
