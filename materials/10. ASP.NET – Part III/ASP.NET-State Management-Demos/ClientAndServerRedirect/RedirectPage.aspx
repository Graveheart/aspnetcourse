<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="RedirectPage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="formClientRedirect" runat="server">
    <div>
        <asp:Button ID="buttonServerRedirect" runat="server" Text="Server Redirect" OnClick="buttonServerRedirect_Click"/>
        <asp:Button ID="buttonRedirect" runat="server" Text="Client Redirect" OnClick="buttonRedirect_Click"/>
    </div>
    </form>
</body>
</html>
