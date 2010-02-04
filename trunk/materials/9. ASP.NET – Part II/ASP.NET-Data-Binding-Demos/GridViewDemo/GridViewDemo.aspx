<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="GridViewDemo.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="formGridViewDemo" runat="server">
    <div>
        <asp:GridView ID="gridViewShippers" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan"
            BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Height="166px"
            Width="412px" OnRowEditing="gridViewShippers_RowEditing" AutoGenerateColumns="False" DataKeyNames="ShipperID" DataSourceID="ObjectDataSourceShippers">
            <FooterStyle BackColor="Tan" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="ShipperID" HeaderText="ShipperID" InsertVisible="False"
                    ReadOnly="True" SortExpression="ShipperID" />
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSourceShippers" runat="server" DeleteMethod="Delete"
            InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData"
            TypeName="DataSetNorthwindTableAdapters.ShippersTableAdapter" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_ShipperID" Type="Int32" />
                <asp:Parameter Name="Original_CompanyName" Type="String" />
                <asp:Parameter Name="Original_Phone" Type="String" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="CompanyName" Type="String" />
                <asp:Parameter Name="Phone" Type="String" />
                <asp:Parameter Name="Original_ShipperID" Type="Int32" />
                <asp:Parameter Name="Original_CompanyName" Type="String" />
                <asp:Parameter Name="Original_Phone" Type="String" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="CompanyName" Type="String" />
                <asp:Parameter Name="Phone" Type="String" />
            </InsertParameters>
        </asp:ObjectDataSource>
    
    </div>
    </form>
</body>
</html>
