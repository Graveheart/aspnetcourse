<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="ValidationGroup.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Validation Group Demo</title>
</head>
<body>
    <form id="formValidation" runat="server">
    <div>
        <asp:TextBox id="TextBoxFirstName" runat="server" ValidationGroup="ValidationGroupNames"></asp:TextBox>
        <asp:RequiredFieldValidator
	        id="RequiredFieldValidatorFirstName"
	        runat="server"
	        ErrorMessage="First name is required"
	        ControlToValidate="TextBoxFirstName" >
        </asp:RequiredFieldValidator>
        <br />
        <asp:TextBox id="TextBoxLastName" runat="server" ValidationGroup="ValidationGroupNames"></asp:TextBox>
        <asp:RequiredFieldValidator
	        id="RequiredFieldValidatorLastName"
	        runat="server"
	        ErrorMessage="Last name is required"
	        ControlToValidate="TextBoxLastName" >
        </asp:RequiredFieldValidator>
        <br />
        <asp:TextBox id="TextBoxPhone" runat="server" ValidationGroup="ValidationGroupPhone"></asp:TextBox>
        <asp:RequiredFieldValidator
	        id="RequiredFieldValidatorPhone"
	        runat="server"
	        ErrorMessage="A telephone number is required"
	        ControlToValidate="TextBoxPhone"
	        Display="Dynamic" >
        </asp:RequiredFieldValidator>
      <%--  <asp:RegularExpressionValidator
	        id="RegularExpressionValidatorPhone"
	        runat="server"
	        ErrorMessage="Phone number is not formatted correctly"
	        ControlToValidate="TextBoxPhone"
	        ValidationExpression=
		        "\d{3}-\d{4}" 
		    Display="Dynamic" >
        </asp:RegularExpressionValidator>--%>
        <br />
        <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" 
        OnClick="ButtonSubmit_Click" />
    </div></form>
</body>
</html>
