<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="CompareValidatorDemo.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Compare Validator Demo</title>
</head>
<body>
    <form id="formCompareValidator" runat="server">
    <div>
        <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="TextBoxRepeatPassword"
            runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidatorPassword" runat="server" ControlToCompare="TextBoxPassword"
            ControlToValidate="TextBoxRepeatPassword" Display="Dynamic"
            ErrorMessage="Password doesn't match"></asp:CompareValidator>
        <br />
        <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" />
    </div>
    </form>
</body>
</html>
