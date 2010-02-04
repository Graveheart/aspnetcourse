<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="SqlDataSourceDemo.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="formSqlDataSourceDemo" runat="server">
    <div>
        <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#336666"
            BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataSourceID="SqlDataSourceNorthwind"
            GridLines="Horizontal">
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <SelectedItemStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <ItemTemplate>
                CompanyName:
                <asp:Label ID="CompanyNameLabel" runat="server" Text='<%# Eval("CompanyName") %>'></asp:Label><br />
                ContactName:
                <asp:Label ID="ContactNameLabel" runat="server" Text='<%# Eval("ContactName") %>'></asp:Label><br />
                PostalCode:
                <asp:Label ID="PostalCodeLabel" runat="server" Text='<%# Eval("PostalCode") %>'></asp:Label><br />
                Telephone:
                <asp:Label ID="PhoneLabel" runat="server" Text='<%# Eval("Phone") %>'></asp:Label><br />
                Address:&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Address") %>'></asp:TextBox><br />
                <br />
            </ItemTemplate>
            <ItemStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        </asp:DataList><asp:SqlDataSource ID="SqlDataSourceNorthwind" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>"
            SelectCommand="SELECT [CompanyName], [ContactName], [PostalCode], [Phone], [Address] FROM [Customers]">
        </asp:SqlDataSource>
        
    </div>
    </form>
</body>
</html>
