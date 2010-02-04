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

    }

    protected void buttonAddLoad_Click(object sender, EventArgs e)
    {
        Session["Clicks"] = (int)Session["Clicks"] + 1;
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);

        if (Session["Clicks"] == null)
        {
            Session["Clicks"] = 0;
        }
        LabelLoads.Text = Session["Clicks"].ToString();
    }
}
