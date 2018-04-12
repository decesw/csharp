<%@ WebHandler Language="C#" Class="GetRoles" %>

using System;
using System.Web;

public class GetRoles : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        HttpRequest Request = context.Request;
        HttpResponse Response = context.Response;
        /*
        //GEODI/Settings/RoleProvider altına atılan tanım içeriğinde  GEODIRequestHeader:"GEODI_Request" tanımı yapılmışsa bu koşul kullanılabilir. 
        if (Request.Headers["GEODIRequestHeader"] != "...")
            throw new Exception("Bu servis sadece GEODI isteklerine cevap verir");
        */
        string user = Request.QueryString.Get("user");
        if (!string.IsNullOrEmpty(user))
        {
            if (user == "geodi:guest")
                Response.Write("Role2");//Sadece Misafir kullanıcılar görebilir şeklinde ayarlandı. Misafir Kullanıcı örnek olarak kullanıldı.
            else if (user == "ldap:domain\\myuser")
                Response.Write("Role1,Role3");
            else
                Response.Write("Role3");
        }
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}