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

public partial class PanelSample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Show/Hide Panel Contents

        if (CheckBox.Checked)
        {
            PanelEx.Visible = false;
        }
        else
        {
            PanelEx.Visible = true;
        }

        // Generate label controls

        int numlabels = int.Parse(DropDownLabels.SelectedItem.Value);

        for (int i = 1; i <= numlabels; i++)
        {
            Label l = new Label();
            l.Text = "Label" + i.ToString();
            l.ID = "Label" + i.ToString();
            PanelEx.Controls.Add(l);
            PanelEx.Controls.Add(new LiteralControl("<br>"));
        }

        // Generate textbox controls

        int numtexts = int.Parse(DropDownTextBoxes.SelectedItem.Value);

        for (int i = 1; i <= numtexts; i++)
        {
            TextBox t = new TextBox();
            t.Text = "TextBox" + i.ToString();
            t.ID = "TextBox" + i.ToString();
            PanelEx.Controls.Add(t);
            PanelEx.Controls.Add(new LiteralControl("<br>"));
        }
    }
}
