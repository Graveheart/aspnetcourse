<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BindingControls.aspx.cs"
    Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="formBindingControls" runat="server">
        <asp:DropDownList ID="lstOccupation" AutoPostBack="true"
         runat="server">
            <asp:ListItem>PM</asp:ListItem>
            <asp:ListItem>Tester</asp:ListItem>
            <asp:ListItem>User</asp:ListItem>
        </asp:DropDownList>
        <p>
            You selected:
            <asp:Label ID="lblSelectedValue" Text="<%# lstOccupation.SelectedItem.Text %>" runat="server" />
        </p>
    </form>
</body>
</html>
