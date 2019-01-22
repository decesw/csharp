using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string lUrl = Settings.GetRequestUrl("default.aspx");
        lblValidateUrl.Text = string.Concat(lUrl, "/", "ValidateUrl.ashx?v={ClientValidator}");
        lblClientID.Text = Settings.AppClientID;
    }

    protected void btnUserLoginUrl_Click(object sender, EventArgs e)
    {
        string Url = Settings.GEODIUrl;
        Url = string.Concat(Url, Url.EndsWith("/") ? "" : "/", "TokenHandler?op=GetAutoLoginLink");


        string MyValidator = string.Concat("MyData",Guid.NewGuid());

        byte []MyValidatorBytes=System.Security.Cryptography.ProtectedData.Protect(
            System.Text.Encoding.UTF8.GetBytes(MyValidator), null, 
            System.Security.Cryptography.DataProtectionScope.LocalMachine);

        MyValidator = Convert.ToBase64String(MyValidatorBytes);




        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
        request.Method = "POST";
        request.Accept = "application/json,*/*; q=0.01";
        request.ContentType = "application/x-www-form-urlencoded";

        
        string PostData = string.Format("ClientID={0}&ClientValidator={1}&LoginUser={2}&UserSession={3}",
            Settings.AppClientID,
            Uri.EscapeDataString(MyValidator),
            Uri.EscapeDataString(txtUserFor.Text),
            Uri.EscapeDataString(Settings.GEODIToken)
            );
        byte[] data = System.Text.Encoding.ASCII.GetBytes(PostData);
        request.ContentLength = data.Length;

        using (Stream stream = request.GetRequestStream())
        {
            stream.Write(data, 0, data.Length);
        }
        try
        {
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            lnkGEODIForUser.Visible = true;
            lnkGEODIForUser.Text = responseString;
            lnkGEODIForUser.NavigateUrl = responseString;
        }
        catch (WebException Ex)
        {

            lnkGEODIForUser.NavigateUrl = "#";
            lnkGEODIForUser.Visible = true;
            lnkGEODIForUser.Text = Ex.Message;

            //using (Stream strm = Ex.Response.GetResponseStream())
            //using (StreamReader rdr = new StreamReader(strm))
            //{
            //    string Response = rdr.ReadToEnd();

            //}


        }
    }
}