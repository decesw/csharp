
<%@ WebHandler Language="C#" Class="GetContents" %>

using System;
using System.Web;
using System.IO;
using Geodi.Integration;
using System.Collections.Generic;

public class GetContents : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        HttpRequest Request = context.Request;
        HttpResponse Response = context.Response;

        string changeKey = Request.QueryString.Get("changekey");
        DateTime MyChangeKeyStart = DateTime.MinValue;
        if (!string.IsNullOrEmpty(changeKey))
            MyChangeKeyStart = DateTime.Parse(changeKey, System.Globalization.CultureInfo.InvariantCulture);

        IntegrationObject rtn = new IntegrationObject()
        {
            ChangeKey = DateTime.Now.ToString(System.Globalization.CultureInfo.InvariantCulture),
            Contents = new List<ContentObject>()
        };

        string RequestUrl = Settings.GetRequestUrl("GetContents.ashx");
        bool lUseRoles = Settings.UseRoles;


        foreach (FileInfo file in new DirectoryInfo(context.Server.MapPath("~/SampleDocuments")).GetFiles("*.*"))
            if (MyChangeKeyStart < file.LastWriteTime) //changeKey check
            {
                var item = new ContentObject()
                {
                    ContentURL = string.Concat(RequestUrl + "/GetContent.ashx?content=" + System.Web.HttpUtility.UrlEncode(file.Name)),
                    ContentDate = file.LastWriteTimeUtc,
                    DisplayName=file.Name
                };
                //Özel yetki tanımlanmış ve GEODI/Settings/RoleProivder altında GetRoles servis adresiniz tanımlanmamışsa bu içerikleri Sistem Yöneticisi dışında kimse göremez.
                if (lUseRoles)
                {
                    item.Permission = new Permissions();
                      if (file.Name == "sample.xlsx")
                    item.Permission.Permit = new string[] { "Role1", "Role2", "Role3" };
                else
                    item.Permission.Permit = new string[] { "Role1", "Role3" };
                }

                rtn.Contents.Add(item);
            }

        Response.ContentType = "application/json";
        //Dikkat ! .Net 3.5 JavascriptSerializer Tarih alanları Json formatında Serializer etmiyor.  Settings.GetSerializer içeriğinde oluşturulan Serializer kullanılmalıdır.
        Response.Write(Settings.GetSerializer().Serialize(rtn));


    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}