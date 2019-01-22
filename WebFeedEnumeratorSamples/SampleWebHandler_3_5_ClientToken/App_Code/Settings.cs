using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Script.Serialization;

/// <summary>
/// Summary description for Settings
/// </summary>
public static class Settings
{
    public static string GEODIUrl
    {
        get
        {
            return System.Configuration.ConfigurationManager.AppSettings["GEODIUrl"];
        }
    }

    public static string GEODIToken
    {
        get
        {
            string rtn = System.Configuration.ConfigurationManager.AppSettings["GEODIToken"];
            if (string.IsNullOrEmpty(rtn))
                throw new Exception("Lütfen Sistem yönetcinizden 'GEODI Token alıp' web.cofing  dosyasında gerekli ayarı yapınız.");
            return rtn;
        }
    }

    public static string AppClientID
    {
        get
        {
            return System.Configuration.ConfigurationManager.AppSettings["AppClientID"];
        }
    }
    

    public static string GetRequestUrl(string handlerName)
    {
        handlerName = handlerName.ToLowerInvariant();
        string lUrlStart = HttpContext.Current.Request.Url.ToString();
        int idx = lUrlStart.ToLowerInvariant().IndexOf(string.Concat("/", handlerName));
        if (idx != -1)
            lUrlStart = lUrlStart.Substring(0, idx);
        else
        {
            idx = lUrlStart.ToLowerInvariant().IndexOf("?");
            if (idx != -1)
                lUrlStart = lUrlStart.Substring(0, idx);
        }
        return lUrlStart.TrimEnd(new char[] { '\\', '/' });
    }

}