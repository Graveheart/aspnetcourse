<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="ListControls.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="formListCotrols" runat="server">
    <div>
        <asp:DropDownList ID="dropDownListTowns" runat="server" Width="170px">
            <%--<asp:ListItem>Sofia</asp:ListItem>
            <asp:ListItem>Varna</asp:ListItem>
            <asp:ListItem>Burgas</asp:ListItem>--%>
        </asp:DropDownList><asp:CheckBoxList ID="checkBoxListTowns" runat="server">
        </asp:CheckBoxList></div>
    </form>
</body>
</html>
