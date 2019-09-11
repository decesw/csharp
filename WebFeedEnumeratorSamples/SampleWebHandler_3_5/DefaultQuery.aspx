<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultQuery.aspx.cs" Inherits="_DefaultQuery" %>

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


        #qureyResultJSON {
            max-height:400px;
            overflow:auto;
        }
         .key {
            color: red;
        }

        .split {
            color: red;
        }

        .value {
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

        <h2>GEODI Sorgu Servisleri - Örnek Uygulama</h2>
        <br />
        <p>
            Bu uygulama <a href="https://decesw.atlassian.net/wiki/spaces/PAR/pages/86295560/Geodi+Query+API+-+Dok+man+Arama" target="_blank">GEODI Query Api</a> üzerindeki uzaktan sorgulama yöntemlerini içermektedir. 
        </p>

        <br />
                               <fieldset >
                                   <legend>Sorgulama için formu doldurunuz.</legend>

                                   
                            WorkspaceName : <asp:TextBox ID="txtWsName" runat="server"></asp:TextBox><br />
                            Sorgu : <asp:TextBox ID="txtQuery" runat="server"></asp:TextBox>
        <a href="https://decesw.atlassian.net/wiki/spaces/PAR/pages/86316510" target="_blank">
        <asp:Button ID="btnQuery" runat="server" OnClick="btnQuery_Click" Text="Sorgula" />
        </a>
        <asp:TextBox ID="txtQueryResult" runat="server" Height="100px" ReadOnly="true" Visible="false" disabled TextMode="MultiLine" Width="90%"></asp:TextBox>
                            <div id="qureyResultJSON">
                                <script>
                                    
                                    var el = document.getElementById("txtQueryResult");
                                    if (el && el.value && JSON && JSON.parse) {
                                        document.getElementById("qureyResultJSON").innerHTML = json2html(JSON.parse(el.value));
                                    }
                                </script>
                            </div>
        <br />
                        </fieldset>
                   

    </form>
</body>
</html>
