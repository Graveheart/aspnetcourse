<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Buttons.aspx.cs" Inherits="Buttons" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="formMain" runat="server">
        
        <asp:Button ID="ButtonEx" 
            CommandName="ButtonEx" 
            runat="server" 
            OnClick="OnBtnClick"
            OnCommand="OnCommand" 
            Text="Normal Button" />
        <br />
        <asp:LinkButton ID="LinkButtonEx"
            runat="server"
            OnClick="OnBtnClick"
            Text="Link Button"
            CommandName="LinkButtonEx"
            OnCommand="OnCommand"
            />
        <br />
        <asp:ImageButton ID="ImageButtonEx"
            runat="server"
            CommandName="ImageButtonEx"
            ImageUrl="~/images/DotNet_Logo_Small.gif"
            OnCommand="OnCommand"
            OnClick="OnBtnClick"
            />        
        <br />
        <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>

    </form>
</body>
</html>
