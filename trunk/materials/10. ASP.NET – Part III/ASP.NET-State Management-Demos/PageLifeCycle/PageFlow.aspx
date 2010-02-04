<%@ Page language="C#" CodeFile="PageFlow.aspx.cs"
    AutoEventWireup="true" Inherits="_Default" %>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title>Page Flow</title>
    </head>
    <body>
        <form id="formMain" runat="server">
        <div>
            <asp:Label id="LabelInfo" runat="server" EnableViewState="False">
            </asp:Label>
            <asp:Button id="ButtonSubmit" runat="server" Text="Proceed">
            </asp:Button>
        </div>
        </form>
    </body>
</html>
