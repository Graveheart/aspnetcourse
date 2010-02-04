<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style.css" rel="stylesheet" type="text/css" />
    <title>ASP.NET AJAX Demo </title>
</head>
<body>
    <form id="formDemo" runat="server">
        <asp:ScriptManager ID="ScriptManagerDemo" runat="server" />
        
        <div class="div">
            <asp:Label ID="LabelFullPostBack" runat="server" 
                Text="ASP.NET Regular controls causing full postback: ">
            </asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DropDownListFullPostBack" runat="server" AutoPostBack="true" Width="135px">
                <asp:ListItem Text="Item 1" />
                <asp:ListItem Text="Item 2" />
                <asp:ListItem Text="Item 3" />
            </asp:DropDownList>
            &nbsp&nbsp&nbsp&nbsp
            <asp:Button ID="ButtonFullPostBack" runat="server" Text="Full Post Back" /><br />
        </div>    
        <hr />
        
        <div class="div">
            <asp:UpdatePanel ID="UpdatePanel" runat="server" >
                <ContentTemplate>
                    <asp:Label ID="LabelPartialPostBack" runat="server" 
                        Text="Controls inside an update panel causing partial postback: " Width="500px"></asp:Label>
                    <br />
                    <asp:DropDownList ID="DropDownListTowns" runat="server" DataTextField="Name" DataValueField="TownID" 
                        AutoPostBack="true" OnSelectedIndexChanged="TownChanged" Width="226px">
                    </asp:DropDownList>
                    <asp:DropDownList ID="DropDownListAddresses" runat="server" DataTextField="AddressText" 
                        DataValueField="AddressID" Width="223px">
                    </asp:DropDownList>
                    <br />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <hr />

        <div class="div">
            <asp:Label ID="LabelMoreControls" runat="server" 
                Text="More controls inside an update panel (causing partial postback): ">
            </asp:Label>
            <br />
            <asp:UpdateProgress ID="UpdateProgressDemo" runat="server">
                <ProgressTemplate>
                    Updating ...
                </ProgressTemplate>
            </asp:UpdateProgress>
            <br />
            
            <asp:UpdatePanel ID="UpdatePanelWithTriggers" runat="server" >
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="DropDownListTowns" EventName="SelectedIndexChanged" />
                </Triggers>
                <ContentTemplate>
                    <% =DateTime.Now.ToString("hh:mm:ss") %>
                    <asp:Button ID="ButtonUpdate" runat="server" Text="Partial Post Back" OnClick="Updating" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>