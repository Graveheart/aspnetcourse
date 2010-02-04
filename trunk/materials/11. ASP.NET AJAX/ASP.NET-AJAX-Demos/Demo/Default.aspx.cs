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
        if (!Page.IsPostBack)
        {
            DataSet1.TownDataTable townDataTable = new DataSet1.TownDataTable();
            DataSet1TableAdapters.TownTableAdapter adapter = new DataSet1TableAdapters.TownTableAdapter();
            adapter.Fill(townDataTable);
            DropDownListTowns.DataSource = townDataTable;
            DropDownListTowns.DataBind();
        }
    }

    protected void TownChanged(object sender, EventArgs e)
    {
        DataSet1.AddressDataTable addressDataTable = new DataSet1.AddressDataTable();
        DataSet1TableAdapters.AddressTableAdapter adapter = new DataSet1TableAdapters.AddressTableAdapter();
        addressDataTable = adapter.GetDataBy(int.Parse(DropDownListTowns.SelectedValue));
        DropDownListAddresses.DataSource = addressDataTable;
        DropDownListAddresses.DataBind();
    }

    protected void Updating(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(5000);
    }
}