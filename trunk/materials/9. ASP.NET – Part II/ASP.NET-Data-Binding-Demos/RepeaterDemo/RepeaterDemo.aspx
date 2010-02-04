<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RepeaterDemo.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="formRepeaterDemo" runat="server">
        <div>
            <asp:Repeater ID="repeaterSites" runat="server">
                <ItemTemplate>
                    <%# DataBinder.Eval(Container.DataItem, "Id") %>
                    ,
                    <%# DataBinder.Eval(Container.DataItem, "Name") %>
                    ,
                    <%# DataBinder.Eval(Container.DataItem, "URL") %>
                    ,
                    <%# DataBinder.Eval(Container.DataItem, "Image") %>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
            <asp:Repeater ID="repeaterUL" runat="server">
                <HeaderTemplate>
                    <ul>
                </HeaderTemplate>
                <ItemTemplate>
                    <li><a href="<%#DataBinder.Eval(
                       Container.DataItem,"URL") %>">
                        <%# DataBinder.Eval(
                       Container.DataItem, "Name") %>
                    </a></li>
                </ItemTemplate>
                <FooterTemplate>
                    </ul>
                </FooterTemplate>
            </asp:Repeater>
            <asp:Repeater ID="repeaterImage" runat="server">
                <ItemTemplate>
                    <a href="<%# DataBinder.Eval(Container.DataItem,
                                 "URL") %>">
                        <img src="<%#DataBinder.Eval(
                     Container.DataItem, "Image") %>" border="0" alt="<%# DataBinder.Eval(
                    Container.DataItem, "Name") %>" />
                    </a>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
