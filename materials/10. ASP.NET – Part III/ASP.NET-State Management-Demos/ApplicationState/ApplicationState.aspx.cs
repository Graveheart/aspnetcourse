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
        Application.Lock();
        Application["Users"] = (int)Application["Users"] + 1;
        Application.UnLock();
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);

        if (Application["Users"] == null)
        {
            Application["Users"] = 0;
        }
        labelLoads.Text = Application["Users"].ToString();
    }
}
