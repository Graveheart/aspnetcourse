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


    protected void btnJustShowText_Click(object sender, EventArgs e)
    {
        string enteredText = txtSampleText.Text;
        lblEnterdText.Text = enteredText; 
    }

    protected void btnShowHtmlEncoded_Click(object sender, EventArgs e)
    {
        string enteredText = txtSampleText.Text;
        lblEnterdText.Text = Server.HtmlEncode(enteredText);
    }

}
