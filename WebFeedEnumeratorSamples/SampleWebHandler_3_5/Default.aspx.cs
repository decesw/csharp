using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string lUrl = Settings.GetRequestUrl("default.aspx");
        lblGetRoles.Text = string.Concat(lUrl, "/", "GetRoles.ashx");
        lblGetContets.Text = string.Concat(lUrl, "/", "GetContents.ashx");

    }
}