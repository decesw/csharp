<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultEventControl.aspx.cs" Inherits="_DefaultEventControl" %>

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

     


    </style>
    <script>
        function UrlEncode(val) {
            return window.encodeURIComponent ? window.encodeURIComponent(val) : val.replace(/&/g, '%26');
        }

        function json2html(json) {
            var i, ret = "";
            ret += "<ul>";
            for (i in json) {
                ret += "<li><span class=key>" + i + "</span>";
                if (typeof json[i] === "object") ret += json2html(json[i]);
                else ret += "<span class=split>:</span> <span class=value>" + json[i] + "</span>";
                ret += "</li>";
            }
            ret += "</ul>";
            return ret;
        }
    </script>
</head>
<body>
    
    <form id="form1" runat="server">

        <h2>GEODI Event Servisleri - Örnek Uygulama</h2>
        <br />
        <p>
            Bu uygulama <a href="https://decesw.atlassian.net/wiki/spaces/PAR/pages/1363017738/Kullan+c+Olaylar+n+izleme+Olay+Ge+mi+ine+Ula+ma" target="_blank">GEODI Olay İzleme</a> üzerindeki canlı olay izleme yöntemini içermektedir. 
        </p>

         <div>

            <ul>
                <li>Bu örnek proje için Web.config altında UseRoles ayarı açılmalıdır.</li>
                <li>GEODI/Settings/Events altına aşağıdaki içerik "<i>.jSettings</i>" uzantılı bir dosya olarak atılmalıdır.
                    <br />
                    <br />
<code>    {
        DisplayName:"Örnek Olay Yakalama",
        __type: "Factory.ActionFactory:UrlCallerEventHandler",
        ServiceURL: "<asp:Label runat="server" ID="lblGetEvents"></asp:Label>?wsName={wsName}&contentid={data}&event={event}",
        ActionTargets: "*",
        EventTargets:["ContentViewer"]
    }</code>

                </li>
            </ul>
        </div>


        <br />
                         
        
        <h3>Olaylar <asp:Button ID="btnRefresh" runat="server" Text="Yenile" /></h3>
        <asp:TextBox ID="txtEvents" runat="server" Height="100px" ReadOnly="true" disabled TextMode="MultiLine" Width="90%"></asp:TextBox>
                      
                   

    </form>
</body>
</html>
