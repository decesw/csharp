<%@ WebHandler Language="C#" Class="GetText" %>

using System;
using System.Web;
using System.IO;

public class GetText : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        HttpRequest Request = context.Request;
        HttpResponse Response = context.Response;
        string content = Request.QueryString.Get("content");
        if (!string.IsNullOrEmpty(content))
        {
            context.Response.Write("SampleTextData");
            return;
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