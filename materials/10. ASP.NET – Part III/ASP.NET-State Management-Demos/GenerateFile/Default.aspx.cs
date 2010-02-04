using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Imaging;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Clear();

        Bitmap generatedImage = new Bitmap(200, 200);     
        Graphics gr = Graphics.FromImage(generatedImage);
        gr.FillRectangle(Brushes.MediumSeaGreen, 0, 0, 200, 200);
        gr.FillPie(Brushes.Yellow, 25, 25,150, 150, 0, 45);
        gr.FillPie(Brushes.Green, 25, 25, 150, 150, 45, 315);

        //set response header and write the image into response stream
        Response.ContentType = "image/gif";
        generatedImage.Save(Response.OutputStream,ImageFormat.Gif);
    }
}
