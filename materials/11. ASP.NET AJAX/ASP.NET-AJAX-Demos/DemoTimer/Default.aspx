<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="HeadDemo" runat="server">
    <title>ASP.NET AJAX Demo - Timer</title>
</head>
<body>
    <form id="formTimer" runat="server">
        <asp:ScriptManager ID="ScriptManagerDemo" runat="server" />
            <div class="div">
                <asp:UpdatePanel runat='server' ID='UpdatePanelTimer'>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="TimerDemo" EventName="Tick" />
                    </Triggers> 
                    <ContentTemplate>
                        <asp:Label ID="LabelTimer" runat="server" 
                            Text="AJAX Timer updates time per 5 seconds: ">
                        </asp:Label>
                        <% =DateTime.Now.ToString("hh:mm:ss") %>
                    </ContentTemplate>
                </asp:UpdatePanel>

                <asp:Timer ID="TimerDemo" runat="Server" Interval="5000" >
                </asp:Timer>
            </div>
    </form>
</body>
</html>