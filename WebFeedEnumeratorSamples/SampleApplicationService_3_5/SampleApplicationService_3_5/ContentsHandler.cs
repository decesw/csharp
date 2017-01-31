using System;
using System.IO;
using System.Web;

namespace SampleApplicationService
{
    public class ContentsHandler : IHttpHandler
    {
        /// <summary>
        /// You will need to configure this handler in the Web.config file of your 
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: http://go.microsoft.com/?linkid=8101007
        /// </summary>
    
        public bool IsReusable
        {
            // Return false in case your Managed Handler cannot be reused for another request.
            // Usually this would be false in case you have some state information preserved per request.
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest Request = context.Request;
            HttpResponse Response = context.Response;

            string id = Request.QueryString.Get("id");
            string lFilePath = Path.Combine(context.Server.MapPath("~/SampleDocuments"),id);
            string ext = Path.GetExtension(lFilePath).Substring(0);
            context.Response.AddHeader("content-disposition", "attachment; filename=" + id);
            context.Response.ContentType = "Application/" + ext;
            Response.WriteFile(lFilePath);
        }

    }
}
