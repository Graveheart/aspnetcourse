<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomControlTest.aspx.cs" Inherits="CustomControlTest" %>
<%@ Register TagPrefix="aspSample" Namespace="Test.CustomControls"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <aspSample:WelcomeLabel Text="Hello" ID="WelcomeLabel1" 
          runat="server" BackColor="Wheat" ForeColor="SaddleBrown" />
       
    </div>
    </form>
</body>
</html>
