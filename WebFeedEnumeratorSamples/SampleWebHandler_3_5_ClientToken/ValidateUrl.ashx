<%@ WebHandler Language="C#" Class="ValidateUrl" %>

using System;
using System.Web;

public class ValidateUrl : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        HttpRequest Request = context.Request;
        HttpResponse Response = context.Response;
        /*
        //GEODI/Settings/ClientToken altına atılan tanım içeriğinde  GEODIRequestHeader:"..." tanımı yapılmışsa bu koşul kullanılabilir. 
        if (Request.Headers["GEODIRequestHeader"] != "...")
            throw new Exception("Bu servis sadece GEODI isteklerine cevap verir");
        */
        string vData = Request.QueryString.Get("v");
        if (!string.IsNullOrEmpty(vData))
        {
            byte[] pData=System.Security.Cryptography.ProtectedData.Unprotect(
                Convert.FromBase64String(vData),
                null,
                 System.Security.Cryptography.DataProtectionScope.LocalMachine);
            string Data = System.Text.Encoding.UTF8.GetString(pData);

            if (Data.StartsWith("MyData"))
            {
                Response.Write("OK");
                    return;
            }
        }
        Response.Write("NOK");
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}