<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" ValidateRequest="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="lbl1" Text="Sample text" runat="server"></asp:Label>
    <br />
    <asp:TextBox ID="txtSampleText" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnJustShowText" runat="server" Text="Show text" OnClick="btnJustShowText_Click" />
    &nbsp;&nbsp; 
    <asp:Button ID="btnShowHtmlEncoded" runat="server" Text="Show text(HTML encoded)" OnClick="btnShowHtmlEncoded_Click" />    
    <br />
    <br />
    <asp:Label ID="lblEnterdText" runat="server" ForeColor="red"></asp:Label>
    
    </form>
    
</body>
</html>
