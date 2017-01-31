using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace SampleApplicationService.Controllers
{
    public class ContentController : ApiController
    {
        //GET api/content/5
        public HttpResponseMessage Get(string id)
        {
            string lFilePath = Path.Combine(HttpContext.Current.Server.MapPath("~/SampleDocuments"), id);
            string ext = Path.GetExtension(lFilePath).Substring(0);
            var content = new StreamContent(new FileStream(lFilePath, FileMode.Open, FileAccess.Read));
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK) { Content = content };
            var contentDisposition = new ContentDispositionHeaderValue("attachment") { FileName = Path.GetFileName(lFilePath) };
            response.Content.Headers.ContentDisposition = contentDisposition;
            string mediaType = "Application/" + ext;
            response.Content.Headers.ContentType = new MediaTypeHeaderValue(mediaType);
            return response;
        }
    }
}