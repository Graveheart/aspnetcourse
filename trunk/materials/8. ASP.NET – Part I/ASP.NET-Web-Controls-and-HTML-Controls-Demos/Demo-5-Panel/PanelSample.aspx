<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PanelSample.aspx.cs" Inherits="PanelSample" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Panel Sample</title>
</head>
<body>
    <h3>Panel Example</h3>

    <form id="FormMain" runat="server" >

        <asp:Panel ID="PanelEx" runat="server"
            BackColor="gainsboro"
            Height="200px"
            Width="300px">

            PanelSample: Here is some static content...
            <br />

        </asp:Panel>

        <br /><br />
        
        Generate Labels:
        <asp:DropDownList id="DropDownLabels" runat="server">
            <asp:ListItem Value="0">0</asp:ListItem>
            <asp:ListItem Value="1">1</asp:ListItem>
            <asp:ListItem Value="2">2</asp:ListItem>
            <asp:ListItem Value="3">3</asp:ListItem>
            <asp:ListItem Value="4">4</asp:ListItem>
        </asp:DropDownList>

        <br />
        <br />
        Generate TextBoxes:
        <asp:DropDownList id="DropDownTextBoxes" runat="server">
            <asp:ListItem Value="0">0</asp:ListItem>
            <asp:ListItem Value="1">1</asp:ListItem>
            <asp:ListItem Value="2">2</asp:ListItem>
            <asp:ListItem Value="3">3</asp:ListItem>
            <asp:ListItem Value="4">4</asp:ListItem>
        </asp:DropDownList>

        <br /><br />
        <asp:CheckBox id="CheckBox" Text="Hide Panel" runat="server"/>
            
        <br /><br />
        <asp:Button ID="ButtonRefresh" Text="Refresh Panel" runat="server"/>


    </form>
</body>
</html>
