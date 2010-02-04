<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Localization.aspx.cs" Inherits="_Default" Culture="auto"  UICulture="bg-BG" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="formLocalization" runat="server">
    <div>
        <asp:Label ID="labelWelcome" runat="server" Text="Welcome to our lection" meta:resourcekey="labelWelcomeResource" />
        <br />
        <br />
        <br />
        <asp:Button ID="buttonNext" runat="server" Text="Next" meta:resourcekey="buttonNextResource" Width="120px" /></div>
    </form>
</body>
</html>
