using Geodi.Integration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _DefaultQuery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string lUrl = Settings.GetRequestUrl("default.aspx");
    }

    class MyQuery {
        public MyQuery() {
            this.EndIndex = 10;
        }
        public string SearchString { get; set; }
        public int EndIndex { get; set; }
    }

    class MyResut {
        public int ContentIdentifier { get; set; }
        public Dictionary<string, object> AdditionalValues { get; set; }
    }

    protected void btnQuery_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.txtWsName.Text))
        {
            this.txtQueryResult.Text = "[\"Workspace Name Required\"]";
            this.txtQueryResult.Visible = true;
            return;
        }
        
        System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();

        //Özel parametreler
        parameters["RunUpdateClientDate"] = "true"; //Eski GEODI sürümlerinde parametrede yazım hatası mevcut.
        parameters["RunUpdateClientData"] = "true";
        //parameters["ForLoadEditor"] = "ES";//ContentData içeriğinde sadece basit bilgileri getir.


        parameters["wsName"] = this.txtWsName.Text;
        MyQuery q = new MyQuery();
        q.SearchString = this.txtQuery.Text;
        parameters["query"] = Geodi.Integration.RestApi.Helper.ToJSON(q);
        //Advanced QueryApi
        this.txtQueryResult.Text = Geodi.Integration.RestApi.Helper.Request(Settings.GEODIUrl, Settings.GEODIToken, "GeodiJSONService", "getDocuments", parameters, 30000);
        this.txtQueryResult.Visible = true;

        //Deserialize örnekleri
        //object aa=Geodi.Integration.RestApi.Helper.JSONToObject(this.txtQueryResult.Text); ;
        //List< MyResut> myResultList=Geodi.Integration.RestApi.Helper.JSONTo<List<MyResut>>(this.txtQueryResult.Text); ;



        //Basitleştirilmiş sonuçlar için  Geodi.Integration.RestApi.QueryApi kullanılabilir. Çok daha az bilgi sağlar, Tüm parametreleri kabul etmez.


    }
}