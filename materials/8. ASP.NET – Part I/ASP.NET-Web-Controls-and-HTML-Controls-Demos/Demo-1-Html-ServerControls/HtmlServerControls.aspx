<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HtmlServerControls.aspx.cs" Inherits="Demo_1_Html_ServerControls_HtmlServerControls" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Html Server Controls</title>
</head>
<body>
    <form id="formMain" runat="server">    
        
         <input id="txtField" type="text" runat="server" />
         <input id="SubmitButton" type="button" value="Submit" 
            runat="server" onserverclick="SubmitButton_Click" />
    
    </form>
</body>
</html>
