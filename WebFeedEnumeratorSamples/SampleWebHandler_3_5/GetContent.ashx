<%@ WebHandler Language="C#" Class="GetContent" %>

using System;
using System.Web;
using System.IO;

public class GetContent : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        HttpRequest Request = context.Request;
        HttpResponse Response = context.Response;
        string content = Request.QueryString.Get("content");
        if (!string.IsNullOrEmpty(content))
        {
            string filePath = context.Server.MapPath(string.Concat("~/SampleDocuments/",content));
            if (File.Exists(filePath))
            {
                string ext = Path.GetExtension(filePath).Substring(0);
                context.Response.Headers["content-disposition"] = string.Concat("attachment; filename=", content);
                context.Response.Headers["Last-Modified"] = File.GetLastWriteTimeUtc(filePath).ToString("ddd, dd MMM yyyy HH:mm:ss 'GMT'");
                context.Response.ContentType = "Application/" + ext;
                context.Response.WriteFile(filePath);
                    return;
            }
            else
                throw new ArgumentException("dosya bulunmadı");
        }

        throw new ArgumentException("content değeri iletilmeli");

    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}