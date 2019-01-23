<%@ WebHandler Language="C#" Class="FeedNow" %>

using System;
using System.Web;
using System.Net;
using Geodi.Integration;
using System.Collections.Generic;
using System.IO;

public class FeedNow : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        //https://decesw.atlassian.net/wiki/spaces/PAR/pages/86316691/Geodi+Feed+API+-+Besleme+Y+ntemi+APP+GEODI 
        //Web.config üzerinde GEODI Token ve GEODIUrl ayarları yapılmış olmalıdır.

        string Url = Settings.GEODIUrl;
        Url = string.Concat(Url, Url.EndsWith("/") ? "" : "/", "FeedHandler?op=BulkFeed");

        string RequestUrl = Settings.GetRequestUrl("FeedNow.ashx");
        bool lUseRoles = Settings.UseRoles;

        IntegrationObject files = new IntegrationObject();
        files.Contents = new List<ContentObject>();
        foreach (FileInfo file in new DirectoryInfo(context.Server.MapPath("~/SampleDocuments")).GetFiles("*.*"))
        {
            ContentObject item = new ContentObject();
            item.ContentURL = string.Concat(RequestUrl, "/GetContent.ashx?content=", HttpUtility.UrlEncode(file.Name));
            item.DisplayName = file.Name;
            item.ContentDate = file.LastWriteTimeUtc;
            item.Content = new ContentData();
            item.Content.Extension = file.Extension;


            item.MetaData = new List<Geodi.Integration.MetaData>();
            Geodi.Integration.MetaData meta = new Geodi.Integration.MetaData();
            meta.Name = "Alan";
            meta.Value = "FeedTest";
            item.MetaData.Add(meta);


            //Özel yetki tanımlanmış ve GEODI/Settings/RoleProivder altında GetRoles servis adresiniz tanımlanmamışsa bu içerikleri Sistem Yöneticisi dışında kimse göremez.
            if (lUseRoles)
            {
                item.Permission = new Permissions();
                if (file.Name == "sample.xlsx")
                    item.Permission.Permit = new string[] { "Role1", "Role2", "Role3" };
                else
                    item.Permission.Permit = new string[] { "Role1", "Role3" };
            }
            files.Contents.Add(item);
        }



        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
        request.Method = "POST";
        request.Accept = "application/json,*/*; q=0.01";
        request.ContentType = "application/x-www-form-urlencoded";

        //Dikkat ! .Net 3.5 JavascriptSerializer Tarih alanları Json formatında Serializer etmiyor.  Settings.GetSerializer içeriğinde oluşturulan Serializer kullanılmalıdır.
        string PostData = string.Format("UserSession={0}&content={1}", Uri.EscapeDataString(Settings.GEODIToken), Uri.EscapeDataString(Settings.GetSerializer().Serialize(files)));
        byte[] data = System.Text.Encoding.UTF8.GetBytes(PostData);
        request.ContentLength = data.Length;

        using (Stream stream = request.GetRequestStream())
        {
            stream.Write(data, 0, data.Length);
        }

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

        context.Response.Write(responseString);
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}