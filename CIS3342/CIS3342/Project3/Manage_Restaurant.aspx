<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manage_Restaurant.aspx.cs" Inherits="Project3.Manage_Restaurant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
             <h1>Welcome to Restaurant Review </h1>
            <h2>Create/Manage Restaurant</h2>
             <br />
             <asp:Button ID="btnManageRestaurant" runat="server" Height="86px" OnClick="btnManageRestaurant_Click" Text="Create/Manage Restaurant" Width="262px" />
             <asp:Button ID="btnManageReviews" runat="server" Height="86px" OnClick="btnManageReviews_Click" Text="Create/Manage Reviews" Width="262px" />
             <asp:Button ID="btnManageReservation" runat="server" Height="86px" OnClick="btnManageReservation_Click" Text="Create/Manage Reservation" Width="262px" />


             <asp:Button ID="btnLogOut" runat="server" Height="86px" OnClick="btnManageLogOut_Click" Text="Log Out" Width="262px" />


             <br />
             <br />
             <asp:Label ID="Label1" runat="server" Text="Create Restaurant: "></asp:Label>
             <br />
             <asp:Label ID="Label2" runat="server" Text="Restaurant Name: "></asp:Label>
             <asp:TextBox ID="txtRestName" runat="server"></asp:TextBox>
             <br />
             <asp:Label ID="Label3" runat="server" Text="Category: "></asp:Label>
             <asp:DropDownList ID="ddlCategory" runat="server">
             </asp:DropDownList>
             <br />
             <asp:Label ID="Label4" runat="server" Text="City: "></asp:Label>
             <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
             <br />
             <asp:Label ID="Label5" runat="server" Text="State: "></asp:Label>
             <asp:TextBox ID="txtState" runat="server" Width="37px"></asp:TextBox>
             <br />
             <br />
             <asp:Button ID="btnAddRestaurant" runat="server" Text="Add Restaurant" OnClick="btnAddRestaurant_Click" />
             <br />
             <br />
             <asp:Label ID="Label6" runat="server" Text="Search Restaurant (By Category) : "></asp:Label>
             <asp:TextBox ID="txtSearchRest" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;<asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
&nbsp;<br />
             <br />
             <asp:GridView ID="gvSearchRest" runat="server" AllowPaging="True" AutoGenerateColumns="False">
                 <Columns>
                     <asp:BoundField DataField="RestaurantName" HeaderText="Restaurant Name" />
                     <asp:BoundField DataField="CategoryName" HeaderText="Category Name" />
                     <asp:BoundField DataField="City" HeaderText="City" />
                     <asp:BoundField DataField="RestState" HeaderText="State" />
                     <asp:BoundField DataField="UserName" HeaderText="Username" />
                 </Columns>
             </asp:GridView>
             <br />
             <br />
             <asp:Button ID="btnShowMyRest" runat="server" Text="Show My Restaurant" OnClick="btnShowMyRest_Click" />
             <br />
             <br />
             <asp:GridView ID="gvMyRestaurant" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnRowCommand="gvMyRestaurant_RowCommand">
                 <Columns>
                     <asp:BoundField DataField="RestaurantID" HeaderText="Restaurant ID" />
                     <asp:BoundField DataField="RestaurantName" HeaderText="Restaurant Name" />
                     <asp:BoundField DataField="CategoryName" HeaderText="Category Name" />
                     <asp:BoundField DataField="City" HeaderText="City" />
                     <asp:BoundField DataField="RestState" HeaderText="State" />
                     <asp:ButtonField ButtonType="Button" CommandName="EditRestaurant" HeaderText="Modify Restaurant" Text="Edit " />
                     <asp:ButtonField ButtonType="Button" CommandName="DeleteRestaurant" HeaderText="Delete Restaurant" Text="Delete" />
                 </Columns>
             </asp:GridView>
             <br />
             <asp:Label ID="lblMessage" runat="server" Text="Label" Visible="False"></asp:Label>
             <br />
             <br />


    </div>
    </form>
</body>
</html>
