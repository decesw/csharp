using Geodi.Integration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace SampleApplicationService.Controllers
{
    public class GetContentsController : ApiController
    {
        // GET api/getcontents
        public JsonResult<IntegrationObject> Get(string changeKey = "")
        {

            DateTime MyChangeKeyStart = DateTime.MinValue;
            if (!string.IsNullOrEmpty(changeKey))
                MyChangeKeyStart = DateTime.Parse(changeKey, System.Globalization.CultureInfo.InvariantCulture);

            var rtn = new IntegrationObject()
            {
                ChangeKey = DateTime.Now.ToString(System.Globalization.CultureInfo.InvariantCulture),
                Contents = new List<ContentObject>()
            };

            string lContentFolder = HttpContext.Current.Server.MapPath("~/SampleDocuments");
            string lUrlStart= HttpContext.Current.Request.Url.ToString();

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
                        ContentURL = lUrlStart+ "/content?id=" + System.Web.HttpUtility.UrlEncode(file.Name),
                        ContentDate = file.LastWriteTime,
                    };
                    rtn.Contents.Add(contentItem);
                }
            return Json(rtn);
        }
    }
}
