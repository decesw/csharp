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
                Response.Write("Role2");//Sadece Misafir kullanıcılar görebilir şeklinde ayarlandı. Misafir Kullanıcı örnek olarak kullanıldı. // Simple
            else if (user == "ldap:domain\\myuser")
                Response.Write("Role1,Role3"); // Simple
            else if (user == "ldap:domain\\myuser2")
                Response.Write("{Conditions:['(Role2) and (Role1,Role3)']}"); //Advanced - Role2 ye ve Role1,Role3 den birine aynı anda izin veren dokümanları görebilir.
            else if (user == "ldap:domain\\myuser3")
            {
                Geodi.Integration.RestApi.RoleList perms = new Geodi.Integration.RestApi.RoleList();
                perms.Conditions = new System.Collections.Generic.List<string>();
                //Advanced - Role2 ye ve Role1,Role3 den birine aynı anda izin veren dokümanları görebilir.
                perms.Conditions.Add("(Role2) and (Role1,Role3)");
                perms.WriteTo(Response, true);
            }
            else
                Response.Write("Role3");// Simple
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