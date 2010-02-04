<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Navigation_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="formNavigation" runat="server">
    <div>
        <asp:Menu ID="menuNavigation" runat="server" DataSourceID="siteMapDataSourceNavigation">
        </asp:Menu>
        <hr />
        <asp:SiteMapDataSource ID="siteMapDataSourceNavigation" runat="server" />
       
        <asp:Menu ID="menuStatic" runat="server" StaticDisplayLevels="1">
            <Items>
                <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                <asp:MenuItem Text="New Item" Value="New Item">
                    <asp:MenuItem Text="New Item" Value="New Item">
                        <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="New Item 1" Value="New Item">
                        <asp:MenuItem Text="New Item" Value="New Item">
                            <asp:MenuItem Text="New Item" Value="New Item">
                                <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                    </asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="New Item" Value="New Item">
                    <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                    <asp:MenuItem Text="New Item" Value="New Item">
                        <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                    <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
            </Items>
        </asp:Menu>
  
    </div>
    </form>
</body>
</html>
