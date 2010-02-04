<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HtmlGenericControl.aspx.cs" Inherits="HtmlGenericControl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>HtmlGenericControl Class</title>
    <meta id="metaInfo" runat="server" />
</head>
<body>
    <form id="formMain" runat="server">    
        
         <input id="txtField" type="text" runat="server" />
         <input id="SubmitButton" type="button" value="Submit" 
            runat="server" onserverclick="SubmitButton_Click" />
    </form></body></html>
