<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Default Page</title>
</head>
<body>
    <form id="MainForm" runat="server">
     <div>
        <h3>
        <asp:Label ID="LabelMessage" runat="server"></asp:Label>
        &nbsp;</h3>
    </div>
    <div>
        <h1>
            Welcome,
            <asp:LoginName ID="LoginNameDemo" runat="server" />
            .</h1>
        <p>
            <asp:LoginView ID="LoginViewDemo" runat="server">
                <RoleGroups>
                    <asp:RoleGroup Roles="Administrators">
                        <ContentTemplate>
                            <h1>
                                Your role is administrator.</h1>
                        </ContentTemplate>
                    </asp:RoleGroup>
                    <asp:RoleGroup Roles="Users">
                        <ContentTemplate>
                            <h1>
                                Your role is user.</h1>
                        </ContentTemplate>
                    </asp:RoleGroup>
                </RoleGroups>
            </asp:LoginView>
            &nbsp;</p>
        <h3>
            <asp:HyperLink ID="HyperLinkDemo" runat="server" NavigateUrl="~/ChangePassword.aspx">Change password</asp:HyperLink>
        </h3>
        <h3>
            <asp:LoginStatus ID="LoginStatusDemo" runat="server" />
            &nbsp;</h3>
        <h3>
            &nbsp;</h3>
    </div>
    </form>
</body>
</html>
