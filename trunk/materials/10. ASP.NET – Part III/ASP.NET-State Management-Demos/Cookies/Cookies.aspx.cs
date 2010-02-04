using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void buttonLogMe_Click(object sender, EventArgs e)
    {
        HttpCookie cookie = new HttpCookie("UserName", "You are logged in!");
        cookie.Expires = DateTime.Now.AddMinutes(1);

        Response.Cookies.Add(cookie);
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies["UserName"];
        if (cookie != null)
        {
            DateTime expirationDate = cookie.Expires;
            string text = "Cookie expires on:" + expirationDate.ToString(); 
            Response.Write(text);

            LabelLoggedIn.Text = cookie.Value;
        }
    }

}
