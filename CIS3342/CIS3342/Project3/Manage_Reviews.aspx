<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manage_Reviews.aspx.cs" Inherits="Project3.Manage_Reviews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Welcome to Restaurant Review </h1>
        <h2>Create/Manage Reviews</h2>
             <br />
             <asp:Button ID="btnManageRestaurant" runat="server" Height="86px" Text="Create/Manage Restaurant" Width="262px" OnClick="btnManageRestaurant_Click" />
             <asp:Button ID="btnManageReviews" runat="server" Height="86px" Text="Create/Manage Reviews" Width="262px" OnClick="btnManageReviews_Click" />
             <asp:Button ID="btnManageReservation" runat="server" Height="86px" Text="Create/Manage Reservation" Width="262px" OnClick="btnManageReservation_Click" />


             <asp:Button ID="btnLogOut" runat="server" Height="86px" OnClick="btnManageLogOut_Click" Text="Log Out" Width="262px" />


             <br />
        <br />
             <asp:Label ID="Label6" runat="server" Text="Search Restaurant (By Restaurant Name) : "></asp:Label>
             <asp:TextBox ID="txtSearchRest" runat="server"></asp:TextBox>
             <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
        <br />
        <br />
             <asp:GridView ID="gvSearchRest" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnRowCommand="gvSearchRest_RowCommand">
                 <Columns>
                     <asp:BoundField DataField="RestaurantID" HeaderText="Restaurant ID" />
                     <asp:BoundField DataField="RestaurantName" HeaderText="Restaurant Name" />
                     <asp:BoundField DataField="CategoryName" HeaderText="Category Name" />
                     <asp:BoundField DataField="City" HeaderText="City" />
                     <asp:BoundField DataField="RestState" HeaderText="State" />
                     <asp:BoundField DataField="UserName" HeaderText="Username" />
                     <asp:ButtonField ButtonType="Button" CommandName="WriteReviews" HeaderText="Write Reviews" Text="Write" />
                     <asp:ButtonField ButtonType="Button" CommandName="SubmitReviews" HeaderText="Submit Review" Text="Submit" />
                     <asp:ButtonField ButtonType="Button" CommandName="SeeReviews" HeaderText="See Reviews" Text="View" />
                 </Columns>
             </asp:GridView>
        <br />
        <asp:Label ID="lblRating" runat="server" Text="Rate this restaurant below: "></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblRating0" runat="server" Text="Rate the service: "></asp:Label>
        <br />
        <asp:RadioButtonList ID="rbRating" runat="server">
            <asp:ListItem Value="1 ">1 Star</asp:ListItem>
            <asp:ListItem Value="2 ">2 Star</asp:ListItem>
            <asp:ListItem Value="3 ">3 Star</asp:ListItem>
            <asp:ListItem Value="4 ">4 Star</asp:ListItem>
            <asp:ListItem Value="5 ">5 Star</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="lblPriceRange" runat="server" Text="Rate the price: "></asp:Label>
        <br />
        <asp:RadioButtonList ID="rbPriceRange" runat="server">
            <asp:ListItem Value="1 ">1 Cheapest</asp:ListItem>
            <asp:ListItem Value="2 ">2 Cheap</asp:ListItem>
            <asp:ListItem Value="3 ">3 Fair</asp:ListItem>
            <asp:ListItem Value="4 ">4 Expensive</asp:ListItem>
            <asp:ListItem Value="5 ">5 Very Expensive</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="lblReviews" runat="server" Text="Insert your comment here: "></asp:Label>
        <br />
        <asp:TextBox ID="txtReviews" runat="server" Height="67px" TextMode="MultiLine" Width="398px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="gvReviewsByID" runat="server" AutoGenerateColumns="False" Visible="False">
            <Columns>
                <asp:BoundField DataField="RestaurantID" HeaderText="Restaurant ID" />
                <asp:BoundField DataField="ReviewID" HeaderText="Review ID" />
                <asp:BoundField DataField="RevRating" HeaderText="Rating" />
                <asp:BoundField DataField="RevPriceRange" HeaderText="Price Range" />
                <asp:BoundField DataField="RevReviews" HeaderText="Reviews" />
                <asp:BoundField DataField="UserName" HeaderText="User Name" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="btnMyReview" runat="server" OnClick="btnMyReview_Click" Text="See Your Review" />
        <br />
        <br />
        <asp:GridView ID="gvMyReviews" runat="server" AutoGenerateColumns="False" OnRowCommand="gvMyReviews_RowCommand">
            <Columns>
                <asp:BoundField DataField="ReviewID" HeaderText="Review ID" />
                <asp:BoundField DataField="RestaurantID" HeaderText="Restaurant ID" />
                <asp:BoundField DataField="RevRating" HeaderText="Rating" />
                <asp:BoundField DataField="RevPriceRange" HeaderText="Price Range" />
                <asp:BoundField DataField="RevReviews" HeaderText="Reviews" />
                <asp:ButtonField ButtonType="Button" CommandName="EditMyReviews" HeaderText="Edit Reviews" Text="Edit" />
                <asp:ButtonField ButtonType="Button" CommandName="UpdateMyReviews" HeaderText="Update Reviews" Text="Update" />
                <asp:ButtonField ButtonType="Button" CommandName="DeleteMyReviews" HeaderText="Delete Reviews" Text="Delete" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="lblError" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
