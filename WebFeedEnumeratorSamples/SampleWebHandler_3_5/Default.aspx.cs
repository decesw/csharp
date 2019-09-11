using Geodi.Integration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string lUrl = Settings.GetRequestUrl("default.aspx");
        lblGetRoles.Text = string.Concat(lUrl, "/", "GetRoles.ashx");
        lblGetContets.Text = string.Concat(lUrl, "/", "GetContents.ashx");

    }

    protected void btnFeedOne_Click(object sender, EventArgs e)
    {

        if (FileUpload1.PostedFile == null || FileUpload1.PostedFile.ContentLength==0) {
            lblFeedStatus.Text = "File Required";
            return;
        }

        string RequestUrl = Settings.GetRequestUrl("default.aspx");
        bool lUseRoles = Settings.UseRoles;


        IntegrationObject files = new IntegrationObject();
        files.Contents = new List<ContentObject>();



        

        
        ContentObject item = new ContentObject();
        item.DisplayName = FileUpload1.PostedFile.FileName;
        item.ContentSize = FileUpload1.PostedFile.ContentLength;
        item.Content = new ContentData();
        item.Content.Extension = Path.GetExtension(FileUpload1.PostedFile.FileName);



        if (!chkDisableInterServerCommunication.Checked)
        {
            string lFile = Path.Combine(Server.MapPath("~/SampleDocuments"), FileUpload1.PostedFile.FileName);
            FileUpload1.PostedFile.SaveAs(lFile);
            item.ContentDate = File.GetLastWriteTimeUtc(lFile);
            //item.Content.ContentId = FileUpload1.PostedFile.FileName;//Ayrıca ContentId verilmezse Url Id kabul edilir.
            item.ContentURL = string.Concat(RequestUrl, "/GetContent.ashx?content=", HttpUtility.UrlEncode(FileUpload1.PostedFile.FileName));
        }
        else {
            item.ContentDate = DateTime.UtcNow;
            item.Content.ContentId = FileUpload1.PostedFile.FileName;
            byte[] allData = new byte[FileUpload1.PostedFile.ContentLength];
            FileUpload1.PostedFile.InputStream.Read(allData, 0, allData.Length);
            item.Content.ContentForcedBytes = allData;
        }



        item.MetaData = new List<Geodi.Integration.MetaData>();

        ////Dokümanın tam metnini gönderme
        //if (file.Name == "307892347de8f29524fbe94e06aada9b246513709e006.pdf")
        //    item.TextURL=string.Concat(RequestUrl, "/GetText.ashx?content=", HttpUtility.UrlEncode(file.Name));
        //item.TextURL tanımlı ise metin önce bu adrese sorulur. ["Page1", "Page2] veya sayfalama yoksa/bilinmiyorsa Metin dönülebilir.
        //Bu adres tanımıszsa veya boş sonuç ContentURL kullanılır.
        //ContentURL görüntüleyiciler için mutlaka her zaman cevap veren bir adres olmalıdır.

        ////Doküman için ek Metin gönderme
        //if (file.Name == "307892347de8f29524fbe94e06aada9b246513709e006.pdf")
        //    item.TextData = new string[] { "Page1", "Page2" };//her sayfa için metin ayrı ayrı biliniyor
        //else
        //    item.TextData = new string[] { "SampleTextData" }; //sayfalar bilinmiyor veya yok.

        Geodi.Integration.MetaData meta = new Geodi.Integration.MetaData();
        meta.Name = "Alan";
        meta.Value = "FeedTest";
        item.MetaData.Add(meta);


        //Özel yetki tanımlanmış ve GEODI/Settings/RoleProivder altında GetRoles servis adresiniz tanımlanmamışsa bu içerikleri Sistem Yöneticisi dışında kimse göremez.
        if (lUseRoles)
        {
            item.Permission = new Permissions();
            item.Permission.Permit = new string[] { "Role1", "Role3" };
        }
        files.Contents.Add(item);







        Geodi.Integration.RestApi.FeedApi FeedService = new Geodi.Integration.RestApi.FeedApi(
            Settings.GEODIUrl, Settings.GEODIToken);

        

        if (FeedService.BulkFeed(files, null, null, 300000, null, null))
        {
            lblFeedStatus.Text = "OK";
        }
        else
            lblFeedStatus.Text = "NOK";

    }

}