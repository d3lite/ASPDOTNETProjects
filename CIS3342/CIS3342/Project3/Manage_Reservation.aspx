<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manage_Reservation.aspx.cs" Inherits="Project3.Manage_Reservation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Welcome to Restaurant Review </h1>
        <h2>
            Create/Manage Reservation:
        </h2>
             <br />
             <asp:Button ID="btnManageRestaurant" runat="server" Height="86px" Text="Create/Manage Restaurant" Width="262px" OnClick="btnManageRestaurant_Click" />
             <asp:Button ID="btnManageReviews" runat="server" Height="86px" Text="Create/Manage Reviews" Width="262px" OnClick="btnManageReviews_Click" />
             <asp:Button ID="btnManageReservation" runat="server" Height="86px" Text="Create/Manage Reservation" Width="262px" OnClick="btnManageReservation_Click" />


             <asp:Button ID="btnLogOut" runat="server" Height="86px" OnClick="btnManageLogOut_Click" Text="Log Out" Width="262px" />


        <br />
        <br />
        <asp:GridView ID="gvReserveRest" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnRowCommand="gvReserveRest_RowCommand">
            <Columns>
                <asp:BoundField DataField="RestaurantID" HeaderText="Restaurant ID" />
                <asp:BoundField DataField="RestaurantName" HeaderText="Restaurant Name" />
                <asp:BoundField DataField="City" HeaderText="City" />
                <asp:BoundField DataField="RestState" HeaderText="State" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" />
                <asp:ButtonField ButtonType="Button" CommandName="MakeReservation" HeaderText="Make Reservation" Text="Make" />
                <asp:ButtonField ButtonType="Button" CommandName="ConfirmReservation" HeaderText="Confirm Reservation" Text="Confirm" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="lblTime" runat="server" Text="Select TIme: " Visible="False"></asp:Label>
        <asp:DropDownList ID="ddlTime" runat="server" Visible="False">
            <asp:ListItem>5:00pm</asp:ListItem>
            <asp:ListItem>6:00pm</asp:ListItem>
            <asp:ListItem>7:00pm</asp:ListItem>
            <asp:ListItem>7:30pm</asp:ListItem>
            <asp:ListItem>8:00</asp:ListItem>
            <asp:ListItem>8:30</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblDate" runat="server" Text="Select Date: " Visible="False"></asp:Label>
        <asp:DropDownList ID="ddlDate" runat="server" Visible="False">
            <asp:ListItem>10/27/17</asp:ListItem>
            <asp:ListItem>10/28/17</asp:ListItem>
            <asp:ListItem>10/29/17</asp:ListItem>
            <asp:ListItem>10/30/17</asp:ListItem>
        </asp:DropDownList>
        &nbsp;<asp:Label ID="lblName" runat="server" Text="Name for Reservation: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnShowMyReserv" runat="server" OnClick="btnShowMyReserv_Click" Text="Show My Reservation" />
        <asp:Button ID="btnShowRestReserve" runat="server" OnClick="btnShowRestReserve_Click" Text="Show Restaurant Reservation (Rep only)" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:GridView ID="gvMyReservation" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnRowCommand="gvMyReservation_RowCommand" Visible="False">
            <Columns>
                <asp:BoundField DataField="ReservationID" HeaderText="Reservation ID" />
                <asp:BoundField DataField="RestaurantID" HeaderText="Restaurant ID" />
                <asp:BoundField DataField="RevTime" HeaderText="Time" />
                <asp:BoundField DataField="RevDate" HeaderText="Date" />
                <asp:BoundField DataField="Name" HeaderText="Name on Reservation" />
                <asp:ButtonField ButtonType="Button" CommandName="CancelReservation" HeaderText="Cancel Reservation" Text="Cancel Reservation" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:GridView ID="gvRestRev" runat="server" AllowPaging="True" AutoGenerateColumns="False" Visible="False">
            <Columns>
                <asp:BoundField DataField="ReservationID" HeaderText="Reservation ID" />
                <asp:BoundField DataField="RestaurantID" HeaderText="Restaurant ID" />
                <asp:BoundField DataField="RevTime" HeaderText="Time" />
                <asp:BoundField DataField="RevDate" HeaderText="Date" />
            </Columns>
        </asp:GridView>
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
