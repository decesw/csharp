using Geodi.Integration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Script.Serialization;

namespace SampleApplicationService
{
    public class GetContentsHandler : IHttpHandler
    {
        /// <summary>
        /// You will need to configure this handler in the Web.config file of your 
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: http://go.microsoft.com/?linkid=8101007
        /// </summary>

        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest Request = context.Request;
            HttpResponse Response = context.Response;

            string changeKey = Request.QueryString.Get("changekey");

            DateTime MyChangeKeyStart = DateTime.MinValue;
            if (!string.IsNullOrEmpty(changeKey))
                MyChangeKeyStart = DateTime.Parse(changeKey, System.Globalization.CultureInfo.InvariantCulture);

            var rtn = new IntegrationObject()
            {
                ChangeKey = DateTime.Now.ToString(System.Globalization.CultureInfo.InvariantCulture),
                Contents = new List<ContentObject>()
            };

            string lContentFolder = context.Server.MapPath("~/SampleDocuments");

            string lUrlStart = HttpContext.Current.Request.Url.ToString();
            int idx = lUrlStart.ToLowerInvariant().IndexOf("/getcontents");
            lUrlStart = lUrlStart.Substring(0, idx);
            
            foreach (FileInfo file in new DirectoryInfo(lContentFolder).GetFiles("*.*"))
                if (MyChangeKeyStart < file.LastWriteTime) //changeKey check
                {
                    //string base64 = Convert.ToBase64String(File.ReadAllBytes(file.FullName));
                    //var content = new ContentData() { Content = base64, Extension = file.Extension, ContentId = file.FullName };
                    //rtn.Contents.Add(new ContentObject() { Content = content, DisplayName = file.Name });
                    var contentItem = new ContentObject()
                    {
                        DisplayName = file.Name,
                        ContentURL = lUrlStart + "/Content?id=" + System.Web.HttpUtility.UrlEncode(file.Name),
                        ContentDate = file.LastWriteTime,
                    };
                    rtn.Contents.Add(contentItem);
                }

            var serializer = new JavaScriptSerializer();
            Response.Write(serializer.Serialize(rtn));
            Response.ContentType = "application/json";
        }
    }


}
