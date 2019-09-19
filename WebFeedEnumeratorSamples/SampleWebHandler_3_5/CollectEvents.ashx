<%@ WebHandler Language="C#" Class="CollectEvents" %>

using System;
using System.Collections.Generic;
using System.Web;
using System.IO;

public class CollectEvents : IHttpHandler
{



    public void ProcessRequest(HttpContext context)
    {
        HttpRequest Request = context.Request;
        HttpResponse Response = context.Response;

        EventEntry e = new EventEntry();
        e.EventName = Request.QueryString.Get("event");
        e.ConetntID = Request.QueryString.Get("contentid");
        e.WorkspaceName = Request.QueryString.Get("wsName");

        lock (EventServiceHelper.EventList) {
            if (EventServiceHelper.EventList.Count > 100)
                EventServiceHelper.EventList.RemoveAt(0);
            EventServiceHelper.EventList.Add(e);
        }

        //Response.Write("1"); //1 or emtpy OK, 0 Cancel
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}