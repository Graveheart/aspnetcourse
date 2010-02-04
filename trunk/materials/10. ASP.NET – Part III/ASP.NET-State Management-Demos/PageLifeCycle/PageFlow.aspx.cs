using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, System.EventArgs e)
    {
        LabelInfo.Text += "Page.Load event handled.<br />";
        if (Page.IsPostBack)
        {
            LabelInfo.Text +=
              "<b>This is not the first time you've seen this page.</b><br />";
        }
    }
    protected void Page_Init(object sender, System.EventArgs e)
    {
        LabelInfo.Text += "Page.Init event handled.<br />";
    }
    protected void Page_PreRender(object sender, System.EventArgs e)
    {
        LabelInfo.Text += "Page.PreRender event handled.<br />";
    }
    protected void Page_Unload(object sender, System.EventArgs e)
    {
        // This text never appears because the HTML is already
        // rendered for the page at this point.
        LabelInfo.Text += "Page.Unload event handled.<br />";
    }
}
