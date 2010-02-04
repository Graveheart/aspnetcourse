<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="PageValidation.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox id="TextBoxPhone" runat="server">
        </asp:TextBox>
        <asp:RequiredFieldValidator
	        id="RequiredFieldValidatorPhone"
	        runat="server"
	        ErrorMessage="A telephone number is required"
	        ControlToValidate="TextBoxPhone" >
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator
	        id="RegularExpressionValidatorPhone"
	        runat="server"
	        ErrorMessage="Phone number is not formatted correctly"
	        ControlToValidate="TextBoxPhone"
	        ValidationExpression=
		        "((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" >
        </asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
    </div>
    </form>
</body>
</html>
