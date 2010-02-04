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
        //DataSetNorthwindTableAdapters.ShippersTableAdapter adapter =
        //    new DataSetNorthwindTableAdapters.ShippersTableAdapter();
        //DataSetNorthwind.ShippersDataTable shippers =
        //    adapter.GetData();
        //gridViewShippers.DataSource = shippers;
        //gridViewShippers.DataBind();
    }
    protected void gridViewShippers_RowEditing(object sender, GridViewEditEventArgs e)
    {
    }
}
