using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class HtmlGenericControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        metaInfo.Attributes["NAME"] = "description";
        metaInfo.Attributes["CONTENT"] =
           "My ASP.NET page was generated on: " + DateTime.Now.ToString();
    }

    protected void SubmitButton_Click(Object sender, EventArgs e)
    {
        Response.Write("You entered: <b>" + txtField.Value + "</b>");
    }

}
