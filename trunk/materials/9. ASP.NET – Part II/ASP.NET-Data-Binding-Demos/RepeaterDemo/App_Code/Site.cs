using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Site
/// </summary>
public class Site
{
    int id;
    string image;
    string url;
    string name;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string URL
    {
        get { return url; }
        set { url = value; }
    }

    public string Image
    {
        get { return image; }
        set { image = value; }
    }

	public Site(int id, string name, string url, string image)
	{
        this.id = id;
        this.name = name;
        this.url = url;
        this.image = image;
	}
}
