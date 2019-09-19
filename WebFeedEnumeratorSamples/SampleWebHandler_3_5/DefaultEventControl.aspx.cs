using Geodi.Integration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _DefaultEventControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string lUrl = Settings.GetRequestUrl("DefaultEventControl.aspx");
        lblGetEvents.Text= string.Concat(lUrl, "/", "CollectEvents.ashx");

        this.txtEvents.Text = EventServiceHelper.EventsToString();
    }

}