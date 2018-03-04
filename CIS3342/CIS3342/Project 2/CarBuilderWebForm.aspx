<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarBuilderWebForm.aspx.cs" Inherits="Project2.CarBuilderWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="lbltxtName">
    
        <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbltxtName" runat="server" Text="Name: "></asp:Label>
        <asp:Label ID="lbltxtPhone" runat="server" style="z-index: 1; left: 451px; top: 89px; position: absolute; height: 21px" Text="Phone number:"></asp:Label>
        <asp:Label ID="lbltxtBuyorLease" runat="server" style="z-index: 1; left: 451px; top: 122px; position: absolute" Text="Buy or Lease"></asp:Label>
        <asp:Label ID="lblDealershiporContact" runat="server" style="z-index: 1; left: 451px; top: 154px; position: absolute" Text="Dealership or Contact"></asp:Label>
        <asp:Label ID="lblCarInfo" runat="server" style="z-index: 1; left: 451px; top: 187px; position: absolute" Text="Car Make, Model, Color: "></asp:Label>
        <br />
        <asp:Label ID="lbltxtAddress" runat="server" style="z-index: 1; left: 451px; top: 54px; position: absolute" Text="Address"></asp:Label>
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lblPhonenumber" runat="server" Text="Phone number:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtPhonenumber" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblBuyorLease" runat="server" Text="Are you interested in buying or leasing?"></asp:Label>
        <br />
        &nbsp;
        <asp:RadioButtonList ID="rblBuyorLease" runat="server">
            <asp:ListItem>Lease</asp:ListItem>
            <asp:ListItem>Buy</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="lblBuyorLease0" runat="server" Text="How would you like to contacted?"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="gvOutPut" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 573px; top: 701px; position: absolute; height: 133px; width: 187px; margin-top: 0px">
            <Columns>
                <asp:BoundField DataField="PackageDescription" HeaderText="Package Description" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
            </Columns>
        </asp:GridView>
        <asp:GridView ID="gvManageReport" runat="server" style="z-index: 1; left: 491px; top: 277px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:RadioButtonList ID="rblDealershiporNo" runat="server">
            <asp:ListItem>Come to the Dealership</asp:ListItem>
            <asp:ListItem>Dealership will contact you</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="btnManagementReport" runat="server" OnClick="btnManagementReport_Click" style="z-index: 1; left: 504px; top: 230px; position: absolute; width: 158px" Text="Management Report" />
        <br />
        <br />
        Let&#39;s Build Your Dream Car!<br />
        <br />
        Choose your Car Make:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlCarMake" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCarMake_SelectedIndexChanged" >
        </asp:DropDownList>
        <br />
        <br />
        Choose your Car Model:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlCarModel" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCarModel_SelectedIndexChanged" >
        </asp:DropDownList>
        <br />
        <br />
        Choose your Color:
        <br />
        <br />
        <asp:RadioButtonList ID="rblColorOption" runat="server">
            <asp:ListItem>Black</asp:ListItem>
            <asp:ListItem>White</asp:ListItem>
            <asp:ListItem>Red</asp:ListItem>
            <asp:ListItem>Blue</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        Please select the available packages for this model:<br />
&nbsp;<asp:GridView ID="gvPackages" runat="server" AutoPostBack="True"  AutoGenerateColumns="False" Height="215px" style="margin-top: 0px" Width="478px" OnRowCommand="gvPackages_RowCommand">
            <Columns>
                <asp:BoundField HeaderText="Package Description" DataField="PackageDescription" />
                <asp:BoundField HeaderText="Package Price" DataField="Price" DataFormatString="{0:c}" />
                <asp:TemplateField HeaderText="Add Package">
                    <ItemTemplate>
                        <asp:Button ID="btnAddPackage" runat="server" Height="32px" Text="Add Package" Width="129px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:ButtonField ButtonType="Button" CommandName="RemovePackages" HeaderText="Remove Packages" Text="Remove " />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="btnBuildCar" runat="server" Height="56px" Text="Build Your Car!" Width="321px" OnClick="btnBuildCar_Click" />
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