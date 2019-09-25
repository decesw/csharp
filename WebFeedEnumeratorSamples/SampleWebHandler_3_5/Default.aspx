<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GEODI Besleme Servisi Kullanımı -  Örnek Uygulama</title>
    <style type="text/css">
        body{
            padding: 10px;
            font-family: Tahoma;
            line-height: 1.5em;
            max-width:800px;
        }
        input,textarea 
        {
            font-family: Tahoma;
            line-height: 1.5em;
            margin:5px;
        }

        p, h1, h2, h3 {
            margin-top: 5px;
            margin-bottom: 5px;
            font-weight:normal;
            text-indent:30px;
        }
        

        a, a:visited {
            text-decoration:none;
            color:#3F51B5;
        }
         a:hover {
            text-decoration:underline;
        }

        code {
            white-space: pre;
            padding: 10px;
            border: 1px solid #999;
            display: block;
            border-radius: 10px;
            margin-right:60px;
        }


    

    </style>
   
</head>
<body>
    
    <form id="form1" runat="server">

        <h2>GEODI İçerik Besleme Servisleri - Örnek Uygulama</h2>
        <br />
        <p>
            Bu uygulama <a href="https://decesw.atlassian.net/wiki/spaces/PAR/pages/47579138" target="_blank">GEODI Feed Api</a> üzerindeki uzaktan besleme yöntemlerini içermektedir. Örnekler projedeki WebHandler içeriklerinde bulunmaktadır.
            <font color="red">IIS üzerinde kullanımda Tümleşik Modda bir uygulama hazvuzu gerektirir.</font>
        </p>

        <p>
            APP->GEODI  ve GEODI->APP alternatif yöntemlerdir. Birlikte test edilmesi, kullanılması gerekli değildir.
        </p>

        <br />
        <div>
            <h3><a href="https://decesw.atlassian.net/wiki/spaces/PAR/pages/86316691" target="_blank">APP -> GEODI</a></h3>
            <p>
                Web.Config dosyasında GEODIUrl ve GEODIToken tanımları yapılmış olmalıdır. <i>Aşağıdaki yöntemler ile dosya göndermeyi deneyebilirsiniz</i>
                <ul>
                    <li> Projede tanımlı "SampleDocuments" klasörü altındaki örnek dosyaları şimdi GEODI'ye göndermek için <a href="FeedNow.ashx" target="_blank">tıklayınız</a> <br />
                        <small>
                            Örnek uygulama kendi adresini adres satırından alarak GEODI'ye bildirir. GEODI içeriğe geri dönüp erişemezse (!) hataları gösterebilir. Bu örnek uygulamada GEODI sunucusu tarafından erişilebilir bir adres kullanmalısınız.
                        </small>

                    </li>
                    <li> Seçeceğiniz bir dosyayı göndermek için formu doldurunuz.
                        <fieldset >
                            <legend>Form </legend>
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                            <asp:CheckBox ID="chkDisableInterServerCommunication" runat="server" Text="(*) Dosya içeriğini istekle birlikte gönder (Önerilmez)" />
                            <asp:Button ID="btnFeedOne" runat="server" OnClick="btnFeedOne_Click" Text="Gönder" />
                            <br /><asp:Label runat="server" ID="lblFeedStatus"></asp:Label>
                        </fieldset>
                        <br />
                        <small>
                            (*) - Seçili olduğu durumda GEODI üzerinde yedekleme aktif değilse GEODI veri tutmadığı için viewerlar çalışmaz.<br />
                            (*) - Seçili olmadığı durumda bu örnek uygulamadaki dosyalar "SampleDocuments" klasöründe tutulur. yeniden erişilebilir. Daha az network trafiği ve daha az sistem yükü ile GEODI'ye iletilir. Bu örnek için "SampleDocuments" klasörüne yazma yetkisi gerektirir. <br />
                            (*) - Seçili olmadığı durumda örnek uygulama kendi adresini adres satırından alarak GEODI'ye bildirir. GEODI içeriğe geri dönüp erişemezse (!) hataları gösterebilir. Bu örnek uygulamada GEODI sunucusu tarafından erişilebilir bir adres kullanmalısınız.
                            </small>
                        <br />
                    </li>

                    <li> Sorgulama için <a href="DefaultQuery.aspx" target="_blank">tıklayınız.</a></li>
                    <li> Viewer olay izleme için <a href="DefaultEventControl.aspx" target="_blank">tıklayınız.</a></li>
                    
                </ul>
            </p>
        </div>
        
    
        <div>
            <h3><a href="https://decesw.atlassian.net/wiki/spaces/PAR/pages/86316510" target="_blank">GEODI -> APP</a></h3>
            <p>
                GEODI üzerinde kullanılan projeye bir "İçerik Besleme Servisi" kaynağı eklenmeli. Bu Servis adresi olarak
            "<i><asp:Label runat="server" ID="lblGetContets"></asp:Label></i> " yazılmalıdır.
                GEODI tarama sırasında bu adrese başvuracaktır.
            </p>
        </div>
        <br />
        <div>
            <h3><a href="https://decesw.atlassian.net/wiki/spaces/PAR/pages/447578207" target="_blank">Kullanıcı yetkilerini paylaşma</a></h3>
            <p>
                Aşağıdaki işlemler yapılıp besleme servisleri kullanıldığında ( APP -> GEODI veya GEODI -> APP) Bu örnek proje içerisinde tanımlanan Roller GEODI ile paylaşılacak ve sadece izin verilen kullanıcılar içerikleri görebilecektir.
            </p>
            <ul>
                <li>Bu örnek proje için Web.config altında UseRoles ayarı açılmalıdır.</li>
                <li>GEODI/Settings/RoleProvider altına aşağıdaki içerik "<i>.jSettings</i>" uzantılı bir dosya olarak atılmalıdır.
                    <br />
                    <br />
<pre>    {
        DisplayName:"Örnek Uygulama",
        __type: "Factory.ActionFactory:ServerBasedRoleProvider",
        ServiceURL: "<asp:Label runat="server" ID="lblGetRoles"></asp:Label>",
        ActionTargets: "*"
    }</pre>

                </li>
            </ul>
        </div>

    </form>
</body>
</html>
