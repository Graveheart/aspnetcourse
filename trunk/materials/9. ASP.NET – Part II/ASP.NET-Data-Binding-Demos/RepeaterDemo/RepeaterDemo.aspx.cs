using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<Site> sites = new List<Site>();
        sites.Add(new Site(1, "15 seconds", @"http://www.15seconds.com",
            @"http://www.15seconds.com/graphics/logo.gif"));
        sites.Add(new Site(2, "4GuysFromRolla", @"http://www.4guysfromrolla.com",
            @"http://www.4guysfromrolla.com/images/newbanner.gif"));
        sites.Add(new Site(3, "ASP 101", @"http://www.asp101.com",
            @"http://www.asp101.com/links/images/asp101_120x90.gif"));
        repeaterSites.DataSource = sites;
        repeaterUL.DataSource = sites;
        repeaterImage.DataSource = sites;
        DataBind();
    }
}
