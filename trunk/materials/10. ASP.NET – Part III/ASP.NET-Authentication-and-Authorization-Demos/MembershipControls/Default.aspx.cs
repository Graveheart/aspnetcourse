using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MembershipUser currentUser = Membership.GetUser();

        if (Roles.IsUserInRole("Administrators"))
        {
            LabelMessage.Text += "You are an administrator.";
        }
        if (Roles.IsUserInRole("Users"))
        {
            LabelMessage.Text += "You are an user.";
        }
    }
}
