<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Windows authentication demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table id="tblUser" >
        <tr>
            <td>Authenticated</td>
            <td><span runat="server" id="spnAuthenticated"></span></td>
        </tr>
        <tr>
            <td>User name</td>
            <td><span runat="server" id="spnUserName"></span></td>
        </tr>
        <tr>
            <td>Authentication type</td>
            <td><span runat="server" id="spnAuthenticationType"></span></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
